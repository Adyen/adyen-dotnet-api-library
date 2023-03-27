using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.Serialization;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Util;

#nullable enable

public class JsonPropertyNameStringEnumConverter : GeneralJsonStringEnumConverter
{
    public JsonPropertyNameStringEnumConverter() : base() { }
    public JsonPropertyNameStringEnumConverter(JsonNamingPolicy? namingPolicy = default, bool allowIntegerValues = true) : base(namingPolicy, allowIntegerValues) { }

    protected override bool TryOverrideName(Type enumType, string name, out ReadOnlyMemory<char> overrideName)
    {
        if (JsonEnumExtensions.TryGetEnumAttribute<JsonPropertyNameAttribute>(enumType, name, out var attr) && attr.Name != null)
        {
            overrideName = attr.Name.AsMemory();
            return true;
        }
        return base.TryOverrideName(enumType, name, out overrideName);
    }
}

public delegate bool TryOverrideName(Type enumType, string name, out ReadOnlyMemory<char> overrideName);

public class GeneralJsonStringEnumConverter : JsonConverterFactory
{
    readonly JsonNamingPolicy? namingPolicy;
    readonly bool allowIntegerValues;
    
    public GeneralJsonStringEnumConverter() : this(null, true) { }
    
    public GeneralJsonStringEnumConverter(JsonNamingPolicy? namingPolicy = default, bool allowIntegerValues = true) => (this.namingPolicy, this.allowIntegerValues) = (namingPolicy, allowIntegerValues);

    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsEnum || Nullable.GetUnderlyingType(typeToConvert)?.IsEnum == true;

    public sealed override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var enumType = Nullable.GetUnderlyingType(typeToConvert) ?? typeToConvert;
        var flagged = enumType.IsDefined(typeof(FlagsAttribute), true);
        JsonConverter enumConverter;
        TryOverrideName tryOverrideName = (Type t, string n, out ReadOnlyMemory<char> o) => TryOverrideName(t, n, out o);
        var converterType = (flagged ? typeof(FlaggedJsonEnumConverter<>) : typeof(UnflaggedJsonEnumConverter<>)).MakeGenericType(new [] {enumType});
        enumConverter = (JsonConverter)Activator.CreateInstance(converterType,
                                                                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                binder: null,
                                                                args: new object[] { namingPolicy!, allowIntegerValues, tryOverrideName },
                                                                culture: null)!;
        if (enumType == typeToConvert)
            return enumConverter;
        else
        {
            var nullableConverter = (JsonConverter)Activator.CreateInstance(typeof(NullableConverterDecorator<>).MakeGenericType(new [] {enumType}), 
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            binder: null,
                                                                            args: new object[] { enumConverter },
                                                                            culture: null)!;
            return nullableConverter;
        }
    }
    
    protected virtual bool TryOverrideName(Type enumType, string name, out ReadOnlyMemory<char> overrideName)
    {
        overrideName = default;
        return false;
    }
    
    class FlaggedJsonEnumConverter<TEnum> : JsonEnumConverterBase<TEnum> where TEnum: struct, Enum
    {
        private const char FlagSeparatorChar = ',';
        private const string FlagSeparatorString = ", ";

        public FlaggedJsonEnumConverter(JsonNamingPolicy? namingPolicy, bool allowNumbers, TryOverrideName? tryOverrideName) : base(namingPolicy, allowNumbers, tryOverrideName) { }

        protected override bool TryFormatAsString(EnumData<TEnum> [] enumData, TEnum value, out ReadOnlyMemory<char> name)
        {
            UInt64 UInt64Value = JsonEnumExtensions.ToUInt64(value, EnumTypeCode);
            var index = enumData.BinarySearchFirst(UInt64Value, EntryComparer);
            if (index >= 0)
            {
                // A single flag
                name = enumData[index].name;
                return true;
            }
            if (UInt64Value != 0)
            {
                StringBuilder? sb = null;
                for (int i = (~index) - 1; i >= 0; i--)
                {
                    if ((UInt64Value & enumData[i].UInt64Value) ==  enumData[i].UInt64Value && enumData[i].UInt64Value != 0)
                    {
                        if (sb == null)
                        {
                            sb = new StringBuilder();
                            sb.Append(enumData[i].name.Span);
                        }
                        else
                        {
                            sb.Insert(0, FlagSeparatorString);
                            sb.Insert(0, enumData[i].name.Span);
                        }
                        UInt64Value -= enumData[i].UInt64Value;
                    }
                }
                if (UInt64Value == 0 && sb != null)
                {
                    name = sb.ToString().AsMemory();
                    return true;
                }
            }
            name = default;
            return false;
        }

        protected override bool TryReadAsString(EnumData<TEnum> [] enumData, ILookup<ReadOnlyMemory<char>, int> nameLookup, ReadOnlyMemory<char> name, out TEnum value)
        {
            UInt64 UInt64Value = 0;
            foreach (var slice in name.Split(FlagSeparatorChar, StringSplitOptions.TrimEntries))
            {
                if (JsonEnumExtensions.TryLookupBest<TEnum>(enumData, nameLookup, slice, out TEnum thisValue))
                    UInt64Value |= thisValue.ToUInt64(EnumTypeCode);
                else
                {
                    value = default;
                    return false;
                }
            }
            value = JsonEnumExtensions.FromUInt64<TEnum>(UInt64Value);
            return true;
        }
    }

    class UnflaggedJsonEnumConverter<TEnum> : JsonEnumConverterBase<TEnum> where TEnum: struct, Enum
    {
        public UnflaggedJsonEnumConverter(JsonNamingPolicy? namingPolicy, bool allowNumbers, TryOverrideName? tryOverrideName) : base(namingPolicy, allowNumbers, tryOverrideName) { }

        protected override bool TryFormatAsString(EnumData<TEnum> [] enumData, TEnum value, out ReadOnlyMemory<char> name)
        {
            var index = enumData.BinarySearchFirst(JsonEnumExtensions.ToUInt64(value, EnumTypeCode), EntryComparer);
            if (index >= 0)
            {
                name = enumData[index].name;
                return true;
            }
            name = default;
            return false;
        }
        protected override bool TryReadAsString(EnumData<TEnum> [] enumData, ILookup<ReadOnlyMemory<char>, int> nameLookup, ReadOnlyMemory<char> name, out TEnum value) => 
            JsonEnumExtensions.TryLookupBest(enumData, nameLookup, name, out value);
    }

    abstract class JsonEnumConverterBase<TEnum> : JsonConverter<TEnum> where TEnum: struct, Enum
    {
        protected static TypeCode EnumTypeCode { get; } = Type.GetTypeCode(typeof(TEnum));  
        protected static Func<EnumData<TEnum>, UInt64, int> EntryComparer { get; } = (item, key) => item.UInt64Value.CompareTo(key);

        private bool AllowNumbers { get; }
        private EnumData<TEnum> [] EnumData { get; }
        private ILookup<ReadOnlyMemory<char>, int> NameLookup { get; }

        public JsonEnumConverterBase(JsonNamingPolicy? namingPolicy, bool allowNumbers, TryOverrideName? tryOverrideName) 
        {
            this.AllowNumbers = allowNumbers;
            this.EnumData = JsonEnumExtensions.GetData<TEnum>(namingPolicy, tryOverrideName).ToArray();
            this.NameLookup = JsonEnumExtensions.GetLookupTable<TEnum>(this.EnumData);
        }

        public sealed override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            // Todo: consider caching a small number of JsonEncodedText values for the first N enums encountered, as is done in 
            // https://github.com/dotnet/runtime/blob/main/src/libraries/System.Text.Json/src/System/Text/Json/Serialization/Converters/Value/EnumConverter.cs
            if (TryFormatAsString(EnumData, value, out var name))
                writer.WriteStringValue(name.Span);
            else
            {
                if (!AllowNumbers)
                    throw new JsonException();
                WriteEnumAsNumber(writer, value);
            }
        }

        protected abstract bool TryFormatAsString(EnumData<TEnum> [] enumData, TEnum value, out ReadOnlyMemory<char> name);

        protected abstract bool TryReadAsString(EnumData<TEnum> [] enumData, ILookup<ReadOnlyMemory<char>, int> nameLookup, ReadOnlyMemory<char> name, out TEnum value);

        public sealed override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.TokenType switch
            {
                JsonTokenType.String => TryReadAsString(EnumData, NameLookup, reader.GetString().AsMemory(), out var value) ? value : throw new JsonException(),
                JsonTokenType.Number => AllowNumbers ? ReadNumberAsEnum(ref reader) : throw new JsonException(),
                _ => throw new JsonException(),
            };

        static void WriteEnumAsNumber(Utf8JsonWriter writer, TEnum value)
        {
            switch (EnumTypeCode)
            {
                case TypeCode.SByte:
                    writer.WriteNumberValue(Unsafe.As<TEnum, SByte>(ref value));
                    break;
                case TypeCode.Int16:
                    writer.WriteNumberValue(Unsafe.As<TEnum, Int16>(ref value));
                    break;
                case TypeCode.Int32:
                    writer.WriteNumberValue(Unsafe.As<TEnum, Int32>(ref value));
                    break;
                case TypeCode.Int64:
                    writer.WriteNumberValue(Unsafe.As<TEnum, Int64>(ref value));
                    break;
                case TypeCode.Byte:
                    writer.WriteNumberValue(Unsafe.As<TEnum, Byte>(ref value));
                    break;
                case TypeCode.UInt16:
                    writer.WriteNumberValue(Unsafe.As<TEnum, UInt16>(ref value));
                    break;
                case TypeCode.UInt32:
                    writer.WriteNumberValue(Unsafe.As<TEnum, UInt32>(ref value));
                    break;
                case TypeCode.UInt64:
                    writer.WriteNumberValue(Unsafe.As<TEnum, UInt64>(ref value));
                    break;
                default:
                    throw new JsonException();
            }
        }

        static TEnum ReadNumberAsEnum(ref Utf8JsonReader reader)
        {
            switch (EnumTypeCode)
            {
                case TypeCode.SByte:
                    {
                        var i = reader.GetSByte();
                        return Unsafe.As<SByte, TEnum>(ref i);
                    };
                case TypeCode.Int16:
                    {
                        var i = reader.GetInt16();
                        return Unsafe.As<Int16, TEnum>(ref i);
                    };
                case TypeCode.Int32:
                    {
                        var i = reader.GetInt32();
                        return Unsafe.As<Int32, TEnum>(ref i);
                    };
                case TypeCode.Int64:
                    {
                        var i = reader.GetInt64();
                        return Unsafe.As<Int64, TEnum>(ref i);
                    };
                case TypeCode.Byte:
                    {
                        var i = reader.GetByte();
                        return Unsafe.As<Byte, TEnum>(ref i);
                    };
                case TypeCode.UInt16:
                    {
                        var i = reader.GetUInt16();
                        return Unsafe.As<UInt16, TEnum>(ref i);
                    };
                case TypeCode.UInt32:
                    {
                        var i = reader.GetUInt32();
                        return Unsafe.As<UInt32, TEnum>(ref i);
                    };
                case TypeCode.UInt64:
                    {
                        var i = reader.GetUInt64();
                        return Unsafe.As<UInt64, TEnum>(ref i);
                    };
                default:
                    throw new JsonException();
            }
        }
    }
}

public sealed class NullableConverterDecorator<T> : JsonConverter<T?> where T : struct
{
    // Read() and Write() are never called with null unless HandleNull is overwridden -- which it is not.
    readonly JsonConverter<T> innerConverter;
    public NullableConverterDecorator(JsonConverter<T> innerConverter) => this.innerConverter = innerConverter ?? throw new ArgumentNullException(nameof(innerConverter));
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => innerConverter.Read(ref reader, Nullable.GetUnderlyingType(typeToConvert)!, options);
    public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options) => innerConverter.Write(writer, value!.Value, options);
    public override bool CanConvert(Type type) => base.CanConvert(type) && innerConverter.CanConvert(Nullable.GetUnderlyingType(type)!);
}

internal readonly record struct EnumData<TEnum>(ReadOnlyMemory<char> name, TEnum value, UInt64 UInt64Value) where TEnum : struct, Enum;

public static class JsonEnumExtensions
{
    public static bool TryGetEnumAttribute<TAttribute>(Type type, string name, [System.Diagnostics.CodeAnalysis.NotNullWhen(returnValue: true)] out TAttribute? attribute) where TAttribute : System.Attribute
    {
        var member = type.GetMember(name).SingleOrDefault();
        attribute = member?.GetCustomAttribute<TAttribute>(false);
        return attribute != null;
    }
    
    public static UInt64 ToUInt64<TEnum>(this TEnum value) where TEnum : struct, Enum => value.ToUInt64(Type.GetTypeCode(typeof(TEnum)));
    
    internal static UInt64 ToUInt64<TEnum>(this TEnum value, TypeCode enumTypeCode) where TEnum : struct, Enum
    {
        Debug.Assert(enumTypeCode == Type.GetTypeCode(typeof(TEnum)));
        return enumTypeCode switch
        {
            TypeCode.SByte => unchecked((ulong)Unsafe.As<TEnum, SByte>(ref value)),
            TypeCode.Int16 => unchecked((ulong)Unsafe.As<TEnum, Int16>(ref value)),
            TypeCode.Int32 => unchecked((ulong)Unsafe.As<TEnum, Int32>(ref value)),
            TypeCode.Int64 => unchecked((ulong)Unsafe.As<TEnum, Int64>(ref value)),
            TypeCode.Byte => Unsafe.As<TEnum, Byte>(ref value),
            TypeCode.UInt16 => Unsafe.As<TEnum, UInt16>(ref value),
            TypeCode.UInt32 => Unsafe.As<TEnum, UInt32>(ref value),
            TypeCode.UInt64 => Unsafe.As<TEnum, UInt64>(ref value),
            _ => throw new ArgumentException(enumTypeCode.ToString()),
        };
    }

    public static TEnum FromUInt64<TEnum>(this UInt64 value) where TEnum : struct, Enum => value.FromUInt64<TEnum>(Type.GetTypeCode(typeof(TEnum)));
    
    internal static TEnum FromUInt64<TEnum>(this UInt64 value, TypeCode enumTypeCode) where TEnum : struct, Enum
    {
        Debug.Assert(enumTypeCode == Type.GetTypeCode(typeof(TEnum)));
        switch (enumTypeCode)
        {
            case TypeCode.SByte:
                {
                    var i = unchecked((SByte)value);
                    return Unsafe.As<SByte, TEnum>(ref i);
                };
            case TypeCode.Int16:
                {
                    var i = unchecked((Int16)value);
                    return Unsafe.As<Int16, TEnum>(ref i);
                };
            case TypeCode.Int32:
                {
                    var i = unchecked((Int32)value);
                    return Unsafe.As<Int32, TEnum>(ref i);
                };
            case TypeCode.Int64:
                {
                    var i = unchecked((Int64)value);
                    return Unsafe.As<Int64, TEnum>(ref i);
                };
            case TypeCode.Byte:
                {
                    var i = unchecked((Byte)value);
                    return Unsafe.As<Byte, TEnum>(ref i);
                };
            case TypeCode.UInt16:
                {
                    var i = unchecked((UInt16)value);
                    return Unsafe.As<UInt16, TEnum>(ref i);
                };
            case TypeCode.UInt32:
                {
                    var i = unchecked((UInt32)value);
                    return Unsafe.As<UInt32, TEnum>(ref i);
                };
            case TypeCode.UInt64:
                {
                    var i = unchecked((UInt64)value);
                    return Unsafe.As<UInt64, TEnum>(ref i);
                };
            default:
                throw new ArgumentException(enumTypeCode.ToString());
        }
    }
    
    // Return data about the enum sorted by the binary values of the enumeration constants (that is, by their unsigned magnitude)
    internal static IEnumerable<EnumData<TEnum>> GetData<TEnum>(JsonNamingPolicy? namingPolicy, TryOverrideName? tryOverrideName) where TEnum : struct, Enum => 
        GetData<TEnum>(namingPolicy, tryOverrideName, Type.GetTypeCode(typeof(TEnum)));

    // Return data about the enum sorted by the binary values of the enumeration constants (that is, by their unsigned magnitude)
    internal static IEnumerable<EnumData<TEnum>> GetData<TEnum>(JsonNamingPolicy? namingPolicy, TryOverrideName? tryOverrideName, TypeCode enumTypeCode) where TEnum : struct, Enum
    {
        Debug.Assert(enumTypeCode == Type.GetTypeCode(typeof(TEnum)));
        var names = Enum.GetNames<TEnum>();
        var values = Enum.GetValues<TEnum>();
        return names.Zip(values, (n, v) => 
            { 
                if (tryOverrideName == null || !tryOverrideName(typeof(TEnum), n, out var jsonName))
                    jsonName = (namingPolicy == null ? n.AsMemory() : namingPolicy.ConvertName(n).AsMemory());
                return new EnumData<TEnum>(jsonName, v, v.ToUInt64(enumTypeCode));
            });
    }
    
    internal static ILookup<ReadOnlyMemory<char>, int> GetLookupTable<TEnum>(EnumData<TEnum> [] namesAndValues) where TEnum : struct, Enum => 
        Enumerable.Range(0, namesAndValues.Length).ToLookup(i => namesAndValues[i].name, CharMemoryComparer.OrdinalIgnoreCase);
    
    internal static bool TryLookupBest<TEnum>(EnumData<TEnum> [] namesAndValues, ILookup<ReadOnlyMemory<char>, int> lookupTable, ReadOnlyMemory<char> name, out TEnum value) where TEnum : struct, Enum
    {
        int i = 0;
        int firstMatch = -1;
        foreach (var index in lookupTable[name])
        {
            if (firstMatch == -1)
                firstMatch = index;
            else 
            {
                if (i == 1 && MemoryExtensions.Equals(namesAndValues[firstMatch].name.Span, name.Span, StringComparison.Ordinal))
                {
                    value = namesAndValues[firstMatch].value;
                    return true;
                }
                if (MemoryExtensions.Equals(namesAndValues[index].name.Span, name.Span, StringComparison.Ordinal))
                {
                    value = namesAndValues[index].value;
                    return true;
                }
            }
            i++;
        }
        value = (firstMatch == -1 ? default : namesAndValues[firstMatch].value);
        return firstMatch != -1;
    }
}

public static class StringExtensions
{
    public static IEnumerable<ReadOnlyMemory<char>> Split(this ReadOnlyMemory<char> chars, char separator, StringSplitOptions options = StringSplitOptions.None)
    {
        int index;
        while ((index = chars.Span.IndexOf(separator)) >= 0)
        {
            var slice = chars.Slice(0, index);
            if ((options & StringSplitOptions.TrimEntries) == StringSplitOptions.TrimEntries)
                slice = slice.Trim();
            if ((options & StringSplitOptions.RemoveEmptyEntries) == 0 || slice.Length > 0)
                yield return slice;
            chars = chars.Slice(index + 1);
        }
        if ((options & StringSplitOptions.TrimEntries) == StringSplitOptions.TrimEntries)
            chars = chars.Trim();
        if ((options & StringSplitOptions.RemoveEmptyEntries) == 0 || chars.Length > 0)
            yield return chars;
    }
}

public static class ListExtensions
{
    public static int BinarySearch<TValue, TKey>(this TValue [] list, TKey key, Func<TValue, TKey, int> comparer)
    {
        if (list == null || comparer == null)
            throw new ArgumentNullException();
        int low = 0;
        int high = list.Length - 1;
        while (low <= high)
        {
            var mid = low + ((high - low) >> 1);
            var order = comparer(list[mid], key);
            if (order == 0)
                return mid;
            else if (order > 0)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return ~low;
    }
    
    public static int BinarySearchFirst<TValue, TKey>(this TValue [] list, TKey key, Func<TValue, TKey, int> comparer)
    {
        int index = list.BinarySearch(key, comparer);
        for (; index > 0 && comparer(list[index-1], key) == 0; index--)
            ;
        return index;
    }
}

public class CharMemoryComparer : IEqualityComparer<ReadOnlyMemory<char>>
{
    public static CharMemoryComparer OrdinalIgnoreCase { get; } = new CharMemoryComparer(StringComparison.OrdinalIgnoreCase);
    public static CharMemoryComparer Ordinal { get; }  = new CharMemoryComparer(StringComparison.Ordinal);

    readonly StringComparison comparison;
    CharMemoryComparer(StringComparison comparison) => this.comparison = comparison;
    public bool Equals(ReadOnlyMemory<char> x, ReadOnlyMemory<char> y) => MemoryExtensions.Equals(x.Span, y.Span, comparison);
    public int GetHashCode(ReadOnlyMemory<char> obj) => String.GetHashCode(obj.Span, comparison);
}
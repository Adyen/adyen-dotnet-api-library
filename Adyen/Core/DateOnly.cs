using System;
using System.Globalization;

#if NETSTANDARD2_0 || NET462
namespace Adyen.Core
{
    /// <summary>
    /// Date-only value type compatible with .NET Standard 2.0.
    /// </summary>
    public readonly struct DateOnly : IComparable<DateOnly>, IEquatable<DateOnly>
    {
        private static readonly DateTime Epoch =
            new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified);

        private readonly DateTime _value;

        public int Year => _value.Year;
        public int Month => _value.Month;
        public int Day => _value.Day;
        public DayOfWeek DayOfWeek => _value.DayOfWeek;
        public int DayNumber => (int)(_value - Epoch).TotalDays;

        public static DateOnly MinValue => new DateOnly(DateTime.MinValue);
        public static DateOnly MaxValue => new DateOnly(DateTime.MaxValue.Date);

        public DateOnly(int year, int month, int day)
        {
            _value = new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Unspecified);
        }

        private DateOnly(DateTime dateTime)
        {
            _value = dateTime.Date;
        }

        public static DateOnly FromDateTime(DateTime dateTime) => new DateOnly(dateTime);

        public static DateOnly FromDayNumber(int dayNumber) => new DateOnly(Epoch.AddDays(dayNumber));

        public DateTime ToDateTime() => _value;

        public DateTime ToDateTime(TimeSpan time) => _value.Add(time);

        public DateOnly AddDays(int value) => new DateOnly(_value.AddDays(value));

        public DateOnly AddMonths(int value) => new DateOnly(_value.AddMonths(value));

        public DateOnly AddYears(int value) => new DateOnly(_value.AddYears(value));

        public static DateOnly Parse(string s) => Parse(s, CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces);

        public static DateOnly Parse(string s, IFormatProvider provider) => Parse(s, provider, DateTimeStyles.AllowWhiteSpaces);

        public static DateOnly Parse(string s, IFormatProvider provider, DateTimeStyles style) => FromDateTime(DateTime.Parse(s, provider, style));

        public static DateOnly ParseExact(
            string s,
            string format,
            IFormatProvider provider,
            DateTimeStyles style = DateTimeStyles.None)
            => FromDateTime(DateTime.ParseExact(s, format, provider, style));

        public static bool TryParse(string s, out DateOnly result) => TryParse(s, CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces, out result);

        public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
        {
            if (DateTime.TryParse(s, provider, style, out var dt))
            {
                result = FromDateTime(dt);
                return true;
            }

            result = default;
            return false;
        }

        public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
        {
            if (DateTime.TryParseExact(s, format, provider, style, out var dt))
            {
                result = FromDateTime(dt);
                return true;
            }

            result = default;
            return false;
        }

        public int CompareTo(DateOnly other) => _value.CompareTo(other._value);

        public bool Equals(DateOnly other) => _value.Equals(other._value);

        public override bool Equals(object obj) => obj is DateOnly other && Equals(other);

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

        public string ToString(string format, IFormatProvider provider = null) => _value.ToString(format, provider ?? CultureInfo.InvariantCulture);

#region Overloaded operators.
        public static bool operator ==(DateOnly left, DateOnly right) => left.Equals(right);

        public static bool operator !=(DateOnly left, DateOnly right) => !left.Equals(right);

        public static bool operator <(DateOnly left, DateOnly right) => left._value < right._value;

        public static bool operator >(DateOnly left, DateOnly right) => left._value > right._value;

        public static bool operator <=(DateOnly left, DateOnly right) => left._value <= right._value;

        public static bool operator >=(DateOnly left, DateOnly right) => left._value >= right._value;
#endregion
    }
}
#endif

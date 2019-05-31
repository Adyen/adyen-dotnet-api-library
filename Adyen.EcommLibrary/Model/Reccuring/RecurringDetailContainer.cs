using System.Runtime.Serialization;
using System.Text;

namespace Adyen.EcommLibrary.Model.Reccuring
{
    [DataContract]
    public class RecurringDetailContainer
    {
        /// <summary>
        /// details of the result
        /// </summary>
        /// <value>details of the result</value>
        [DataMember(Name = "recurringDetail", EmitDefaultValue = false)]
        public RecurringDetail RecurringDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringDetailContainer {\n");
            sb.Append("  RecurringDetail: ").Append(RecurringDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
/* 
 * SMS Fusion API
 *
 * This is the SMS Fusion API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@smsfusion.com.au
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SMSResult
    /// </summary>
    [DataContract]
    public partial class SMSResult :  IEquatable<SMSResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSResult" /> class.
        /// </summary>
        /// <param name="Id">Unique ID for response.</param>
        /// <param name="Success">Count of queued SMS.</param>
        /// <param name="Cost">Cost of the SMS.</param>
        /// <param name="Count">Total count of SMS queued.</param>
        /// <param name="Failure">List of failed numbers.</param>
        public SMSResult(string Id = default(string), int? Success = default(int?), float? Cost = default(float?), int? Count = default(int?), List<string> Failure = default(List<string>))
        {
            this.Id = Id;
            this.Success = Success;
            this.Cost = Cost;
            this.Count = Count;
            this.Failure = Failure;
        }
        
        /// <summary>
        /// Unique ID for response
        /// </summary>
        /// <value>Unique ID for response</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Count of queued SMS
        /// </summary>
        /// <value>Count of queued SMS</value>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public int? Success { get; set; }
        /// <summary>
        /// Cost of the SMS
        /// </summary>
        /// <value>Cost of the SMS</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public float? Cost { get; set; }
        /// <summary>
        /// Total count of SMS queued
        /// </summary>
        /// <value>Total count of SMS queued</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// List of failed numbers
        /// </summary>
        /// <value>List of failed numbers</value>
        [DataMember(Name="failure", EmitDefaultValue=false)]
        public List<string> Failure { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SMSResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Failure: ").Append(Failure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SMSResult);
        }

        /// <summary>
        /// Returns true if SMSResult instances are equal
        /// </summary>
        /// <param name="other">Instance of SMSResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SMSResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
                ) && 
                (
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Failure == other.Failure ||
                    this.Failure != null &&
                    this.Failure.SequenceEqual(other.Failure)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Failure != null)
                    hash = hash * 59 + this.Failure.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

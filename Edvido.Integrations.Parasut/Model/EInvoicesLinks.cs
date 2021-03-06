﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
 

    [DataContract]
    public partial class EInvoicesLinks : IEquatable<EInvoicesLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EInvoicesLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EInvoicesLinks(string Self = default(string))
        {
            this.Self = Self;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string Self { get; private set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EInvoicesLinks {\n");
            sb.Append("  self: ").Append(Self).Append("\n");
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
            return this.Equals(obj as InlineResponse200Meta);
        }

        /// <summary>
        /// Returns true if InlineResponse200Meta instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200Meta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200Meta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true;
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();

                return hash;    
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        public bool Equals(EInvoicesLinks other)
        {
            return true;
        }
    }
}

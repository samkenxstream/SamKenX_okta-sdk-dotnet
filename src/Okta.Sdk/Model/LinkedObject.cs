/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// LinkedObject
    /// </summary>
    [DataContract(Name = "LinkedObject")]
    
    public partial class LinkedObject : IEquatable<LinkedObject>
    {
        
        /// <summary>
        /// Gets or Sets Associated
        /// </summary>
        [DataMember(Name = "associated", EmitDefaultValue = false)]
        public LinkedObjectDetails Associated { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name = "primary", EmitDefaultValue = false)]
        public LinkedObjectDetails Primary { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Dictionary<string, Object> Links { get; private set; }

        /// <summary>
        /// Returns false as Links should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinks()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkedObject {\n");
            sb.Append("  Associated: ").Append(Associated).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LinkedObject);
        }

        /// <summary>
        /// Returns true if LinkedObject instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Associated == input.Associated ||
                    (this.Associated != null &&
                    this.Associated.Equals(input.Associated))
                ) && 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                
                if (this.Associated != null)
                {
                    hashCode = (hashCode * 59) + this.Associated.GetHashCode();
                }
                if (this.Primary != null)
                {
                    hashCode = (hashCode * 59) + this.Primary.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}

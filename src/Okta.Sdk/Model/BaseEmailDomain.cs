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
    /// BaseEmailDomain
    /// </summary>
    [DataContract(Name = "BaseEmailDomain")]
    
    public partial class BaseEmailDomain : IEquatable<BaseEmailDomain>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEmailDomain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BaseEmailDomain() { }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "userName", IsRequired = true, EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BaseEmailDomain {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(input as BaseEmailDomain);
        }

        /// <summary>
        /// Returns true if BaseEmailDomain instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseEmailDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseEmailDomain input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
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
                
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.UserName != null)
                {
                    hashCode = (hashCode * 59) + this.UserName.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}

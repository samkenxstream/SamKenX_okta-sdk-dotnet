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
    /// ProfileMappingProperty
    /// </summary>
    [DataContract(Name = "ProfileMappingProperty")]
    
    public partial class ProfileMappingProperty : IEquatable<ProfileMappingProperty>
    {

        /// <summary>
        /// Gets or Sets PushStatus
        /// </summary>
        [DataMember(Name = "pushStatus", EmitDefaultValue = false)]
        
        public ProfileMappingPropertyPushStatus PushStatus { get; set; }
        
        /// <summary>
        /// Gets or Sets Expression
        /// </summary>
        [DataMember(Name = "expression", EmitDefaultValue = false)]
        public string Expression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProfileMappingProperty {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  PushStatus: ").Append(PushStatus).Append("\n");
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
            return this.Equals(input as ProfileMappingProperty);
        }

        /// <summary>
        /// Returns true if ProfileMappingProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileMappingProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileMappingProperty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
                ) && 
                (
                    this.PushStatus == input.PushStatus ||
                    this.PushStatus.Equals(input.PushStatus)
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
                
                if (this.Expression != null)
                {
                    hashCode = (hashCode * 59) + this.Expression.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PushStatus.GetHashCode();
                return hashCode;
            }
        }

    }

}

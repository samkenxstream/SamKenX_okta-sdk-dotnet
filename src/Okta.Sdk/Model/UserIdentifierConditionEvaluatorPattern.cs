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
    /// UserIdentifierConditionEvaluatorPattern
    /// </summary>
    [DataContract(Name = "UserIdentifierConditionEvaluatorPattern")]
    
    public partial class UserIdentifierConditionEvaluatorPattern : IEquatable<UserIdentifierConditionEvaluatorPattern>
    {

        /// <summary>
        /// Gets or Sets MatchType
        /// </summary>
        [DataMember(Name = "matchType", EmitDefaultValue = false)]
        
        public UserIdentifierMatchType MatchType { get; set; }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserIdentifierConditionEvaluatorPattern {\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as UserIdentifierConditionEvaluatorPattern);
        }

        /// <summary>
        /// Returns true if UserIdentifierConditionEvaluatorPattern instances are equal
        /// </summary>
        /// <param name="input">Instance of UserIdentifierConditionEvaluatorPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserIdentifierConditionEvaluatorPattern input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MatchType == input.MatchType ||
                    this.MatchType.Equals(input.MatchType)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                
                hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}

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
    /// IdpPolicyRuleAction
    /// </summary>
    [DataContract(Name = "IdpPolicyRuleAction")]
    
    public partial class IdpPolicyRuleAction : IEquatable<IdpPolicyRuleAction>
    {
        
        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name = "providers", EmitDefaultValue = false)]
        public List<IdpPolicyRuleActionProvider> Providers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdpPolicyRuleAction {\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
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
            return this.Equals(input as IdpPolicyRuleAction);
        }

        /// <summary>
        /// Returns true if IdpPolicyRuleAction instances are equal
        /// </summary>
        /// <param name="input">Instance of IdpPolicyRuleAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdpPolicyRuleAction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Providers == input.Providers ||
                    this.Providers != null &&
                    input.Providers != null &&
                    this.Providers.SequenceEqual(input.Providers)
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
                
                if (this.Providers != null)
                {
                    hashCode = (hashCode * 59) + this.Providers.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}

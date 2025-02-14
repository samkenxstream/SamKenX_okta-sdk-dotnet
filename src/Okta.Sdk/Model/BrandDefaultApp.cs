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
    /// BrandDefaultApp
    /// </summary>
    [DataContract(Name = "Brand_defaultApp")]
    
    public partial class BrandDefaultApp : IEquatable<BrandDefaultApp>
    {
        
        /// <summary>
        /// Gets or Sets AppInstanceId
        /// </summary>
        [DataMember(Name = "appInstanceId", EmitDefaultValue = false)]
        public string AppInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets AppLinkName
        /// </summary>
        [DataMember(Name = "appLinkName", EmitDefaultValue = false)]
        public string AppLinkName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BrandDefaultApp {\n");
            sb.Append("  AppInstanceId: ").Append(AppInstanceId).Append("\n");
            sb.Append("  AppLinkName: ").Append(AppLinkName).Append("\n");
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
            return this.Equals(input as BrandDefaultApp);
        }

        /// <summary>
        /// Returns true if BrandDefaultApp instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandDefaultApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandDefaultApp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppInstanceId == input.AppInstanceId ||
                    (this.AppInstanceId != null &&
                    this.AppInstanceId.Equals(input.AppInstanceId))
                ) && 
                (
                    this.AppLinkName == input.AppLinkName ||
                    (this.AppLinkName != null &&
                    this.AppLinkName.Equals(input.AppLinkName))
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
                
                if (this.AppInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.AppInstanceId.GetHashCode();
                }
                if (this.AppLinkName != null)
                {
                    hashCode = (hashCode * 59) + this.AppLinkName.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}

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
    /// Brand
    /// </summary>
    [DataContract(Name = "Brand")]
    
    public partial class Brand : IEquatable<Brand>
    {
        
        /// <summary>
        /// Gets or Sets AgreeToCustomPrivacyPolicy
        /// </summary>
        [DataMember(Name = "agreeToCustomPrivacyPolicy", EmitDefaultValue = true)]
        public bool AgreeToCustomPrivacyPolicy { get; set; }

        /// <summary>
        /// Gets or Sets CustomPrivacyPolicyUrl
        /// </summary>
        [DataMember(Name = "customPrivacyPolicyUrl", EmitDefaultValue = false)]
        public string CustomPrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Gets or Sets DefaultApp
        /// </summary>
        [DataMember(Name = "defaultApp", EmitDefaultValue = false)]
        public BrandDefaultApp DefaultApp { get; set; }

        /// <summary>
        /// The language specified as an [IETF BCP 47 language tag](https://datatracker.ietf.org/doc/html/rfc5646).
        /// </summary>
        /// <value>The language specified as an [IETF BCP 47 language tag](https://datatracker.ietf.org/doc/html/rfc5646).</value>
        [DataMember(Name = "displayLanguage", EmitDefaultValue = false)]
        public string DisplayLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; private set; }

        /// <summary>
        /// Returns false as IsDefault should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsDefault()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RemovePoweredByOkta
        /// </summary>
        [DataMember(Name = "removePoweredByOkta", EmitDefaultValue = true)]
        public bool RemovePoweredByOkta { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public BrandLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Brand {\n");
            sb.Append("  AgreeToCustomPrivacyPolicy: ").Append(AgreeToCustomPrivacyPolicy).Append("\n");
            sb.Append("  CustomPrivacyPolicyUrl: ").Append(CustomPrivacyPolicyUrl).Append("\n");
            sb.Append("  DefaultApp: ").Append(DefaultApp).Append("\n");
            sb.Append("  DisplayLanguage: ").Append(DisplayLanguage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RemovePoweredByOkta: ").Append(RemovePoweredByOkta).Append("\n");
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
            return this.Equals(input as Brand);
        }

        /// <summary>
        /// Returns true if Brand instances are equal
        /// </summary>
        /// <param name="input">Instance of Brand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Brand input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreeToCustomPrivacyPolicy == input.AgreeToCustomPrivacyPolicy ||
                    this.AgreeToCustomPrivacyPolicy.Equals(input.AgreeToCustomPrivacyPolicy)
                ) && 
                (
                    this.CustomPrivacyPolicyUrl == input.CustomPrivacyPolicyUrl ||
                    (this.CustomPrivacyPolicyUrl != null &&
                    this.CustomPrivacyPolicyUrl.Equals(input.CustomPrivacyPolicyUrl))
                ) && 
                (
                    this.DefaultApp == input.DefaultApp ||
                    (this.DefaultApp != null &&
                    this.DefaultApp.Equals(input.DefaultApp))
                ) && 
                (
                    this.DisplayLanguage == input.DisplayLanguage ||
                    (this.DisplayLanguage != null &&
                    this.DisplayLanguage.Equals(input.DisplayLanguage))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RemovePoweredByOkta == input.RemovePoweredByOkta ||
                    this.RemovePoweredByOkta.Equals(input.RemovePoweredByOkta)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                
                hashCode = (hashCode * 59) + this.AgreeToCustomPrivacyPolicy.GetHashCode();
                if (this.CustomPrivacyPolicyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CustomPrivacyPolicyUrl.GetHashCode();
                }
                if (this.DefaultApp != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultApp.GetHashCode();
                }
                if (this.DisplayLanguage != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayLanguage.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RemovePoweredByOkta.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}

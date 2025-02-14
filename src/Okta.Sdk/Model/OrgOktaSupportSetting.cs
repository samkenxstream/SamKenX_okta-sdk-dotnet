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
    /// Defines OrgOktaSupportSetting
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class OrgOktaSupportSetting : StringEnum
    {
        /// <summary>
        /// StringEnum OrgOktaSupportSetting for value: DISABLED
        /// </summary>
        public static OrgOktaSupportSetting DISABLED = new OrgOktaSupportSetting("DISABLED");
        /// <summary>
        /// StringEnum OrgOktaSupportSetting for value: ENABLED
        /// </summary>
        public static OrgOktaSupportSetting ENABLED = new OrgOktaSupportSetting("ENABLED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="OrgOktaSupportSetting"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator OrgOktaSupportSetting(string value) => new OrgOktaSupportSetting(value);

        /// <summary>
        /// Creates a new <see cref="OrgOktaSupportSetting"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public OrgOktaSupportSetting(string value)
            : base(value)
        {
        }
    }


}

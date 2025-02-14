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
    /// Defines UserIdentifierMatchType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class UserIdentifierMatchType : StringEnum
    {
        /// <summary>
        /// StringEnum UserIdentifierMatchType for value: CONTAINS
        /// </summary>
        public static UserIdentifierMatchType CONTAINS = new UserIdentifierMatchType("CONTAINS");
        /// <summary>
        /// StringEnum UserIdentifierMatchType for value: EQUALS
        /// </summary>
        public static UserIdentifierMatchType EQUALS = new UserIdentifierMatchType("EQUALS");
        /// <summary>
        /// StringEnum UserIdentifierMatchType for value: EXPRESSION
        /// </summary>
        public static UserIdentifierMatchType EXPRESSION = new UserIdentifierMatchType("EXPRESSION");
        /// <summary>
        /// StringEnum UserIdentifierMatchType for value: STARTS_WITH
        /// </summary>
        public static UserIdentifierMatchType STARTSWITH = new UserIdentifierMatchType("STARTS_WITH");
        /// <summary>
        /// StringEnum UserIdentifierMatchType for value: SUFFIX
        /// </summary>
        public static UserIdentifierMatchType SUFFIX = new UserIdentifierMatchType("SUFFIX");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="UserIdentifierMatchType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator UserIdentifierMatchType(string value) => new UserIdentifierMatchType(value);

        /// <summary>
        /// Creates a new <see cref="UserIdentifierMatchType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public UserIdentifierMatchType(string value)
            : base(value)
        {
        }
    }


}

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
    /// Defines LogCredentialProvider
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class LogCredentialProvider : StringEnum
    {
        /// <summary>
        /// StringEnum LogCredentialProvider for value: DUO
        /// </summary>
        public static LogCredentialProvider DUO = new LogCredentialProvider("DUO");
        /// <summary>
        /// StringEnum LogCredentialProvider for value: GOOGLE
        /// </summary>
        public static LogCredentialProvider GOOGLE = new LogCredentialProvider("GOOGLE");
        /// <summary>
        /// StringEnum LogCredentialProvider for value: OKTA_AUTHENTICATION_PROVIDER
        /// </summary>
        public static LogCredentialProvider OKTAAUTHENTICATIONPROVIDER = new LogCredentialProvider("OKTA_AUTHENTICATION_PROVIDER");
        /// <summary>
        /// StringEnum LogCredentialProvider for value: OKTA_CREDENTIAL_PROVIDER
        /// </summary>
        public static LogCredentialProvider OKTACREDENTIALPROVIDER = new LogCredentialProvider("OKTA_CREDENTIAL_PROVIDER");
        /// <summary>
        /// StringEnum LogCredentialProvider for value: RSA
        /// </summary>
        public static LogCredentialProvider RSA = new LogCredentialProvider("RSA");
        /// <summary>
        /// StringEnum LogCredentialProvider for value: SYMANTEC
        /// </summary>
        public static LogCredentialProvider SYMANTEC = new LogCredentialProvider("SYMANTEC");
        /// <summary>
        /// StringEnum LogCredentialProvider for value: YUBIKEY
        /// </summary>
        public static LogCredentialProvider YUBIKEY = new LogCredentialProvider("YUBIKEY");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="LogCredentialProvider"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator LogCredentialProvider(string value) => new LogCredentialProvider(value);

        /// <summary>
        /// Creates a new <see cref="LogCredentialProvider"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public LogCredentialProvider(string value)
            : base(value)
        {
        }
    }


}

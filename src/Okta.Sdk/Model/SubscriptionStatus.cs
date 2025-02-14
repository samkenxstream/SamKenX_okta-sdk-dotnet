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
    /// Defines SubscriptionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class SubscriptionStatus : StringEnum
    {
        /// <summary>
        /// StringEnum SubscriptionStatus for value: subscribed
        /// </summary>
        public static SubscriptionStatus Subscribed = new SubscriptionStatus("subscribed");
        /// <summary>
        /// StringEnum SubscriptionStatus for value: unsubscribed
        /// </summary>
        public static SubscriptionStatus Unsubscribed = new SubscriptionStatus("unsubscribed");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="SubscriptionStatus"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator SubscriptionStatus(string value) => new SubscriptionStatus(value);

        /// <summary>
        /// Creates a new <see cref="SubscriptionStatus"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public SubscriptionStatus(string value)
            : base(value)
        {
        }
    }


}

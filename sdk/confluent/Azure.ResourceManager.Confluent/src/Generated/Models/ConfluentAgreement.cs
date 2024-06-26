// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> Agreement Terms definition. </summary>
    public partial class ConfluentAgreement : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConfluentAgreement"/>. </summary>
        public ConfluentAgreement()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConfluentAgreement"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publisher"> Publisher identifier string. </param>
        /// <param name="product"> Product identifier string. </param>
        /// <param name="plan"> Plan identifier string. </param>
        /// <param name="licenseTextLink"> Link to HTML with Microsoft and Publisher terms. </param>
        /// <param name="privacyPolicyLink"> Link to the privacy policy of the publisher. </param>
        /// <param name="retrieveOn"> Date and time in UTC of when the terms were accepted. This is empty if Accepted is false. </param>
        /// <param name="signature"> Terms signature. </param>
        /// <param name="isAccepted"> If any version of the terms have been accepted, otherwise false. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfluentAgreement(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string publisher, string product, string plan, string licenseTextLink, string privacyPolicyLink, DateTimeOffset? retrieveOn, string signature, bool? isAccepted, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Publisher = publisher;
            Product = product;
            Plan = plan;
            LicenseTextLink = licenseTextLink;
            PrivacyPolicyLink = privacyPolicyLink;
            RetrieveOn = retrieveOn;
            Signature = signature;
            IsAccepted = isAccepted;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Publisher identifier string. </summary>
        public string Publisher { get; set; }
        /// <summary> Product identifier string. </summary>
        public string Product { get; set; }
        /// <summary> Plan identifier string. </summary>
        public string Plan { get; set; }
        /// <summary> Link to HTML with Microsoft and Publisher terms. </summary>
        public string LicenseTextLink { get; set; }
        /// <summary> Link to the privacy policy of the publisher. </summary>
        public string PrivacyPolicyLink { get; set; }
        /// <summary> Date and time in UTC of when the terms were accepted. This is empty if Accepted is false. </summary>
        public DateTimeOffset? RetrieveOn { get; set; }
        /// <summary> Terms signature. </summary>
        public string Signature { get; set; }
        /// <summary> If any version of the terms have been accepted, otherwise false. </summary>
        public bool? IsAccepted { get; set; }
    }
}

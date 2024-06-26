// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A representation of the available Azure OpenAI enhancement configurations. </summary>
    public partial class AzureChatEnhancementConfiguration
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

        /// <summary> Initializes a new instance of <see cref="AzureChatEnhancementConfiguration"/>. </summary>
        public AzureChatEnhancementConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatEnhancementConfiguration"/>. </summary>
        /// <param name="grounding"> A representation of the available options for the Azure OpenAI grounding enhancement. </param>
        /// <param name="ocr"> A representation of the available options for the Azure OpenAI optical character recognition (OCR) enhancement. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureChatEnhancementConfiguration(AzureChatGroundingEnhancementConfiguration grounding, AzureChatOCREnhancementConfiguration ocr, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Grounding = grounding;
            Ocr = ocr;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A representation of the available options for the Azure OpenAI grounding enhancement. </summary>
        public AzureChatGroundingEnhancementConfiguration Grounding { get; set; }
        /// <summary> A representation of the available options for the Azure OpenAI optical character recognition (OCR) enhancement. </summary>
        public AzureChatOCREnhancementConfiguration Ocr { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> Details of Consumption Properties. </summary>
    public partial class ConsumptionEndpointsProperties
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

        /// <summary> Initializes a new instance of <see cref="ConsumptionEndpointsProperties"/>. </summary>
        internal ConsumptionEndpointsProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionEndpointsProperties"/>. </summary>
        /// <param name="ingestionUri"> Ingestion url to upload the data. </param>
        /// <param name="ingestionResourceId"> Resource Id of ingestion endpoint. </param>
        /// <param name="fileAccessUri"> Url to consume file type. </param>
        /// <param name="fileAccessResourceId"> Resource Id of file access endpoint. </param>
        /// <param name="queryUri"> Url to consume the processed data. </param>
        /// <param name="queryResourceId"> Resource Id of query endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionEndpointsProperties(Uri ingestionUri, ResourceIdentifier ingestionResourceId, Uri fileAccessUri, ResourceIdentifier fileAccessResourceId, Uri queryUri, ResourceIdentifier queryResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IngestionUri = ingestionUri;
            IngestionResourceId = ingestionResourceId;
            FileAccessUri = fileAccessUri;
            FileAccessResourceId = fileAccessResourceId;
            QueryUri = queryUri;
            QueryResourceId = queryResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Ingestion url to upload the data. </summary>
        public Uri IngestionUri { get; }
        /// <summary> Resource Id of ingestion endpoint. </summary>
        public ResourceIdentifier IngestionResourceId { get; }
        /// <summary> Url to consume file type. </summary>
        public Uri FileAccessUri { get; }
        /// <summary> Resource Id of file access endpoint. </summary>
        public ResourceIdentifier FileAccessResourceId { get; }
        /// <summary> Url to consume the processed data. </summary>
        public Uri QueryUri { get; }
        /// <summary> Resource Id of query endpoint. </summary>
        public ResourceIdentifier QueryResourceId { get; }
    }
}

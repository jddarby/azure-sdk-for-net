// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties to attach new disk to the Virtual Machine. </summary>
    public partial class AttachNewDataDiskDetails
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

        /// <summary> Initializes a new instance of <see cref="AttachNewDataDiskDetails"/>. </summary>
        public AttachNewDataDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AttachNewDataDiskDetails"/>. </summary>
        /// <param name="diskSizeGiB"> Size of the disk to be attached in Gibibytes. </param>
        /// <param name="diskName"> The name of the disk to be attached. </param>
        /// <param name="diskType"> The storage type for the disk (i.e. Standard, Premium). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AttachNewDataDiskDetails(int? diskSizeGiB, string diskName, DevTestLabStorageType? diskType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskSizeGiB = diskSizeGiB;
            DiskName = diskName;
            DiskType = diskType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Size of the disk to be attached in Gibibytes. </summary>
        public int? DiskSizeGiB { get; set; }
        /// <summary> The name of the disk to be attached. </summary>
        public string DiskName { get; set; }
        /// <summary> The storage type for the disk (i.e. Standard, Premium). </summary>
        public DevTestLabStorageType? DiskType { get; set; }
    }
}

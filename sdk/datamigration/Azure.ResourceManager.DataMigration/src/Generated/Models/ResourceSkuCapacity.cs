// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes scaling information of a SKU. </summary>
    public partial class ResourceSkuCapacity
    {
        /// <summary> Initializes a new instance of <see cref="ResourceSkuCapacity"/>. </summary>
        internal ResourceSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSkuCapacity"/>. </summary>
        /// <param name="minimum"> The minimum capacity. </param>
        /// <param name="maximum"> The maximum capacity. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="scaleType"> The scale type applicable to the SKU. </param>
        internal ResourceSkuCapacity(long? minimum, long? maximum, long? @default, ResourceSkuCapacityScaleType? scaleType)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
        }

        /// <summary> The minimum capacity. </summary>
        public long? Minimum { get; }
        /// <summary> The maximum capacity. </summary>
        public long? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public long? Default { get; }
        /// <summary> The scale type applicable to the SKU. </summary>
        public ResourceSkuCapacityScaleType? ScaleType { get; }
    }
}

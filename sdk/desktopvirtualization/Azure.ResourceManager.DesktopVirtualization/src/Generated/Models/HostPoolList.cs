// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of HostPool definitions. </summary>
    internal partial class HostPoolList
    {
        /// <summary> Initializes a new instance of <see cref="HostPoolList"/>. </summary>
        internal HostPoolList()
        {
            Value = new ChangeTrackingList<HostPoolData>();
        }

        /// <summary> Initializes a new instance of <see cref="HostPoolList"/>. </summary>
        /// <param name="value"> List of HostPool definitions. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        internal HostPoolList(IReadOnlyList<HostPoolData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of HostPool definitions. </summary>
        public IReadOnlyList<HostPoolData> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}

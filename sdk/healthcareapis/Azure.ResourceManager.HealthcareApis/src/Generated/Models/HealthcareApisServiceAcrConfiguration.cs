// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Azure container registry configuration information. </summary>
    public partial class HealthcareApisServiceAcrConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAcrConfiguration"/>. </summary>
        public HealthcareApisServiceAcrConfiguration()
        {
            LoginServers = new ChangeTrackingList<string>();
            OciArtifacts = new ChangeTrackingList<HealthcareApisServiceOciArtifactEntry>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAcrConfiguration"/>. </summary>
        /// <param name="loginServers"> The list of the ACR login servers. </param>
        /// <param name="ociArtifacts"> The list of Open Container Initiative (OCI) artifacts. </param>
        internal HealthcareApisServiceAcrConfiguration(IList<string> loginServers, IList<HealthcareApisServiceOciArtifactEntry> ociArtifacts)
        {
            LoginServers = loginServers;
            OciArtifacts = ociArtifacts;
        }

        /// <summary> The list of the ACR login servers. </summary>
        public IList<string> LoginServers { get; }
        /// <summary> The list of Open Container Initiative (OCI) artifacts. </summary>
        public IList<HealthcareApisServiceOciArtifactEntry> OciArtifacts { get; }
    }
}

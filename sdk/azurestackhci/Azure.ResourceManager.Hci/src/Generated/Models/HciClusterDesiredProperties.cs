// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Desired properties of the cluster. </summary>
    public partial class HciClusterDesiredProperties
    {
        /// <summary> Initializes a new instance of <see cref="HciClusterDesiredProperties"/>. </summary>
        public HciClusterDesiredProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterDesiredProperties"/>. </summary>
        /// <param name="windowsServerSubscription"> Desired state of Windows Server Subscription. </param>
        /// <param name="diagnosticLevel"> Desired level of diagnostic data emitted by the cluster. </param>
        internal HciClusterDesiredProperties(WindowsServerSubscription? windowsServerSubscription, HciClusterDiagnosticLevel? diagnosticLevel)
        {
            WindowsServerSubscription = windowsServerSubscription;
            DiagnosticLevel = diagnosticLevel;
        }

        /// <summary> Desired state of Windows Server Subscription. </summary>
        public WindowsServerSubscription? WindowsServerSubscription { get; set; }
        /// <summary> Desired level of diagnostic data emitted by the cluster. </summary>
        public HciClusterDiagnosticLevel? DiagnosticLevel { get; set; }
    }
}

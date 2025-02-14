// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the MonitoringMetricConfiguration data model.
    /// The metric setting details for the role
    /// </summary>
    public partial class MonitoringMetricConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MonitoringMetricConfigurationData"/>. </summary>
        /// <param name="metricConfigurations"> The metrics configuration details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricConfigurations"/> is null. </exception>
        public MonitoringMetricConfigurationData(IEnumerable<DataBoxEdgeMetricConfiguration> metricConfigurations)
        {
            Argument.AssertNotNull(metricConfigurations, nameof(metricConfigurations));

            MetricConfigurations = metricConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringMetricConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="metricConfigurations"> The metrics configuration details. </param>
        internal MonitoringMetricConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<DataBoxEdgeMetricConfiguration> metricConfigurations) : base(id, name, resourceType, systemData)
        {
            MetricConfigurations = metricConfigurations;
        }

        /// <summary> The metrics configuration details. </summary>
        public IList<DataBoxEdgeMetricConfiguration> MetricConfigurations { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class Resources
    {
        internal static Resources DeserializeResources(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<Deployment>> deployments = default;
            Optional<IReadOnlyList<Pod>> pods = default;
            Optional<IReadOnlyList<ReplicaSet>> replicaSets = default;
            Optional<IReadOnlyList<StatefulSet>> statefulSets = default;
            Optional<IReadOnlyList<DaemonSet>> daemonSets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deployments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Deployment> array = new List<Deployment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Deployment.DeserializeDeployment(item));
                    }
                    deployments = array;
                    continue;
                }
                if (property.NameEquals("pods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Pod> array = new List<Pod>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Pod.DeserializePod(item));
                    }
                    pods = array;
                    continue;
                }
                if (property.NameEquals("replicaSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReplicaSet> array = new List<ReplicaSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicaSet.DeserializeReplicaSet(item));
                    }
                    replicaSets = array;
                    continue;
                }
                if (property.NameEquals("statefulSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StatefulSet> array = new List<StatefulSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StatefulSet.DeserializeStatefulSet(item));
                    }
                    statefulSets = array;
                    continue;
                }
                if (property.NameEquals("daemonSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DaemonSet> array = new List<DaemonSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DaemonSet.DeserializeDaemonSet(item));
                    }
                    daemonSets = array;
                    continue;
                }
            }
            return new Resources(Optional.ToList(deployments), Optional.ToList(pods), Optional.ToList(replicaSets), Optional.ToList(statefulSets), Optional.ToList(daemonSets));
        }
    }
}

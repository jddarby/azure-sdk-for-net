// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkServiceDesignVersionResource" /> and their operations.
    /// Each <see cref="NetworkServiceDesignVersionResource" /> in the collection will belong to the same instance of <see cref="NetworkServiceDesignGroupResource" />.
    /// To get a <see cref="NetworkServiceDesignVersionCollection" /> instance call the GetNetworkServiceDesignVersions method from an instance of <see cref="NetworkServiceDesignGroupResource" />.
    /// </summary>
    public partial class NetworkServiceDesignVersionCollection : ArmCollection, IEnumerable<NetworkServiceDesignVersionResource>, IAsyncEnumerable<NetworkServiceDesignVersionResource>
    {
        private readonly ClientDiagnostics _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics;
        private readonly NetworkServiceDesignVersionsRestOperations _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkServiceDesignVersionCollection"/> class for mocking. </summary>
        protected NetworkServiceDesignVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkServiceDesignVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkServiceDesignVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", NetworkServiceDesignVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkServiceDesignVersionResource.ResourceType, out string networkServiceDesignVersionnetworkServiceDesignVersionsApiVersion);
            _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient = new NetworkServiceDesignVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkServiceDesignVersionnetworkServiceDesignVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkServiceDesignGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkServiceDesignGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a network service design version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions/{networkServiceDesignVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkServiceDesignVersionName"> The name of the network service design version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="data"> Parameters supplied to the create or update network service design version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkServiceDesignVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkServiceDesignVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkServiceDesignVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkServiceDesignVersionName, NetworkServiceDesignVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkServiceDesignVersionName, nameof(networkServiceDesignVersionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics.CreateScope("NetworkServiceDesignVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridNetworkArmOperation<NetworkServiceDesignVersionResource>(new NetworkServiceDesignVersionOperationSource(Client), _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics, Pipeline, _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a network service design version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions/{networkServiceDesignVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkServiceDesignVersionName"> The name of the network service design version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="data"> Parameters supplied to the create or update network service design version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkServiceDesignVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkServiceDesignVersionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkServiceDesignVersionResource> CreateOrUpdate(WaitUntil waitUntil, string networkServiceDesignVersionName, NetworkServiceDesignVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkServiceDesignVersionName, nameof(networkServiceDesignVersionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics.CreateScope("NetworkServiceDesignVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, data, cancellationToken);
                var operation = new HybridNetworkArmOperation<NetworkServiceDesignVersionResource>(new NetworkServiceDesignVersionOperationSource(Client), _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics, Pipeline, _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a network service design version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions/{networkServiceDesignVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkServiceDesignVersionName"> The name of the network service design version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkServiceDesignVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkServiceDesignVersionName"/> is null. </exception>
        public virtual async Task<Response<NetworkServiceDesignVersionResource>> GetAsync(string networkServiceDesignVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkServiceDesignVersionName, nameof(networkServiceDesignVersionName));

            using var scope = _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics.CreateScope("NetworkServiceDesignVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkServiceDesignVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a network service design version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions/{networkServiceDesignVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkServiceDesignVersionName"> The name of the network service design version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkServiceDesignVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkServiceDesignVersionName"/> is null. </exception>
        public virtual Response<NetworkServiceDesignVersionResource> Get(string networkServiceDesignVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkServiceDesignVersionName, nameof(networkServiceDesignVersionName));

            using var scope = _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics.CreateScope("NetworkServiceDesignVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkServiceDesignVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a list of network service design versions under a network service design group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_ListByNetworkServiceDesignGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkServiceDesignVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkServiceDesignVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateListByNetworkServiceDesignGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateListByNetworkServiceDesignGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkServiceDesignVersionResource(Client, NetworkServiceDesignVersionData.DeserializeNetworkServiceDesignVersionData(e)), _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics, Pipeline, "NetworkServiceDesignVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about a list of network service design versions under a network service design group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_ListByNetworkServiceDesignGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkServiceDesignVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkServiceDesignVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateListByNetworkServiceDesignGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.CreateListByNetworkServiceDesignGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkServiceDesignVersionResource(Client, NetworkServiceDesignVersionData.DeserializeNetworkServiceDesignVersionData(e)), _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics, Pipeline, "NetworkServiceDesignVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions/{networkServiceDesignVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkServiceDesignVersionName"> The name of the network service design version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkServiceDesignVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkServiceDesignVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkServiceDesignVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkServiceDesignVersionName, nameof(networkServiceDesignVersionName));

            using var scope = _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics.CreateScope("NetworkServiceDesignVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/networkServiceDesignGroups/{networkServiceDesignGroupName}/networkServiceDesignVersions/{networkServiceDesignVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>networkServiceDesignVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkServiceDesignVersionName"> The name of the network service design version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkServiceDesignVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkServiceDesignVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkServiceDesignVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkServiceDesignVersionName, nameof(networkServiceDesignVersionName));

            using var scope = _networkServiceDesignVersionnetworkServiceDesignVersionsClientDiagnostics.CreateScope("NetworkServiceDesignVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkServiceDesignVersionnetworkServiceDesignVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, networkServiceDesignVersionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkServiceDesignVersionResource> IEnumerable<NetworkServiceDesignVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkServiceDesignVersionResource> IAsyncEnumerable<NetworkServiceDesignVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

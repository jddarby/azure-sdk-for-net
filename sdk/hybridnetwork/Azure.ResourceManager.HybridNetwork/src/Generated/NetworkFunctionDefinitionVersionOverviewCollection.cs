// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkFunctionDefinitionVersionOverviewResource" /> and their operations.
    /// Each <see cref="NetworkFunctionDefinitionVersionOverviewResource" /> in the collection will belong to the same instance of <see cref="NetworkFunctionDefinitionGroupOverviewResource" />.
    /// To get a <see cref="NetworkFunctionDefinitionVersionOverviewCollection" /> instance call the GetNetworkFunctionDefinitionVersionOverviews method from an instance of <see cref="NetworkFunctionDefinitionGroupOverviewResource" />.
    /// </summary>
    public partial class NetworkFunctionDefinitionVersionOverviewCollection : ArmCollection
    {
        private readonly ClientDiagnostics _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics;
        private readonly ProxyNetworkFunctionDefinitionVersionsRestOperations _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionDefinitionVersionOverviewCollection"/> class for mocking. </summary>
        protected NetworkFunctionDefinitionVersionOverviewCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFunctionDefinitionVersionOverviewCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkFunctionDefinitionVersionOverviewCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", NetworkFunctionDefinitionVersionOverviewResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkFunctionDefinitionVersionOverviewResource.ResourceType, out string networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsApiVersion);
            _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient = new ProxyNetworkFunctionDefinitionVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkFunctionDefinitionGroupOverviewResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkFunctionDefinitionGroupOverviewResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information about network function definition version overview.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyNetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual async Task<Response<NetworkFunctionDefinitionVersionOverviewResource>> GetAsync(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionOverviewCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, publisherScopeName, publisherLocationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionVersionOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about network function definition version overview.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyNetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual Response<NetworkFunctionDefinitionVersionOverviewResource> Get(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionOverviewCollection.Get");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, publisherScopeName, publisherLocationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFunctionDefinitionVersionOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists available network function versions under a network function definition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyNetworkFunctionDefinitionVersions_ListByNetworkFunctionDefinitionGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="NetworkFunctionDefinitionVersionOverviewResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkFunctionDefinitionVersionOverviewResource> GetAllAsync(string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.CreateListByNetworkFunctionDefinitionGroupRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, publisherScopeName, publisherLocationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.CreateListByNetworkFunctionDefinitionGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, publisherScopeName, publisherLocationName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionDefinitionVersionOverviewResource(Client, NetworkFunctionDefinitionVersionOverviewData.DeserializeNetworkFunctionDefinitionVersionOverviewData(e)), _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics, Pipeline, "NetworkFunctionDefinitionVersionOverviewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists available network function versions under a network function definition group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyNetworkFunctionDefinitionVersions_ListByNetworkFunctionDefinitionGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <returns> A collection of <see cref="NetworkFunctionDefinitionVersionOverviewResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkFunctionDefinitionVersionOverviewResource> GetAll(string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.CreateListByNetworkFunctionDefinitionGroupRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, publisherScopeName, publisherLocationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.CreateListByNetworkFunctionDefinitionGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, publisherScopeName, publisherLocationName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkFunctionDefinitionVersionOverviewResource(Client, NetworkFunctionDefinitionVersionOverviewData.DeserializeNetworkFunctionDefinitionVersionOverviewData(e)), _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics, Pipeline, "NetworkFunctionDefinitionVersionOverviewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyNetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionOverviewCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, publisherScopeName, publisherLocationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}/networkFunctionDefinitionGroups/{networkFunctionDefinitionGroupName}/networkFunctionDefinitionVersions/{networkFunctionDefinitionVersionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyNetworkFunctionDefinitionVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFunctionDefinitionVersionName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsClientDiagnostics.CreateScope("NetworkFunctionDefinitionVersionOverviewCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkFunctionDefinitionVersionOverviewProxyNetworkFunctionDefinitionVersionsRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, networkFunctionDefinitionVersionName, publisherScopeName, publisherLocationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}

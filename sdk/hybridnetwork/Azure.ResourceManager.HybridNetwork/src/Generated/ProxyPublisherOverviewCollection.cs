// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="ProxyPublisherOverviewResource" /> and their operations.
    /// Each <see cref="ProxyPublisherOverviewResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="ProxyPublisherOverviewCollection" /> instance call the GetProxyPublisherOverviews method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class ProxyPublisherOverviewCollection : ArmCollection
    {
        private readonly ClientDiagnostics _proxyPublisherOverviewProxyPublisherClientDiagnostics;
        private readonly ProxyPublisherRestOperations _proxyPublisherOverviewProxyPublisherRestClient;

        /// <summary> Initializes a new instance of the <see cref="ProxyPublisherOverviewCollection"/> class for mocking. </summary>
        protected ProxyPublisherOverviewCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ProxyPublisherOverviewCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ProxyPublisherOverviewCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _proxyPublisherOverviewProxyPublisherClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", ProxyPublisherOverviewResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ProxyPublisherOverviewResource.ResourceType, out string proxyPublisherOverviewProxyPublisherApiVersion);
            _proxyPublisherOverviewProxyPublisherRestClient = new ProxyPublisherRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, proxyPublisherOverviewProxyPublisherApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a publisher overview information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyPublisher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual async Task<Response<ProxyPublisherOverviewResource>> GetAsync(string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _proxyPublisherOverviewProxyPublisherClientDiagnostics.CreateScope("ProxyPublisherOverviewCollection.Get");
            scope.Start();
            try
            {
                var response = await _proxyPublisherOverviewProxyPublisherRestClient.GetAsync(Id.SubscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProxyPublisherOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a publisher overview information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyPublisher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual Response<ProxyPublisherOverviewResource> Get(string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _proxyPublisherOverviewProxyPublisherClientDiagnostics.CreateScope("ProxyPublisherOverviewCollection.Get");
            scope.Start();
            try
            {
                var response = _proxyPublisherOverviewProxyPublisherRestClient.Get(Id.SubscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ProxyPublisherOverviewResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the available network function definition and network service design publishers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyPublisher_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="ProxyPublisherOverviewResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProxyPublisherOverviewResource> GetAllAsync(string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _proxyPublisherOverviewProxyPublisherRestClient.CreateListByLocationRequest(Id.SubscriptionId, publisherScopeName, publisherLocationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _proxyPublisherOverviewProxyPublisherRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, publisherScopeName, publisherLocationName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ProxyPublisherOverviewResource(Client, ProxyPublisherOverviewData.DeserializeProxyPublisherOverviewData(e)), _proxyPublisherOverviewProxyPublisherClientDiagnostics, Pipeline, "ProxyPublisherOverviewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available network function definition and network service design publishers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyPublisher_ListByLocation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <returns> A collection of <see cref="ProxyPublisherOverviewResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProxyPublisherOverviewResource> GetAll(string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _proxyPublisherOverviewProxyPublisherRestClient.CreateListByLocationRequest(Id.SubscriptionId, publisherScopeName, publisherLocationName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _proxyPublisherOverviewProxyPublisherRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, publisherScopeName, publisherLocationName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ProxyPublisherOverviewResource(Client, ProxyPublisherOverviewData.DeserializeProxyPublisherOverviewData(e)), _proxyPublisherOverviewProxyPublisherClientDiagnostics, Pipeline, "ProxyPublisherOverviewCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyPublisher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _proxyPublisherOverviewProxyPublisherClientDiagnostics.CreateScope("ProxyPublisherOverviewCollection.Exists");
            scope.Start();
            try
            {
                var response = await _proxyPublisherOverviewProxyPublisherRestClient.GetAsync(Id.SubscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/proxyPublishers/{proxyPublisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProxyPublisher_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        public virtual Response<bool> Exists(string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var scope = _proxyPublisherOverviewProxyPublisherClientDiagnostics.CreateScope("ProxyPublisherOverviewCollection.Exists");
            scope.Start();
            try
            {
                var response = _proxyPublisherOverviewProxyPublisherRestClient.Get(Id.SubscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName, cancellationToken: cancellationToken);
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

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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="ArtifactManifestResource" /> and their operations.
    /// Each <see cref="ArtifactManifestResource" /> in the collection will belong to the same instance of <see cref="ArtifactStoreResource" />.
    /// To get an <see cref="ArtifactManifestCollection" /> instance call the GetArtifactManifests method from an instance of <see cref="ArtifactStoreResource" />.
    /// </summary>
    public partial class ArtifactManifestCollection : ArmCollection, IEnumerable<ArtifactManifestResource>, IAsyncEnumerable<ArtifactManifestResource>
    {
        private readonly ClientDiagnostics _artifactManifestClientDiagnostics;
        private readonly ArtifactManifestsRestOperations _artifactManifestRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArtifactManifestCollection"/> class for mocking. </summary>
        protected ArtifactManifestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArtifactManifestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ArtifactManifestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _artifactManifestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", ArtifactManifestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ArtifactManifestResource.ResourceType, out string artifactManifestApiVersion);
            _artifactManifestRestClient = new ArtifactManifestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, artifactManifestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ArtifactStoreResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ArtifactStoreResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a artifact manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests/{artifactManifestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="artifactManifestName"> The name of the artifact manifest. </param>
        /// <param name="data"> Parameters supplied to the create or update artifact manifest operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactManifestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactManifestName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ArtifactManifestResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string artifactManifestName, ArtifactManifestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactManifestName, nameof(artifactManifestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _artifactManifestClientDiagnostics.CreateScope("ArtifactManifestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _artifactManifestRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridNetworkArmOperation<ArtifactManifestResource>(new ArtifactManifestOperationSource(Client), _artifactManifestClientDiagnostics, Pipeline, _artifactManifestRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a artifact manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests/{artifactManifestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="artifactManifestName"> The name of the artifact manifest. </param>
        /// <param name="data"> Parameters supplied to the create or update artifact manifest operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactManifestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactManifestName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ArtifactManifestResource> CreateOrUpdate(WaitUntil waitUntil, string artifactManifestName, ArtifactManifestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactManifestName, nameof(artifactManifestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _artifactManifestClientDiagnostics.CreateScope("ArtifactManifestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _artifactManifestRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, data, cancellationToken);
                var operation = new HybridNetworkArmOperation<ArtifactManifestResource>(new ArtifactManifestOperationSource(Client), _artifactManifestClientDiagnostics, Pipeline, _artifactManifestRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about a artifact manifest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests/{artifactManifestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactManifestName"> The name of the artifact manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactManifestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactManifestName"/> is null. </exception>
        public virtual async Task<Response<ArtifactManifestResource>> GetAsync(string artifactManifestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactManifestName, nameof(artifactManifestName));

            using var scope = _artifactManifestClientDiagnostics.CreateScope("ArtifactManifestCollection.Get");
            scope.Start();
            try
            {
                var response = await _artifactManifestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArtifactManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a artifact manifest resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests/{artifactManifestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactManifestName"> The name of the artifact manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactManifestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactManifestName"/> is null. </exception>
        public virtual Response<ArtifactManifestResource> Get(string artifactManifestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactManifestName, nameof(artifactManifestName));

            using var scope = _artifactManifestClientDiagnostics.CreateScope("ArtifactManifestCollection.Get");
            scope.Start();
            try
            {
                var response = _artifactManifestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArtifactManifestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the artifact manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_ListByArtifactStore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArtifactManifestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArtifactManifestResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _artifactManifestRestClient.CreateListByArtifactStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _artifactManifestRestClient.CreateListByArtifactStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ArtifactManifestResource(Client, ArtifactManifestData.DeserializeArtifactManifestData(e)), _artifactManifestClientDiagnostics, Pipeline, "ArtifactManifestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about the artifact manifest.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_ListByArtifactStore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArtifactManifestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArtifactManifestResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _artifactManifestRestClient.CreateListByArtifactStoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _artifactManifestRestClient.CreateListByArtifactStoreNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ArtifactManifestResource(Client, ArtifactManifestData.DeserializeArtifactManifestData(e)), _artifactManifestClientDiagnostics, Pipeline, "ArtifactManifestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests/{artifactManifestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactManifestName"> The name of the artifact manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactManifestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactManifestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string artifactManifestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactManifestName, nameof(artifactManifestName));

            using var scope = _artifactManifestClientDiagnostics.CreateScope("ArtifactManifestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _artifactManifestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}/artifactStores/{artifactStoreName}/artifactManifests/{artifactManifestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ArtifactManifests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="artifactManifestName"> The name of the artifact manifest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="artifactManifestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="artifactManifestName"/> is null. </exception>
        public virtual Response<bool> Exists(string artifactManifestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(artifactManifestName, nameof(artifactManifestName));

            using var scope = _artifactManifestClientDiagnostics.CreateScope("ArtifactManifestCollection.Exists");
            scope.Start();
            try
            {
                var response = _artifactManifestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, artifactManifestName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ArtifactManifestResource> IEnumerable<ArtifactManifestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ArtifactManifestResource> IAsyncEnumerable<ArtifactManifestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

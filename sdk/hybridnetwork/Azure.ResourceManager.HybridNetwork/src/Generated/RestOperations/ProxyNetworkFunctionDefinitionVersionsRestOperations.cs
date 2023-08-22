// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridNetwork.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    internal partial class ProxyNetworkFunctionDefinitionVersionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ProxyNetworkFunctionDefinitionVersionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ProxyNetworkFunctionDefinitionVersionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByNetworkFunctionDefinitionGroupRequest(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.HybridNetwork/proxyPublishers/", false);
            uri.AppendPath(proxyPublisherName, true);
            uri.AppendPath("/networkFunctionDefinitionGroups/", false);
            uri.AppendPath(networkFunctionDefinitionGroupName, true);
            uri.AppendPath("/networkFunctionDefinitionVersions", false);
            uri.AppendQuery("publisherScopeName", publisherScopeName, true);
            uri.AppendQuery("publisherLocationName", publisherLocationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists available network function versions under a network function definition group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/> or <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkFunctionDefinitionVersionOverviewListResult>> ListByNetworkFunctionDefinitionGroupAsync(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByNetworkFunctionDefinitionGroupRequest(subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, publisherScopeName, publisherLocationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionVersionOverviewListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NetworkFunctionDefinitionVersionOverviewListResult.DeserializeNetworkFunctionDefinitionVersionOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists available network function versions under a network function definition group. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/> or <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkFunctionDefinitionVersionOverviewListResult> ListByNetworkFunctionDefinitionGroup(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByNetworkFunctionDefinitionGroupRequest(subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, publisherScopeName, publisherLocationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionVersionOverviewListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NetworkFunctionDefinitionVersionOverviewListResult.DeserializeNetworkFunctionDefinitionVersionOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.HybridNetwork/proxyPublishers/", false);
            uri.AppendPath(proxyPublisherName, true);
            uri.AppendPath("/networkFunctionDefinitionGroups/", false);
            uri.AppendPath(networkFunctionDefinitionGroupName, true);
            uri.AppendPath("/networkFunctionDefinitionVersions/", false);
            uri.AppendPath(networkFunctionDefinitionVersionName, true);
            uri.AppendQuery("publisherScopeName", publisherScopeName, true);
            uri.AppendQuery("publisherLocationName", publisherLocationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get information about network function definition version overview. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="networkFunctionDefinitionVersionName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/> or <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkFunctionDefinitionVersionOverviewData>> GetAsync(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateGetRequest(subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName, publisherScopeName, publisherLocationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionVersionOverviewData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NetworkFunctionDefinitionVersionOverviewData.DeserializeNetworkFunctionDefinitionVersionOverviewData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkFunctionDefinitionVersionOverviewData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get information about network function definition version overview. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="networkFunctionDefinitionVersionName"> The name of the network function definition version. The name should conform to the SemVer 2.0.0 specification: https://semver.org/spec/v2.0.0.html. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="networkFunctionDefinitionVersionName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/> or <paramref name="networkFunctionDefinitionVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkFunctionDefinitionVersionOverviewData> Get(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionVersionName, nameof(networkFunctionDefinitionVersionName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateGetRequest(subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName, publisherScopeName, publisherLocationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionVersionOverviewData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NetworkFunctionDefinitionVersionOverviewData.DeserializeNetworkFunctionDefinitionVersionOverviewData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkFunctionDefinitionVersionOverviewData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByNetworkFunctionDefinitionGroupNextPageRequest(string nextLink, string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists available network function versions under a network function definition group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/> or <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkFunctionDefinitionVersionOverviewListResult>> ListByNetworkFunctionDefinitionGroupNextPageAsync(string nextLink, string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByNetworkFunctionDefinitionGroupNextPageRequest(nextLink, subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, publisherScopeName, publisherLocationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionVersionOverviewListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NetworkFunctionDefinitionVersionOverviewListResult.DeserializeNetworkFunctionDefinitionVersionOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists available network function versions under a network function definition group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/> or <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkFunctionDefinitionVersionOverviewListResult> ListByNetworkFunctionDefinitionGroupNextPage(string nextLink, string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByNetworkFunctionDefinitionGroupNextPageRequest(nextLink, subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, publisherScopeName, publisherLocationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionVersionOverviewListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NetworkFunctionDefinitionVersionOverviewListResult.DeserializeNetworkFunctionDefinitionVersionOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

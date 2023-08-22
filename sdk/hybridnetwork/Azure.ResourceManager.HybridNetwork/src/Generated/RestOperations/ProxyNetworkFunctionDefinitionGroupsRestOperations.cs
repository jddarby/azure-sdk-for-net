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
    internal partial class ProxyNetworkFunctionDefinitionGroupsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ProxyNetworkFunctionDefinitionGroupsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ProxyNetworkFunctionDefinitionGroupsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByPublisherRequest(string subscriptionId, string proxyPublisherName, string publisherScopeName, string publisherLocationName)
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
            uri.AppendPath("/networkFunctionDefinitionGroups", false);
            uri.AppendQuery("publisherScopeName", publisherScopeName, true);
            uri.AppendQuery("publisherLocationName", publisherLocationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all available network function definition group under a publisher. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkFunctionDefinitionGroupOverviewListResult>> ListByPublisherAsync(string subscriptionId, string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByPublisherRequest(subscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionGroupOverviewListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NetworkFunctionDefinitionGroupOverviewListResult.DeserializeNetworkFunctionDefinitionGroupOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all available network function definition group under a publisher. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkFunctionDefinitionGroupOverviewListResult> ListByPublisher(string subscriptionId, string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByPublisherRequest(subscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionGroupOverviewListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NetworkFunctionDefinitionGroupOverviewListResult.DeserializeNetworkFunctionDefinitionGroupOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName)
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
            uri.AppendQuery("publisherScopeName", publisherScopeName, true);
            uri.AppendQuery("publisherLocationName", publisherLocationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get information about network function definition overview. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/> or <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkFunctionDefinitionGroupOverviewData>> GetAsync(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateGetRequest(subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, publisherScopeName, publisherLocationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionGroupOverviewData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NetworkFunctionDefinitionGroupOverviewData.DeserializeNetworkFunctionDefinitionGroupOverviewData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkFunctionDefinitionGroupOverviewData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get information about network function definition overview. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="networkFunctionDefinitionGroupName"> The name of the network function definition group. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="networkFunctionDefinitionGroupName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/> or <paramref name="networkFunctionDefinitionGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkFunctionDefinitionGroupOverviewData> Get(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNullOrEmpty(networkFunctionDefinitionGroupName, nameof(networkFunctionDefinitionGroupName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateGetRequest(subscriptionId, proxyPublisherName, networkFunctionDefinitionGroupName, publisherScopeName, publisherLocationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionGroupOverviewData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NetworkFunctionDefinitionGroupOverviewData.DeserializeNetworkFunctionDefinitionGroupOverviewData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((NetworkFunctionDefinitionGroupOverviewData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPublisherNextPageRequest(string nextLink, string subscriptionId, string proxyPublisherName, string publisherScopeName, string publisherLocationName)
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

        /// <summary> Lists all available network function definition group under a publisher. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<NetworkFunctionDefinitionGroupOverviewListResult>> ListByPublisherNextPageAsync(string nextLink, string subscriptionId, string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByPublisherNextPageRequest(nextLink, subscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionGroupOverviewListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NetworkFunctionDefinitionGroupOverviewListResult.DeserializeNetworkFunctionDefinitionGroupOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all available network function definition group under a publisher. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="proxyPublisherName"> The name of the proxy publisher. </param>
        /// <param name="publisherScopeName"> The name of the publisher scope. </param>
        /// <param name="publisherLocationName"> The name of the publisher location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="proxyPublisherName"/>, <paramref name="publisherScopeName"/> or <paramref name="publisherLocationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="proxyPublisherName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<NetworkFunctionDefinitionGroupOverviewListResult> ListByPublisherNextPage(string nextLink, string subscriptionId, string proxyPublisherName, string publisherScopeName, string publisherLocationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(proxyPublisherName, nameof(proxyPublisherName));
            Argument.AssertNotNull(publisherScopeName, nameof(publisherScopeName));
            Argument.AssertNotNull(publisherLocationName, nameof(publisherLocationName));

            using var message = CreateListByPublisherNextPageRequest(nextLink, subscriptionId, proxyPublisherName, publisherScopeName, publisherLocationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NetworkFunctionDefinitionGroupOverviewListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NetworkFunctionDefinitionGroupOverviewListResult.DeserializeNetworkFunctionDefinitionGroupOverviewListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

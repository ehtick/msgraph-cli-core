using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.Cli.Core.IO;

public class GraphCliClientFactory
{
    public IEnumerable<DelegatingHandler> GetDefaultMiddlewaresWithOptions(GraphClientOptions options, IAuthenticationProvider authenticationProvider)
    {
        var result = new List<DelegatingHandler>();
        var graphMiddlewares = GraphClientFactory.CreateDefaultHandlers(options);
        result.AddRange(kiotaMiddlewares);
        result.AddRange(graphMiddlewares);

        return result;
    }

    public HttpClient GetDefaultClient(GraphClientOptions options, IAuthenticationProvider authenticationProvider, string nationalCloud = GraphClientFactory.Global_Cloud, params DelegatingHandler[] middlewares)
    {
        IEnumerable<DelegatingHandler> m = middlewares;
        if (middlewares.Length == 0)
        {
            m = GetDefaultMiddlewaresWithOptions(options, authenticationProvider);
        }
        var finalHandler = KiotaClientFactory.ChainHandlersCollectionAndGetFirstLink(KiotaClientFactory.GetDefaultHttpMessageHandler(), middlewares);
        return GraphClientFactory.Create(graphClientOptions: options, nationalCloud: nationalCloud, finalHandler: finalHandler);
    }
}
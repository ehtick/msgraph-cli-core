using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.Cli.Core.IO;
using Microsoft.Graph.Cli.Core.Utils;

namespace Microsoft.Graph.Cli.Core.Authentication;

public class AuthenticationServiceFactory {
    private readonly IPathUtility pathUtility;

    public AuthenticationServiceFactory(IPathUtility pathUtility)
    {
        this.pathUtility = pathUtility;
    }

    public async Task<ILoginService> GetAuthenticationServiceAsync(AuthenticationStrategy strategy, string? tenantId, string? clientId, CancellationToken cancellationToken = default(CancellationToken)) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeLoginServiceAsync(tenantId, clientId, cancellationToken);
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }

    }

    public async Task<TokenCredential> GetTokenCredentialAsync(AuthenticationStrategy strategy, string? tenantId, string? clientId, CancellationToken cancellationToken = default(CancellationToken)) {
        switch (strategy) {
            case AuthenticationStrategy.DeviceCode:
                return await GetDeviceCodeCredentialAsync(tenantId, clientId, cancellationToken);
            default:
                throw new InvalidOperationException($"The authentication strategy {strategy} is not supported");
        }
    }

    private async Task<DeviceCodeLoginService> GetDeviceCodeLoginServiceAsync(string? tenantId, string? clientId, CancellationToken cancellationToken = default(CancellationToken)) {
        var credential = await GetDeviceCodeCredentialAsync(tenantId, clientId, cancellationToken);
        return new(credential, pathUtility);
    }

    private async Task<DeviceCodeCredential> GetDeviceCodeCredentialAsync(string? tenantId, string? clientId, CancellationToken cancellationToken = default(CancellationToken)) {
        DeviceCodeCredentialOptions credOptions = new()
        {
            ClientId = clientId,
            TenantId = tenantId,
        };

        TokenCachePersistenceOptions tokenCacheOptions = new() { Name = Constants.TokenCacheName };
        credOptions.TokenCachePersistenceOptions = tokenCacheOptions;
        var recordPath = Path.Combine(pathUtility.GetApplicationDataDirectory(), Constants.AuthRecordPath);

        if (File.Exists(recordPath))
        {
            using var authRecordStream = new FileStream(recordPath, FileMode.Open, FileAccess.Read);
            var authRecord = await AuthenticationRecord.DeserializeAsync(authRecordStream, cancellationToken);
            credOptions.AuthenticationRecord = authRecord;
        }

        return new DeviceCodeCredential(credOptions);
    }
}

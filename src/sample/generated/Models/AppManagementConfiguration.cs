// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AppManagementConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Collection of keyCredential restrictions settings to be applied to an application or service principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.KeyCredentialConfiguration>? KeyCredentials { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.KeyCredentialConfiguration> KeyCredentials { get; set; }
#endif
        /// <summary>Collection of password restrictions settings to be applied to an application or service principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PasswordCredentialConfiguration>? PasswordCredentials { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PasswordCredentialConfiguration> PasswordCredentials { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AppManagementConfiguration"/> and sets the default values.
        /// </summary>
        public AppManagementConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AppManagementConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.AppManagementConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AppManagementConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "keyCredentials", n => { KeyCredentials = n.GetCollectionOfObjectValues<global::ApiSdk.Models.KeyCredentialConfiguration>(global::ApiSdk.Models.KeyCredentialConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "passwordCredentials", n => { PasswordCredentials = n.GetCollectionOfObjectValues<global::ApiSdk.Models.PasswordCredentialConfiguration>(global::ApiSdk.Models.PasswordCredentialConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.KeyCredentialConfiguration>("keyCredentials", KeyCredentials);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.PasswordCredentialConfiguration>("passwordCredentials", PasswordCredentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

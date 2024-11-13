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
    public partial class PermissionScope : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdminConsentDescription { get; set; }
#nullable restore
#else
        public string AdminConsentDescription { get; set; }
#endif
        /// <summary>The permission&apos;s title, intended to be read by an administrator granting the permission on behalf of all users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdminConsentDisplayName { get; set; }
#nullable restore
#else
        public string AdminConsentDisplayName { get; set; }
#endif
        /// <summary>Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.</summary>
        public Guid? Id { get; set; }
        /// <summary>When you create or update a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The origin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Origin { get; set; }
#nullable restore
#else
        public string Origin { get; set; }
#endif
        /// <summary>The possible values are: User and Admin. Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator consent should always be required. While Microsoft Graph defines the default consent requirement for each permission, the tenant administrator may override the behavior in their organization (by allowing, restricting, or limiting user consent to this delegated permission). For more information, see Configure how users consent to applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserConsentDescription { get; set; }
#nullable restore
#else
        public string UserConsentDescription { get; set; }
#endif
        /// <summary>A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserConsentDisplayName { get; set; }
#nullable restore
#else
        public string UserConsentDisplayName { get; set; }
#endif
        /// <summary>Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % &amp; &apos; ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, and characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, aren&apos;t allowed. May not begin with ..</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PermissionScope"/> and sets the default values.
        /// </summary>
        public PermissionScope()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PermissionScope"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PermissionScope CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PermissionScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "adminConsentDescription", n => { AdminConsentDescription = n.GetStringValue(); } },
                { "adminConsentDisplayName", n => { AdminConsentDisplayName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "origin", n => { Origin = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "userConsentDescription", n => { UserConsentDescription = n.GetStringValue(); } },
                { "userConsentDisplayName", n => { UserConsentDisplayName = n.GetStringValue(); } },
                { "value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("adminConsentDescription", AdminConsentDescription);
            writer.WriteStringValue("adminConsentDisplayName", AdminConsentDisplayName);
            writer.WriteGuidValue("id", Id);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("origin", Origin);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userConsentDescription", UserConsentDescription);
            writer.WriteStringValue("userConsentDisplayName", UserConsentDisplayName);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

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
    public partial class Drive : global::ApiSdk.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of bundles (albums and multi-select-shared sets of items). Only in personal OneDrive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DriveItem>? Bundles { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DriveItem> Bundles { get; set; }
#endif
        /// <summary>Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriveType { get; set; }
#nullable restore
#else
        public string DriveType { get; set; }
#endif
        /// <summary>The list of items the user is following. Only in OneDrive for Business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DriveItem>? Following { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DriveItem> Following { get; set; }
#endif
        /// <summary>All items contained in the drive. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DriveItem>? Items { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DriveItem> Items { get; set; }
#endif
        /// <summary>The list property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.List? List { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.List List { get; set; }
#endif
        /// <summary>The owner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IdentitySet? Owner { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IdentitySet Owner { get; set; }
#endif
        /// <summary>The quota property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Quota? Quota { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Quota Quota { get; set; }
#endif
        /// <summary>The root property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DriveItem? Root { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DriveItem Root { get; set; }
#endif
        /// <summary>The sharePointIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SharepointIds? SharePointIds { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SharepointIds SharePointIds { get; set; }
#endif
        /// <summary>Collection of common folders available in OneDrive. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DriveItem>? Special { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DriveItem> Special { get; set; }
#endif
        /// <summary>The system property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SystemFacet? System { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SystemFacet System { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Drive"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Drive CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Drive();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bundles", n => { Bundles = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "driveType", n => { DriveType = n.GetStringValue(); } },
                { "following", n => { Following = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "list", n => { List = n.GetObjectValue<global::ApiSdk.Models.List>(global::ApiSdk.Models.List.CreateFromDiscriminatorValue); } },
                { "owner", n => { Owner = n.GetObjectValue<global::ApiSdk.Models.IdentitySet>(global::ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "quota", n => { Quota = n.GetObjectValue<global::ApiSdk.Models.Quota>(global::ApiSdk.Models.Quota.CreateFromDiscriminatorValue); } },
                { "root", n => { Root = n.GetObjectValue<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "sharePointIds", n => { SharePointIds = n.GetObjectValue<global::ApiSdk.Models.SharepointIds>(global::ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "special", n => { Special = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "system", n => { System = n.GetObjectValue<global::ApiSdk.Models.SystemFacet>(global::ApiSdk.Models.SystemFacet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>("bundles", Bundles);
            writer.WriteStringValue("driveType", DriveType);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>("following", Following);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<global::ApiSdk.Models.List>("list", List);
            writer.WriteObjectValue<global::ApiSdk.Models.IdentitySet>("owner", Owner);
            writer.WriteObjectValue<global::ApiSdk.Models.Quota>("quota", Quota);
            writer.WriteObjectValue<global::ApiSdk.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<global::ApiSdk.Models.SharepointIds>("sharePointIds", SharePointIds);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DriveItem>("special", Special);
            writer.WriteObjectValue<global::ApiSdk.Models.SystemFacet>("system", System);
        }
    }
}
#pragma warning restore CS0618

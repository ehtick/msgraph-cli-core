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
    public partial class ListItem : global::ApiSdk.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The analytics property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemAnalytics? Analytics { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemAnalytics Analytics { get; set; }
#endif
        /// <summary>The contentType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ContentTypeInfo? ContentType { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ContentTypeInfo ContentType { get; set; }
#endif
        /// <summary>Version information for a document set version created by a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DocumentSetVersion>? DocumentSetVersions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DocumentSetVersion> DocumentSetVersions { get; set; }
#endif
        /// <summary>The driveItem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DriveItem? DriveItem { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DriveItem DriveItem { get; set; }
#endif
        /// <summary>The fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.FieldValueSet? Fields { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.FieldValueSet Fields { get; set; }
#endif
        /// <summary>The sharepointIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>The list of previous versions of the list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ListItemVersion>? Versions { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ListItemVersion> Versions { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ListItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ListItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "analytics", n => { Analytics = n.GetObjectValue<global::ApiSdk.Models.ItemAnalytics>(global::ApiSdk.Models.ItemAnalytics.CreateFromDiscriminatorValue); } },
                { "contentType", n => { ContentType = n.GetObjectValue<global::ApiSdk.Models.ContentTypeInfo>(global::ApiSdk.Models.ContentTypeInfo.CreateFromDiscriminatorValue); } },
                { "documentSetVersions", n => { DocumentSetVersions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.DocumentSetVersion>(global::ApiSdk.Models.DocumentSetVersion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "driveItem", n => { DriveItem = n.GetObjectValue<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "fields", n => { Fields = n.GetObjectValue<global::ApiSdk.Models.FieldValueSet>(global::ApiSdk.Models.FieldValueSet.CreateFromDiscriminatorValue); } },
                { "sharepointIds", n => { SharepointIds = n.GetObjectValue<global::ApiSdk.Models.SharepointIds>(global::ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "versions", n => { Versions = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ListItemVersion>(global::ApiSdk.Models.ListItemVersion.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<global::ApiSdk.Models.ContentTypeInfo>("contentType", ContentType);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.DocumentSetVersion>("documentSetVersions", DocumentSetVersions);
            writer.WriteObjectValue<global::ApiSdk.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<global::ApiSdk.Models.FieldValueSet>("fields", Fields);
            writer.WriteObjectValue<global::ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ListItemVersion>("versions", Versions);
        }
    }
}
#pragma warning restore CS0618

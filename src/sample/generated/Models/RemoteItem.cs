using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class RemoteItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The file property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.FileObject? FileObject { get; set; }
#nullable restore
#else
        public ApiSdk.Models.FileObject FileObject { get; set; }
#endif
        /// <summary>The fileSystemInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.FileSystemInfo? FileSystemInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.FileSystemInfo FileSystemInfo { get; set; }
#endif
        /// <summary>The folder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Folder? Folder { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Folder Folder { get; set; }
#endif
        /// <summary>Unique identifier for the remote item in its drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The image property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Image? Image { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Image Image { get; set; }
#endif
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>Date and time the item was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Optional. Filename of the remote item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The package property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Package? Package { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Package Package { get; set; }
#endif
        /// <summary>The parentReference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemReference? ParentReference { get; set; }
#nullable restore
#else
        public ItemReference ParentReference { get; set; }
#endif
        /// <summary>The shared property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Shared? Shared { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Shared Shared { get; set; }
#endif
        /// <summary>The sharepointIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>Size of the remote item. Read-only.</summary>
        public long? Size { get; set; }
        /// <summary>The specialFolder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SpecialFolder? SpecialFolder { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SpecialFolder SpecialFolder { get; set; }
#endif
        /// <summary>The video property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Video? Video { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Video Video { get; set; }
#endif
        /// <summary>DAV compatible URL for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebDavUrl { get; set; }
#nullable restore
#else
        public string WebDavUrl { get; set; }
#endif
        /// <summary>URL that displays the resource in the browser. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new remoteItem and sets the default values.
        /// </summary>
        public RemoteItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RemoteItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"file", n => { FileObject = n.GetObjectValue<ApiSdk.Models.FileObject>(ApiSdk.Models.FileObject.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<ApiSdk.Models.FileSystemInfo>(ApiSdk.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", n => { Folder = n.GetObjectValue<ApiSdk.Models.Folder>(ApiSdk.Models.Folder.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"image", n => { Image = n.GetObjectValue<ApiSdk.Models.Image>(ApiSdk.Models.Image.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"package", n => { Package = n.GetObjectValue<ApiSdk.Models.Package>(ApiSdk.Models.Package.CreateFromDiscriminatorValue); } },
                {"parentReference", n => { ParentReference = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"shared", n => { Shared = n.GetObjectValue<ApiSdk.Models.Shared>(ApiSdk.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<ApiSdk.Models.SharepointIds>(ApiSdk.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"specialFolder", n => { SpecialFolder = n.GetObjectValue<ApiSdk.Models.SpecialFolder>(ApiSdk.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"video", n => { Video = n.GetObjectValue<ApiSdk.Models.Video>(ApiSdk.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", n => { WebDavUrl = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.FileObject>("file", FileObject);
            writer.WriteObjectValue<ApiSdk.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<ApiSdk.Models.Folder>("folder", Folder);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<ApiSdk.Models.Image>("image", Image);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ApiSdk.Models.Package>("package", Package);
            writer.WriteObjectValue<ItemReference>("parentReference", ParentReference);
            writer.WriteObjectValue<ApiSdk.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<ApiSdk.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<ApiSdk.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteObjectValue<ApiSdk.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

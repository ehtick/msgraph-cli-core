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
    public partial class BaseSitePage : global::ApiSdk.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The pageLayout property</summary>
        public global::ApiSdk.Models.PageLayoutType? PageLayout { get; set; }
        /// <summary>The publishingState property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PublicationFacet? PublishingState { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PublicationFacet PublishingState { get; set; }
#endif
        /// <summary>Title of the sitePage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.BaseSitePage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.BaseSitePage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.BaseSitePage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "pageLayout", n => { PageLayout = n.GetEnumValue<global::ApiSdk.Models.PageLayoutType>(); } },
                { "publishingState", n => { PublishingState = n.GetObjectValue<global::ApiSdk.Models.PublicationFacet>(global::ApiSdk.Models.PublicationFacet.CreateFromDiscriminatorValue); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.PageLayoutType>("pageLayout", PageLayout);
            writer.WriteObjectValue<global::ApiSdk.Models.PublicationFacet>("publishingState", PublishingState);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618

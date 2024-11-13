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
    public partial class Trending : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The resource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Entity? Resource { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Entity Resource { get; set; }
#endif
        /// <summary>The resourceReference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ResourceReference? ResourceReference { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ResourceReference ResourceReference { get; set; }
#endif
        /// <summary>The resourceVisualization property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ResourceVisualization? ResourceVisualization { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ResourceVisualization ResourceVisualization { get; set; }
#endif
        /// <summary>Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.</summary>
        public double? Weight { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Trending"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Trending CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Trending();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "resource", n => { Resource = n.GetObjectValue<global::ApiSdk.Models.Entity>(global::ApiSdk.Models.Entity.CreateFromDiscriminatorValue); } },
                { "resourceReference", n => { ResourceReference = n.GetObjectValue<global::ApiSdk.Models.ResourceReference>(global::ApiSdk.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                { "resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<global::ApiSdk.Models.ResourceVisualization>(global::ApiSdk.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
                { "weight", n => { Weight = n.GetDoubleValue(); } },
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
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.Entity>("resource", Resource);
            writer.WriteObjectValue<global::ApiSdk.Models.ResourceReference>("resourceReference", ResourceReference);
            writer.WriteObjectValue<global::ApiSdk.Models.ResourceVisualization>("resourceVisualization", ResourceVisualization);
            writer.WriteDoubleValue("weight", Weight);
        }
    }
}
#pragma warning restore CS0618

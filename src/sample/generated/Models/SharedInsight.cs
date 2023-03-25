using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class SharedInsight : Entity, IParsable {
        /// <summary>The lastShared property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SharingDetail? LastShared { get; set; }
#nullable restore
#else
        public SharingDetail LastShared { get; set; }
#endif
        /// <summary>The lastSharedMethod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? LastSharedMethod { get; set; }
#nullable restore
#else
        public Entity LastSharedMethod { get; set; }
#endif
        /// <summary>The resource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Resource { get; set; }
#nullable restore
#else
        public Entity Resource { get; set; }
#endif
        /// <summary>The resourceReference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ResourceReference? ResourceReference { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ResourceReference ResourceReference { get; set; }
#endif
        /// <summary>The resourceVisualization property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ResourceVisualization? ResourceVisualization { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ResourceVisualization ResourceVisualization { get; set; }
#endif
        /// <summary>The sharingHistory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SharingDetail>? SharingHistory { get; set; }
#nullable restore
#else
        public List<SharingDetail> SharingHistory { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharedInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastShared", n => { LastShared = n.GetObjectValue<SharingDetail>(SharingDetail.CreateFromDiscriminatorValue); } },
                {"lastSharedMethod", n => { LastSharedMethod = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<ApiSdk.Models.ResourceReference>(ApiSdk.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<ApiSdk.Models.ResourceVisualization>(ApiSdk.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
                {"sharingHistory", n => { SharingHistory = n.GetCollectionOfObjectValues<SharingDetail>(SharingDetail.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<SharingDetail>("lastShared", LastShared);
            writer.WriteObjectValue<Entity>("lastSharedMethod", LastSharedMethod);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteObjectValue<ApiSdk.Models.ResourceReference>("resourceReference", ResourceReference);
            writer.WriteObjectValue<ApiSdk.Models.ResourceVisualization>("resourceVisualization", ResourceVisualization);
            writer.WriteCollectionOfObjectValues<SharingDetail>("sharingHistory", SharingHistory);
        }
    }
}
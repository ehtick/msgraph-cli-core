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
    public partial class PlannerTaskDetails : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The checklist property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerChecklistItems? Checklist { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerChecklistItems Checklist { get; set; }
#endif
        /// <summary>Description of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The previewType property</summary>
        public global::ApiSdk.Models.PlannerPreviewType? PreviewType { get; set; }
        /// <summary>The references property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PlannerExternalReferences? References { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PlannerExternalReferences References { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PlannerTaskDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PlannerTaskDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PlannerTaskDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "checklist", n => { Checklist = n.GetObjectValue<global::ApiSdk.Models.PlannerChecklistItems>(global::ApiSdk.Models.PlannerChecklistItems.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "previewType", n => { PreviewType = n.GetEnumValue<global::ApiSdk.Models.PlannerPreviewType>(); } },
                { "references", n => { References = n.GetObjectValue<global::ApiSdk.Models.PlannerExternalReferences>(global::ApiSdk.Models.PlannerExternalReferences.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerChecklistItems>("checklist", Checklist);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::ApiSdk.Models.PlannerPreviewType>("previewType", PreviewType);
            writer.WriteObjectValue<global::ApiSdk.Models.PlannerExternalReferences>("references", References);
        }
    }
}
#pragma warning restore CS0618

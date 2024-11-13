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
    public partial class WorkbookNamedItem : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The comment associated with this name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The name of the object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Indicates whether the name is scoped to the workbook or to a specific worksheet. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope { get; set; }
#nullable restore
#else
        public string Scope { get; set; }
#endif
        /// <summary>The type of reference is associated with the name. Possible values are: String, Integer, Double, Boolean, Range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Json? Value { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Json Value { get; set; }
#endif
        /// <summary>Indicates whether the object is visible.</summary>
        public bool? Visible { get; set; }
        /// <summary>The worksheet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkbookWorksheet? Worksheet { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkbookWorksheet Worksheet { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WorkbookNamedItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WorkbookNamedItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WorkbookNamedItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "comment", n => { Comment = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "scope", n => { Scope = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "value", n => { Value = n.GetObjectValue<global::ApiSdk.Models.Json>(global::ApiSdk.Models.Json.CreateFromDiscriminatorValue); } },
                { "visible", n => { Visible = n.GetBoolValue(); } },
                { "worksheet", n => { Worksheet = n.GetObjectValue<global::ApiSdk.Models.WorkbookWorksheet>(global::ApiSdk.Models.WorkbookWorksheet.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteObjectValue<global::ApiSdk.Models.Json>("value", Value);
            writer.WriteBoolValue("visible", Visible);
            writer.WriteObjectValue<global::ApiSdk.Models.WorkbookWorksheet>("worksheet", Worksheet);
        }
    }
}
#pragma warning restore CS0618

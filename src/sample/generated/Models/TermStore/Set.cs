// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace ApiSdk.Models.TermStore
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Set : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Children terms of set in term [store].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.Term>? Children { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.Term> Children { get; set; }
#endif
        /// <summary>Date and time of set creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description that gives details on the term usage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name of the set for each languageTag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.LocalizedName>? LocalizedNames { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.LocalizedName> LocalizedNames { get; set; }
#endif
        /// <summary>The parentGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.TermStore.Group? ParentGroup { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.TermStore.Group ParentGroup { get; set; }
#endif
        /// <summary>Custom properties for the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.KeyValue>? Properties { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.KeyValue> Properties { get; set; }
#endif
        /// <summary>Indicates which terms have been pinned or reused directly under the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.Relation>? Relations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.Relation> Relations { get; set; }
#endif
        /// <summary>All the terms under the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TermStore.Term>? Terms { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TermStore.Term> Terms { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.TermStore.Set"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.TermStore.Set CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.TermStore.Set();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "children", n => { Children = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Term>(global::ApiSdk.Models.TermStore.Term.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "localizedNames", n => { LocalizedNames = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.LocalizedName>(global::ApiSdk.Models.TermStore.LocalizedName.CreateFromDiscriminatorValue)?.AsList(); } },
                { "parentGroup", n => { ParentGroup = n.GetObjectValue<global::ApiSdk.Models.TermStore.Group>(global::ApiSdk.Models.TermStore.Group.CreateFromDiscriminatorValue); } },
                { "properties", n => { Properties = n.GetCollectionOfObjectValues<global::ApiSdk.Models.KeyValue>(global::ApiSdk.Models.KeyValue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "relations", n => { Relations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Relation>(global::ApiSdk.Models.TermStore.Relation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "terms", n => { Terms = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Term>(global::ApiSdk.Models.TermStore.Term.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Term>("children", Children);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.LocalizedName>("localizedNames", LocalizedNames);
            writer.WriteObjectValue<global::ApiSdk.Models.TermStore.Group>("parentGroup", ParentGroup);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.KeyValue>("properties", Properties);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Relation>("relations", Relations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TermStore.Term>("terms", Terms);
        }
    }
}
#pragma warning restore CS0618

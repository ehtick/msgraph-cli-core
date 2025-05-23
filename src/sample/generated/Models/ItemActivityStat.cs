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
    public partial class ItemActivityStat : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The access property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemActionStat? Access { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemActionStat Access { get; set; }
#endif
        /// <summary>Exposes the itemActivities represented in this itemActivityStat resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ItemActivity>? Activities { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ItemActivity> Activities { get; set; }
#endif
        /// <summary>The create property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemActionStat? Create { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemActionStat Create { get; set; }
#endif
        /// <summary>The delete property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemActionStat? Delete { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemActionStat Delete { get; set; }
#endif
        /// <summary>The edit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemActionStat? Edit { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemActionStat Edit { get; set; }
#endif
        /// <summary>When the interval ends. Read-only.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The incompleteData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IncompleteData? IncompleteData { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IncompleteData IncompleteData { get; set; }
#endif
        /// <summary>Indicates whether the item is &apos;trending.&apos; Read-only.</summary>
        public bool? IsTrending { get; set; }
        /// <summary>The move property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemActionStat? Move { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemActionStat Move { get; set; }
#endif
        /// <summary>When the interval starts. Read-only.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ItemActivityStat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ItemActivityStat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ItemActivityStat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "access", n => { Access = n.GetObjectValue<global::ApiSdk.Models.ItemActionStat>(global::ApiSdk.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "activities", n => { Activities = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ItemActivity>(global::ApiSdk.Models.ItemActivity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "create", n => { Create = n.GetObjectValue<global::ApiSdk.Models.ItemActionStat>(global::ApiSdk.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "delete", n => { Delete = n.GetObjectValue<global::ApiSdk.Models.ItemActionStat>(global::ApiSdk.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "edit", n => { Edit = n.GetObjectValue<global::ApiSdk.Models.ItemActionStat>(global::ApiSdk.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "incompleteData", n => { IncompleteData = n.GetObjectValue<global::ApiSdk.Models.IncompleteData>(global::ApiSdk.Models.IncompleteData.CreateFromDiscriminatorValue); } },
                { "isTrending", n => { IsTrending = n.GetBoolValue(); } },
                { "move", n => { Move = n.GetObjectValue<global::ApiSdk.Models.ItemActionStat>(global::ApiSdk.Models.ItemActionStat.CreateFromDiscriminatorValue); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ItemActionStat>("access", Access);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ItemActivity>("activities", Activities);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemActionStat>("create", Create);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemActionStat>("delete", Delete);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemActionStat>("edit", Edit);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.IncompleteData>("incompleteData", IncompleteData);
            writer.WriteBoolValue("isTrending", IsTrending);
            writer.WriteObjectValue<global::ApiSdk.Models.ItemActionStat>("move", Move);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
#pragma warning restore CS0618

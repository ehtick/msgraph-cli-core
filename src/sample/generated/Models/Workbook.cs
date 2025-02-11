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
    public partial class Workbook : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkbookApplication? Application { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkbookApplication Application { get; set; }
#endif
        /// <summary>Represents a collection of comments in a workbook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookComment>? Comments { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookComment> Comments { get; set; }
#endif
        /// <summary>The functions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.WorkbookFunctions? Functions { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.WorkbookFunctions Functions { get; set; }
#endif
        /// <summary>Represents a collection of workbooks scoped named items (named ranges and constants). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookNamedItem>? Names { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookNamedItem> Names { get; set; }
#endif
        /// <summary>The status of workbook operations. Getting an operation collection is not supported, but you can get the status of a long-running operation if the Location header is returned in the response. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookOperation>? Operations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookOperation> Operations { get; set; }
#endif
        /// <summary>Represents a collection of tables associated with the workbook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookTable>? Tables { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookTable> Tables { get; set; }
#endif
        /// <summary>Represents a collection of worksheets associated with the workbook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.WorkbookWorksheet>? Worksheets { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.WorkbookWorksheet> Worksheets { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Workbook"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Workbook CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Workbook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "application", n => { Application = n.GetObjectValue<global::ApiSdk.Models.WorkbookApplication>(global::ApiSdk.Models.WorkbookApplication.CreateFromDiscriminatorValue); } },
                { "comments", n => { Comments = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookComment>(global::ApiSdk.Models.WorkbookComment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "functions", n => { Functions = n.GetObjectValue<global::ApiSdk.Models.WorkbookFunctions>(global::ApiSdk.Models.WorkbookFunctions.CreateFromDiscriminatorValue); } },
                { "names", n => { Names = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookNamedItem>(global::ApiSdk.Models.WorkbookNamedItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookOperation>(global::ApiSdk.Models.WorkbookOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tables", n => { Tables = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookTable>(global::ApiSdk.Models.WorkbookTable.CreateFromDiscriminatorValue)?.AsList(); } },
                { "worksheets", n => { Worksheets = n.GetCollectionOfObjectValues<global::ApiSdk.Models.WorkbookWorksheet>(global::ApiSdk.Models.WorkbookWorksheet.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.WorkbookApplication>("application", Application);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookComment>("comments", Comments);
            writer.WriteObjectValue<global::ApiSdk.Models.WorkbookFunctions>("functions", Functions);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookTable>("tables", Tables);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.WorkbookWorksheet>("worksheets", Worksheets);
        }
    }
}
#pragma warning restore CS0618

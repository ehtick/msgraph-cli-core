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
    public partial class PrinterCapabilities : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A list of supported bottom margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? BottomMargins { get; set; }
#nullable restore
#else
        public List<int?> BottomMargins { get; set; }
#endif
        /// <summary>True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.</summary>
        public bool? Collation { get; set; }
        /// <summary>The color modes supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintColorMode?>? ColorModes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintColorMode?> ColorModes { get; set; }
#endif
        /// <summary>A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContentTypes { get; set; }
#nullable restore
#else
        public List<string> ContentTypes { get; set; }
#endif
        /// <summary>The copiesPerJob property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.IntegerRange? CopiesPerJob { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.IntegerRange CopiesPerJob { get; set; }
#endif
        /// <summary>The list of print resolutions in DPI that are supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? Dpis { get; set; }
#nullable restore
#else
        public List<int?> Dpis { get; set; }
#endif
        /// <summary>The list of duplex modes that are supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintDuplexMode?>? DuplexModes { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintDuplexMode?> DuplexModes { get; set; }
#endif
        /// <summary>The list of feed orientations that are supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrinterFeedOrientation?>? FeedOrientations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrinterFeedOrientation?> FeedOrientations { get; set; }
#endif
        /// <summary>Finishing processes the printer supports for a printed document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintFinishing?>? Finishings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintFinishing?> Finishings { get; set; }
#endif
        /// <summary>Supported input bins for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InputBins { get; set; }
#nullable restore
#else
        public List<string> InputBins { get; set; }
#endif
        /// <summary>True if color printing is supported by the printer; false otherwise. Read-only.</summary>
        public bool? IsColorPrintingSupported { get; set; }
        /// <summary>True if the printer supports printing by page ranges; false otherwise.</summary>
        public bool? IsPageRangeSupported { get; set; }
        /// <summary>A list of supported left margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? LeftMargins { get; set; }
#nullable restore
#else
        public List<int?> LeftMargins { get; set; }
#endif
        /// <summary>The media (i.e., paper) colors supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaColors { get; set; }
#nullable restore
#else
        public List<string> MediaColors { get; set; }
#endif
        /// <summary>The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes. Valid values are in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaSizes { get; set; }
#nullable restore
#else
        public List<string> MediaSizes { get; set; }
#endif
        /// <summary>The media types supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaTypes { get; set; }
#nullable restore
#else
        public List<string> MediaTypes { get; set; }
#endif
        /// <summary>The presentation directions supported by the printer. Supported values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintMultipageLayout?>? MultipageLayouts { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintMultipageLayout?> MultipageLayouts { get; set; }
#endif
        /// <summary>The print orientations supported by the printer. Valid values are described in the following table.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintOrientation?>? Orientations { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintOrientation?> Orientations { get; set; }
#endif
        /// <summary>The printer&apos;s supported output bins (trays).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OutputBins { get; set; }
#nullable restore
#else
        public List<string> OutputBins { get; set; }
#endif
        /// <summary>Supported number of Input Pages to impose upon a single Impression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? PagesPerSheet { get; set; }
#nullable restore
#else
        public List<int?> PagesPerSheet { get; set; }
#endif
        /// <summary>The print qualities supported by the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintQuality?>? Qualities { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintQuality?> Qualities { get; set; }
#endif
        /// <summary>A list of supported right margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? RightMargins { get; set; }
#nullable restore
#else
        public List<int?> RightMargins { get; set; }
#endif
        /// <summary>Supported print scalings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.PrintScaling?>? Scalings { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.PrintScaling?> Scalings { get; set; }
#endif
        /// <summary>True if the printer supports scaling PDF pages to match the print media size; false otherwise.</summary>
        public bool? SupportsFitPdfToPage { get; set; }
        /// <summary>A list of supported top margins(in microns) for the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? TopMargins { get; set; }
#nullable restore
#else
        public List<int?> TopMargins { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.PrinterCapabilities"/> and sets the default values.
        /// </summary>
        public PrinterCapabilities()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PrinterCapabilities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.PrinterCapabilities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PrinterCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bottomMargins", n => { BottomMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "collation", n => { Collation = n.GetBoolValue(); } },
                { "colorModes", n => { ColorModes = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintColorMode>()?.AsList(); } },
                { "contentTypes", n => { ContentTypes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "copiesPerJob", n => { CopiesPerJob = n.GetObjectValue<global::ApiSdk.Models.IntegerRange>(global::ApiSdk.Models.IntegerRange.CreateFromDiscriminatorValue); } },
                { "dpis", n => { Dpis = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "duplexModes", n => { DuplexModes = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintDuplexMode>()?.AsList(); } },
                { "feedOrientations", n => { FeedOrientations = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrinterFeedOrientation>()?.AsList(); } },
                { "finishings", n => { Finishings = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintFinishing>()?.AsList(); } },
                { "inputBins", n => { InputBins = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "isColorPrintingSupported", n => { IsColorPrintingSupported = n.GetBoolValue(); } },
                { "isPageRangeSupported", n => { IsPageRangeSupported = n.GetBoolValue(); } },
                { "leftMargins", n => { LeftMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "mediaColors", n => { MediaColors = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "mediaSizes", n => { MediaSizes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "mediaTypes", n => { MediaTypes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "multipageLayouts", n => { MultipageLayouts = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintMultipageLayout>()?.AsList(); } },
                { "orientations", n => { Orientations = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintOrientation>()?.AsList(); } },
                { "outputBins", n => { OutputBins = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "pagesPerSheet", n => { PagesPerSheet = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "qualities", n => { Qualities = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintQuality>()?.AsList(); } },
                { "rightMargins", n => { RightMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
                { "scalings", n => { Scalings = n.GetCollectionOfEnumValues<global::ApiSdk.Models.PrintScaling>()?.AsList(); } },
                { "supportsFitPdfToPage", n => { SupportsFitPdfToPage = n.GetBoolValue(); } },
                { "topMargins", n => { TopMargins = n.GetCollectionOfPrimitiveValues<int?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<int?>("bottomMargins", BottomMargins);
            writer.WriteBoolValue("collation", Collation);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintColorMode>("colorModes", ColorModes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentTypes", ContentTypes);
            writer.WriteObjectValue<global::ApiSdk.Models.IntegerRange>("copiesPerJob", CopiesPerJob);
            writer.WriteCollectionOfPrimitiveValues<int?>("dpis", Dpis);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintDuplexMode>("duplexModes", DuplexModes);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrinterFeedOrientation>("feedOrientations", FeedOrientations);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintFinishing>("finishings", Finishings);
            writer.WriteCollectionOfPrimitiveValues<string>("inputBins", InputBins);
            writer.WriteBoolValue("isColorPrintingSupported", IsColorPrintingSupported);
            writer.WriteBoolValue("isPageRangeSupported", IsPageRangeSupported);
            writer.WriteCollectionOfPrimitiveValues<int?>("leftMargins", LeftMargins);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaColors", MediaColors);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaSizes", MediaSizes);
            writer.WriteCollectionOfPrimitiveValues<string>("mediaTypes", MediaTypes);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintMultipageLayout>("multipageLayouts", MultipageLayouts);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintOrientation>("orientations", Orientations);
            writer.WriteCollectionOfPrimitiveValues<string>("outputBins", OutputBins);
            writer.WriteCollectionOfPrimitiveValues<int?>("pagesPerSheet", PagesPerSheet);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintQuality>("qualities", Qualities);
            writer.WriteCollectionOfPrimitiveValues<int?>("rightMargins", RightMargins);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.PrintScaling>("scalings", Scalings);
            writer.WriteBoolValue("supportsFitPdfToPage", SupportsFitPdfToPage);
            writer.WriteCollectionOfPrimitiveValues<int?>("topMargins", TopMargins);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

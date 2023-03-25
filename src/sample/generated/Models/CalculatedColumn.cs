using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class CalculatedColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Format { get; set; }
#nullable restore
#else
        public string Format { get; set; }
#endif
        /// <summary>The formula used to compute the value for this column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Formula { get; set; }
#nullable restore
#else
        public string Formula { get; set; }
#endif
        /// <summary>The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputType { get; set; }
#nullable restore
#else
        public string OutputType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new calculatedColumn and sets the default values.
        /// </summary>
        public CalculatedColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CalculatedColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalculatedColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"format", n => { Format = n.GetStringValue(); } },
                {"formula", n => { Formula = n.GetStringValue(); } },
                {"outputType", n => { OutputType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("format", Format);
            writer.WriteStringValue("formula", Formula);
            writer.WriteStringValue("outputType", OutputType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
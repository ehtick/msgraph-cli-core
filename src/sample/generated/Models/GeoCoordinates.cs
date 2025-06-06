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
    public partial class GeoCoordinates : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional. The altitude (height), in feet,  above sea level for the item. Read-only.</summary>
        public double? Altitude { get; set; }
        /// <summary>Optional. The latitude, in decimal, for the item. Read-only.</summary>
        public double? Latitude { get; set; }
        /// <summary>Optional. The longitude, in decimal, for the item. Read-only.</summary>
        public double? Longitude { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.GeoCoordinates"/> and sets the default values.
        /// </summary>
        public GeoCoordinates()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.GeoCoordinates"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.GeoCoordinates CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.GeoCoordinates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "altitude", n => { Altitude = n.GetDoubleValue(); } },
                { "latitude", n => { Latitude = n.GetDoubleValue(); } },
                { "longitude", n => { Longitude = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("altitude", Altitude);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

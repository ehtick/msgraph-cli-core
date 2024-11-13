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
    public partial class WindowsHelloForBusinessAuthenticationMethod : global::ApiSdk.Models.AuthenticationMethod, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date and time that this Windows Hello for Business key was registered.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The device property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Device? Device { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Device Device { get; set; }
#endif
        /// <summary>The name of the device on which Windows Hello for Business is registered</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The keyStrength property</summary>
        public global::ApiSdk.Models.AuthenticationMethodKeyStrength? KeyStrength { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.WindowsHelloForBusinessAuthenticationMethod"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.WindowsHelloForBusinessAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.WindowsHelloForBusinessAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "device", n => { Device = n.GetObjectValue<global::ApiSdk.Models.Device>(global::ApiSdk.Models.Device.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "keyStrength", n => { KeyStrength = n.GetEnumValue<global::ApiSdk.Models.AuthenticationMethodKeyStrength>(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.Device>("device", Device);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::ApiSdk.Models.AuthenticationMethodKeyStrength>("keyStrength", KeyStrength);
        }
    }
}
#pragma warning restore CS0618

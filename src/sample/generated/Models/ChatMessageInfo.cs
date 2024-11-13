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
    public partial class ChatMessageInfo : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ItemBody? Body { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ItemBody Body { get; set; }
#endif
        /// <summary>Date time object representing the time at which message was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The eventDetail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.EventMessageDetail? EventDetail { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.EventMessageDetail EventDetail { get; set; }
#endif
        /// <summary>The from property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ChatMessageFromIdentitySet? From { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ChatMessageFromIdentitySet From { get; set; }
#endif
        /// <summary>If set to true, the original message has been deleted.</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>The messageType property</summary>
        public global::ApiSdk.Models.ChatMessageType? MessageType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ChatMessageInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ChatMessageInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ChatMessageInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "body", n => { Body = n.GetObjectValue<global::ApiSdk.Models.ItemBody>(global::ApiSdk.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "eventDetail", n => { EventDetail = n.GetObjectValue<global::ApiSdk.Models.EventMessageDetail>(global::ApiSdk.Models.EventMessageDetail.CreateFromDiscriminatorValue); } },
                { "from", n => { From = n.GetObjectValue<global::ApiSdk.Models.ChatMessageFromIdentitySet>(global::ApiSdk.Models.ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                { "isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                { "messageType", n => { MessageType = n.GetEnumValue<global::ApiSdk.Models.ChatMessageType>(); } },
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
            writer.WriteObjectValue<global::ApiSdk.Models.ItemBody>("body", Body);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<global::ApiSdk.Models.ChatMessageFromIdentitySet>("from", From);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteEnumValue<global::ApiSdk.Models.ChatMessageType>("messageType", MessageType);
        }
    }
}
#pragma warning restore CS0618

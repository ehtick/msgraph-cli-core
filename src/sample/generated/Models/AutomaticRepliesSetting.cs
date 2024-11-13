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
    public partial class AutomaticRepliesSetting : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The externalAudience property</summary>
        public global::ApiSdk.Models.ExternalAudienceScope? ExternalAudience { get; set; }
        /// <summary>The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalReplyMessage { get; set; }
#nullable restore
#else
        public string ExternalReplyMessage { get; set; }
#endif
        /// <summary>The automatic reply to send to the audience internal to the signed-in user&apos;s organization, if Status is AlwaysEnabled or Scheduled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalReplyMessage { get; set; }
#nullable restore
#else
        public string InternalReplyMessage { get; set; }
#endif
        /// <summary>The scheduledEndDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DateTimeTimeZone? ScheduledEndDateTime { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DateTimeTimeZone ScheduledEndDateTime { get; set; }
#endif
        /// <summary>The scheduledStartDateTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DateTimeTimeZone? ScheduledStartDateTime { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DateTimeTimeZone ScheduledStartDateTime { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::ApiSdk.Models.AutomaticRepliesStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.AutomaticRepliesSetting"/> and sets the default values.
        /// </summary>
        public AutomaticRepliesSetting()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.AutomaticRepliesSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.AutomaticRepliesSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.AutomaticRepliesSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "externalAudience", n => { ExternalAudience = n.GetEnumValue<global::ApiSdk.Models.ExternalAudienceScope>(); } },
                { "externalReplyMessage", n => { ExternalReplyMessage = n.GetStringValue(); } },
                { "internalReplyMessage", n => { InternalReplyMessage = n.GetStringValue(); } },
                { "scheduledEndDateTime", n => { ScheduledEndDateTime = n.GetObjectValue<global::ApiSdk.Models.DateTimeTimeZone>(global::ApiSdk.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "scheduledStartDateTime", n => { ScheduledStartDateTime = n.GetObjectValue<global::ApiSdk.Models.DateTimeTimeZone>(global::ApiSdk.Models.DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::ApiSdk.Models.AutomaticRepliesStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.ExternalAudienceScope>("externalAudience", ExternalAudience);
            writer.WriteStringValue("externalReplyMessage", ExternalReplyMessage);
            writer.WriteStringValue("internalReplyMessage", InternalReplyMessage);
            writer.WriteObjectValue<global::ApiSdk.Models.DateTimeTimeZone>("scheduledEndDateTime", ScheduledEndDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.DateTimeTimeZone>("scheduledStartDateTime", ScheduledStartDateTime);
            writer.WriteEnumValue<global::ApiSdk.Models.AutomaticRepliesStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

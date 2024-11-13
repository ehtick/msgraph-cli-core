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
    public partial class ScheduleChangeRequest : global::ApiSdk.Models.ChangeTrackedEntity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The assignedTo property</summary>
        public global::ApiSdk.Models.ScheduleChangeRequestActor? AssignedTo { get; set; }
        /// <summary>The managerActionDateTime property</summary>
        public DateTimeOffset? ManagerActionDateTime { get; private set; }
        /// <summary>The managerActionMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerActionMessage { get; set; }
#nullable restore
#else
        public string ManagerActionMessage { get; set; }
#endif
        /// <summary>The managerUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerUserId { get; private set; }
#nullable restore
#else
        public string ManagerUserId { get; private set; }
#endif
        /// <summary>The senderDateTime property</summary>
        public DateTimeOffset? SenderDateTime { get; private set; }
        /// <summary>The senderMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderMessage { get; set; }
#nullable restore
#else
        public string SenderMessage { get; set; }
#endif
        /// <summary>The senderUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderUserId { get; private set; }
#nullable restore
#else
        public string SenderUserId { get; private set; }
#endif
        /// <summary>The state property</summary>
        public global::ApiSdk.Models.ScheduleChangeState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ScheduleChangeRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.ScheduleChangeRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ScheduleChangeRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignedTo", n => { AssignedTo = n.GetEnumValue<global::ApiSdk.Models.ScheduleChangeRequestActor>(); } },
                { "managerActionDateTime", n => { ManagerActionDateTime = n.GetDateTimeOffsetValue(); } },
                { "managerActionMessage", n => { ManagerActionMessage = n.GetStringValue(); } },
                { "managerUserId", n => { ManagerUserId = n.GetStringValue(); } },
                { "senderDateTime", n => { SenderDateTime = n.GetDateTimeOffsetValue(); } },
                { "senderMessage", n => { SenderMessage = n.GetStringValue(); } },
                { "senderUserId", n => { SenderUserId = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::ApiSdk.Models.ScheduleChangeState>(); } },
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
            writer.WriteEnumValue<global::ApiSdk.Models.ScheduleChangeRequestActor>("assignedTo", AssignedTo);
            writer.WriteStringValue("managerActionMessage", ManagerActionMessage);
            writer.WriteStringValue("senderMessage", SenderMessage);
            writer.WriteEnumValue<global::ApiSdk.Models.ScheduleChangeState>("state", State);
        }
    }
}
#pragma warning restore CS0618

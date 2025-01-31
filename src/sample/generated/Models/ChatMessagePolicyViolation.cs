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
    public partial class ChatMessagePolicyViolation : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The dlpAction property</summary>
        public global::ApiSdk.Models.ChatMessagePolicyViolationDlpActionTypes? DlpAction { get; set; }
        /// <summary>Justification text provided by the sender of the message when overriding a policy violation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JustificationText { get; set; }
#nullable restore
#else
        public string JustificationText { get; set; }
#endif
        /// <summary>The policyTip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ChatMessagePolicyViolationPolicyTip? PolicyTip { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ChatMessagePolicyViolationPolicyTip PolicyTip { get; set; }
#endif
        /// <summary>The userAction property</summary>
        public global::ApiSdk.Models.ChatMessagePolicyViolationUserActionTypes? UserAction { get; set; }
        /// <summary>The verdictDetails property</summary>
        public global::ApiSdk.Models.ChatMessagePolicyViolationVerdictDetailsTypes? VerdictDetails { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.ChatMessagePolicyViolation"/> and sets the default values.
        /// </summary>
        public ChatMessagePolicyViolation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.ChatMessagePolicyViolation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.ChatMessagePolicyViolation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.ChatMessagePolicyViolation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dlpAction", n => { DlpAction = n.GetEnumValue<global::ApiSdk.Models.ChatMessagePolicyViolationDlpActionTypes>(); } },
                { "justificationText", n => { JustificationText = n.GetStringValue(); } },
                { "policyTip", n => { PolicyTip = n.GetObjectValue<global::ApiSdk.Models.ChatMessagePolicyViolationPolicyTip>(global::ApiSdk.Models.ChatMessagePolicyViolationPolicyTip.CreateFromDiscriminatorValue); } },
                { "userAction", n => { UserAction = n.GetEnumValue<global::ApiSdk.Models.ChatMessagePolicyViolationUserActionTypes>(); } },
                { "verdictDetails", n => { VerdictDetails = n.GetEnumValue<global::ApiSdk.Models.ChatMessagePolicyViolationVerdictDetailsTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::ApiSdk.Models.ChatMessagePolicyViolationDlpActionTypes>("dlpAction", DlpAction);
            writer.WriteStringValue("justificationText", JustificationText);
            writer.WriteObjectValue<global::ApiSdk.Models.ChatMessagePolicyViolationPolicyTip>("policyTip", PolicyTip);
            writer.WriteEnumValue<global::ApiSdk.Models.ChatMessagePolicyViolationUserActionTypes>("userAction", UserAction);
            writer.WriteEnumValue<global::ApiSdk.Models.ChatMessagePolicyViolationVerdictDetailsTypes>("verdictDetails", VerdictDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

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
    public partial class Channel : global::ApiSdk.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read only. Timestamp at which the channel was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional textual description for the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Channel name as it will appear to the user in Microsoft Teams. The maximum length is 50 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email address for sending messages to the channel. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The filesFolder property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.DriveItem? FilesFolder { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.DriveItem FilesFolder { get; set; }
#endif
        /// <summary>Indicates whether the channel is archived. Read-only.</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Indicates whether the channel should be marked as recommended for all members of the team to show in their channel list. Note: All recommended channels automatically show in the channels list for education and frontline worker users. The property can only be set programmatically via the Create team method. The default value is false.</summary>
        public bool? IsFavoriteByDefault { get; set; }
        /// <summary>A collection of membership records associated with the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ConversationMember>? Members { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ConversationMember> Members { get; set; }
#endif
        /// <summary>The membershipType property</summary>
        public global::ApiSdk.Models.ChannelMembershipType? MembershipType { get; set; }
        /// <summary>A collection of all the messages in the channel. A navigation property. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.ChatMessage>? Messages { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.ChatMessage> Messages { get; set; }
#endif
        /// <summary>A collection of teams with which a channel is shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.SharedWithChannelTeamInfo>? SharedWithTeams { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.SharedWithChannelTeamInfo> SharedWithTeams { get; set; }
#endif
        /// <summary>The summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.ChannelSummary? Summary { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.ChannelSummary Summary { get; set; }
#endif
        /// <summary>A collection of all the tabs in the channel. A navigation property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.TeamsTab>? Tabs { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.TeamsTab> Tabs { get; set; }
#endif
        /// <summary>The ID of the Microsoft Entra tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>A hyperlink that will go to the channel in Microsoft Teams. This is the URL that you get when you right-click a channel in Microsoft Teams and select Get link to channel. This URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.Channel"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.Channel CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.Channel();
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
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "filesFolder", n => { FilesFolder = n.GetObjectValue<global::ApiSdk.Models.DriveItem>(global::ApiSdk.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "isArchived", n => { IsArchived = n.GetBoolValue(); } },
                { "isFavoriteByDefault", n => { IsFavoriteByDefault = n.GetBoolValue(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ConversationMember>(global::ApiSdk.Models.ConversationMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "membershipType", n => { MembershipType = n.GetEnumValue<global::ApiSdk.Models.ChannelMembershipType>(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::ApiSdk.Models.ChatMessage>(global::ApiSdk.Models.ChatMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sharedWithTeams", n => { SharedWithTeams = n.GetCollectionOfObjectValues<global::ApiSdk.Models.SharedWithChannelTeamInfo>(global::ApiSdk.Models.SharedWithChannelTeamInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "summary", n => { Summary = n.GetObjectValue<global::ApiSdk.Models.ChannelSummary>(global::ApiSdk.Models.ChannelSummary.CreateFromDiscriminatorValue); } },
                { "tabs", n => { Tabs = n.GetCollectionOfObjectValues<global::ApiSdk.Models.TeamsTab>(global::ApiSdk.Models.TeamsTab.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteObjectValue<global::ApiSdk.Models.DriveItem>("filesFolder", FilesFolder);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isFavoriteByDefault", IsFavoriteByDefault);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ConversationMember>("members", Members);
            writer.WriteEnumValue<global::ApiSdk.Models.ChannelMembershipType>("membershipType", MembershipType);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.ChatMessage>("messages", Messages);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.SharedWithChannelTeamInfo>("sharedWithTeams", SharedWithTeams);
            writer.WriteObjectValue<global::ApiSdk.Models.ChannelSummary>("summary", Summary);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618

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
    public partial class PrinterShare : global::ApiSdk.Models.PrinterBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If true, all users and groups will be granted access to this printer share. This supersedes the allow lists defined by the allowedUsers and allowedGroups navigation properties.</summary>
        public bool? AllowAllUsers { get; set; }
        /// <summary>The groups whose users have access to print using the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.Group>? AllowedGroups { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.Group> AllowedGroups { get; set; }
#endif
        /// <summary>The users who have access to print using the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.User>? AllowedUsers { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.User> AllowedUsers { get; set; }
#endif
        /// <summary>The DateTimeOffset when the printer share was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The printer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.Printer? Printer { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.Printer Printer { get; set; }
#endif
        /// <summary>The viewPoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::ApiSdk.Models.PrinterShareViewpoint? ViewPoint { get; set; }
#nullable restore
#else
        public global::ApiSdk.Models.PrinterShareViewpoint ViewPoint { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.PrinterShare"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::ApiSdk.Models.PrinterShare CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.PrinterShare();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowAllUsers", n => { AllowAllUsers = n.GetBoolValue(); } },
                { "allowedGroups", n => { AllowedGroups = n.GetCollectionOfObjectValues<global::ApiSdk.Models.Group>(global::ApiSdk.Models.Group.CreateFromDiscriminatorValue)?.AsList(); } },
                { "allowedUsers", n => { AllowedUsers = n.GetCollectionOfObjectValues<global::ApiSdk.Models.User>(global::ApiSdk.Models.User.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "printer", n => { Printer = n.GetObjectValue<global::ApiSdk.Models.Printer>(global::ApiSdk.Models.Printer.CreateFromDiscriminatorValue); } },
                { "viewPoint", n => { ViewPoint = n.GetObjectValue<global::ApiSdk.Models.PrinterShareViewpoint>(global::ApiSdk.Models.PrinterShareViewpoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("allowAllUsers", AllowAllUsers);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.Group>("allowedGroups", AllowedGroups);
            writer.WriteCollectionOfObjectValues<global::ApiSdk.Models.User>("allowedUsers", AllowedUsers);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::ApiSdk.Models.Printer>("printer", Printer);
            writer.WriteObjectValue<global::ApiSdk.Models.PrinterShareViewpoint>("viewPoint", ViewPoint);
        }
    }
}
#pragma warning restore CS0618

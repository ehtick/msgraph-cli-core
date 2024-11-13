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
    public partial class RecurrencePattern : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.</summary>
        public int? DayOfMonth { get; set; }
        /// <summary>A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::ApiSdk.Models.DayOfWeekObject?>? DaysOfWeek { get; set; }
#nullable restore
#else
        public List<global::ApiSdk.Models.DayOfWeekObject?> DaysOfWeek { get; set; }
#endif
        /// <summary>The firstDayOfWeek property</summary>
        public global::ApiSdk.Models.DayOfWeekObject? FirstDayOfWeek { get; set; }
        /// <summary>The index property</summary>
        public global::ApiSdk.Models.WeekIndex? Index { get; set; }
        /// <summary>The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.</summary>
        public int? Interval { get; set; }
        /// <summary>The month in which the event occurs.  This is a number from 1 to 12.</summary>
        public int? Month { get; set; }
        /// <summary>The type property</summary>
        public global::ApiSdk.Models.RecurrencePatternType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::ApiSdk.Models.RecurrencePattern"/> and sets the default values.
        /// </summary>
        public RecurrencePattern()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::ApiSdk.Models.RecurrencePattern"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::ApiSdk.Models.RecurrencePattern CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::ApiSdk.Models.RecurrencePattern();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dayOfMonth", n => { DayOfMonth = n.GetIntValue(); } },
                { "daysOfWeek", n => { DaysOfWeek = n.GetCollectionOfEnumValues<global::ApiSdk.Models.DayOfWeekObject>()?.AsList(); } },
                { "firstDayOfWeek", n => { FirstDayOfWeek = n.GetEnumValue<global::ApiSdk.Models.DayOfWeekObject>(); } },
                { "index", n => { Index = n.GetEnumValue<global::ApiSdk.Models.WeekIndex>(); } },
                { "interval", n => { Interval = n.GetIntValue(); } },
                { "month", n => { Month = n.GetIntValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::ApiSdk.Models.RecurrencePatternType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dayOfMonth", DayOfMonth);
            writer.WriteCollectionOfEnumValues<global::ApiSdk.Models.DayOfWeekObject>("daysOfWeek", DaysOfWeek);
            writer.WriteEnumValue<global::ApiSdk.Models.DayOfWeekObject>("firstDayOfWeek", FirstDayOfWeek);
            writer.WriteEnumValue<global::ApiSdk.Models.WeekIndex>("index", Index);
            writer.WriteIntValue("interval", Interval);
            writer.WriteIntValue("month", Month);
            writer.WriteEnumValue<global::ApiSdk.Models.RecurrencePatternType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618

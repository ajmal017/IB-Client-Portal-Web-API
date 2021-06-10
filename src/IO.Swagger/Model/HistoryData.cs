/* 
 * Client Portal Web API
 *
 * Client Portal Web API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// HistoryData
    /// </summary>
    [DataContract]
    public partial class HistoryData :  IEquatable<HistoryData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryData" /> class.
        /// </summary>
        /// <param name="symbol">Underlying Symbol of the corresponding contract.</param>
        /// <param name="text">companyName of the corresponding contract.</param>
        /// <param name="priceFactor">priceFactor is price increment obtained from display rule.</param>
        /// <param name="startTime">start date time in the format YYYYMMDD-HH:mm:ss.</param>
        /// <param name="high">High value during this time series with format %h/%v/%t. %h is the high price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart .</param>
        /// <param name="low">Low value during this time series with format %l/%v/%t. %l is the low price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart .</param>
        /// <param name="timePeriod">The duration for the historical data request.</param>
        /// <param name="barLength">The number of seconds in a bar.</param>
        /// <param name="mdAvailability">Market Data Availability. The field may contain two chars. The first char is the primary code: S &#x3D; Streaming, R &#x3D; Realtime, D &#x3D; Delayed, Z &#x3D; Frozen, Y &#x3D; Frozen Delayed. The second char is the secondary code: P &#x3D; Snapshot Available, p &#x3D; Consolidated. .</param>
        /// <param name="mktDataDelay">The time it takes, in milliseconds, to process the historical data request.</param>
        /// <param name="outsideRth">The historical data returned includes outside of regular trading hours .</param>
        /// <param name="tradingDayDuration">The number of seconds in the trading day.</param>
        /// <param name="volumeFactor">volumeFactor.</param>
        /// <param name="priceDisplayRule">priceDisplayRule.</param>
        /// <param name="priceDisplayValue">priceDisplayValue.</param>
        /// <param name="negativeCapable">negativeCapable.</param>
        /// <param name="messageVersion">messageVersion.</param>
        /// <param name="data">data.</param>
        /// <param name="points">total number of points.</param>
        /// <param name="travelTime">travelTime.</param>
        public HistoryData(string symbol = default(string), string text = default(string), int? priceFactor = default(int?), string startTime = default(string), string high = default(string), string low = default(string), string timePeriod = default(string), int? barLength = default(int?), string mdAvailability = default(string), int? mktDataDelay = default(int?), bool? outsideRth = default(bool?), int? tradingDayDuration = default(int?), int? volumeFactor = default(int?), int? priceDisplayRule = default(int?), string priceDisplayValue = default(string), bool? negativeCapable = default(bool?), int? messageVersion = default(int?), List<Object> data = default(List<Object>), int? points = default(int?), int? travelTime = default(int?))
        {
            this.Symbol = symbol;
            this.Text = text;
            this.PriceFactor = priceFactor;
            this.StartTime = startTime;
            this.High = high;
            this.Low = low;
            this.TimePeriod = timePeriod;
            this.BarLength = barLength;
            this.MdAvailability = mdAvailability;
            this.MktDataDelay = mktDataDelay;
            this.OutsideRth = outsideRth;
            this.TradingDayDuration = tradingDayDuration;
            this.VolumeFactor = volumeFactor;
            this.PriceDisplayRule = priceDisplayRule;
            this.PriceDisplayValue = priceDisplayValue;
            this.NegativeCapable = negativeCapable;
            this.MessageVersion = messageVersion;
            this.Data = data;
            this.Points = points;
            this.TravelTime = travelTime;
        }
        
        /// <summary>
        /// Underlying Symbol of the corresponding contract
        /// </summary>
        /// <value>Underlying Symbol of the corresponding contract</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// companyName of the corresponding contract
        /// </summary>
        /// <value>companyName of the corresponding contract</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// priceFactor is price increment obtained from display rule
        /// </summary>
        /// <value>priceFactor is price increment obtained from display rule</value>
        [DataMember(Name="priceFactor", EmitDefaultValue=false)]
        public int? PriceFactor { get; set; }

        /// <summary>
        /// start date time in the format YYYYMMDD-HH:mm:ss
        /// </summary>
        /// <value>start date time in the format YYYYMMDD-HH:mm:ss</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// High value during this time series with format %h/%v/%t. %h is the high price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart 
        /// </summary>
        /// <value>High value during this time series with format %h/%v/%t. %h is the high price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart </value>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public string High { get; set; }

        /// <summary>
        /// Low value during this time series with format %l/%v/%t. %l is the low price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart 
        /// </summary>
        /// <value>Low value during this time series with format %l/%v/%t. %l is the low price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart </value>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public string Low { get; set; }

        /// <summary>
        /// The duration for the historical data request
        /// </summary>
        /// <value>The duration for the historical data request</value>
        [DataMember(Name="timePeriod", EmitDefaultValue=false)]
        public string TimePeriod { get; set; }

        /// <summary>
        /// The number of seconds in a bar
        /// </summary>
        /// <value>The number of seconds in a bar</value>
        [DataMember(Name="barLength", EmitDefaultValue=false)]
        public int? BarLength { get; set; }

        /// <summary>
        /// Market Data Availability. The field may contain two chars. The first char is the primary code: S &#x3D; Streaming, R &#x3D; Realtime, D &#x3D; Delayed, Z &#x3D; Frozen, Y &#x3D; Frozen Delayed. The second char is the secondary code: P &#x3D; Snapshot Available, p &#x3D; Consolidated. 
        /// </summary>
        /// <value>Market Data Availability. The field may contain two chars. The first char is the primary code: S &#x3D; Streaming, R &#x3D; Realtime, D &#x3D; Delayed, Z &#x3D; Frozen, Y &#x3D; Frozen Delayed. The second char is the secondary code: P &#x3D; Snapshot Available, p &#x3D; Consolidated. </value>
        [DataMember(Name="mdAvailability", EmitDefaultValue=false)]
        public string MdAvailability { get; set; }

        /// <summary>
        /// The time it takes, in milliseconds, to process the historical data request
        /// </summary>
        /// <value>The time it takes, in milliseconds, to process the historical data request</value>
        [DataMember(Name="mktDataDelay", EmitDefaultValue=false)]
        public int? MktDataDelay { get; set; }

        /// <summary>
        /// The historical data returned includes outside of regular trading hours 
        /// </summary>
        /// <value>The historical data returned includes outside of regular trading hours </value>
        [DataMember(Name="outsideRth", EmitDefaultValue=false)]
        public bool? OutsideRth { get; set; }

        /// <summary>
        /// The number of seconds in the trading day
        /// </summary>
        /// <value>The number of seconds in the trading day</value>
        [DataMember(Name="tradingDayDuration", EmitDefaultValue=false)]
        public int? TradingDayDuration { get; set; }

        /// <summary>
        /// Gets or Sets VolumeFactor
        /// </summary>
        [DataMember(Name="volumeFactor", EmitDefaultValue=false)]
        public int? VolumeFactor { get; set; }

        /// <summary>
        /// Gets or Sets PriceDisplayRule
        /// </summary>
        [DataMember(Name="priceDisplayRule", EmitDefaultValue=false)]
        public int? PriceDisplayRule { get; set; }

        /// <summary>
        /// Gets or Sets PriceDisplayValue
        /// </summary>
        [DataMember(Name="priceDisplayValue", EmitDefaultValue=false)]
        public string PriceDisplayValue { get; set; }

        /// <summary>
        /// Gets or Sets NegativeCapable
        /// </summary>
        [DataMember(Name="negativeCapable", EmitDefaultValue=false)]
        public bool? NegativeCapable { get; set; }

        /// <summary>
        /// Gets or Sets MessageVersion
        /// </summary>
        [DataMember(Name="messageVersion", EmitDefaultValue=false)]
        public int? MessageVersion { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<Object> Data { get; set; }

        /// <summary>
        /// total number of points
        /// </summary>
        /// <value>total number of points</value>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or Sets TravelTime
        /// </summary>
        [DataMember(Name="travelTime", EmitDefaultValue=false)]
        public int? TravelTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryData {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  PriceFactor: ").Append(PriceFactor).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  TimePeriod: ").Append(TimePeriod).Append("\n");
            sb.Append("  BarLength: ").Append(BarLength).Append("\n");
            sb.Append("  MdAvailability: ").Append(MdAvailability).Append("\n");
            sb.Append("  MktDataDelay: ").Append(MktDataDelay).Append("\n");
            sb.Append("  OutsideRth: ").Append(OutsideRth).Append("\n");
            sb.Append("  TradingDayDuration: ").Append(TradingDayDuration).Append("\n");
            sb.Append("  VolumeFactor: ").Append(VolumeFactor).Append("\n");
            sb.Append("  PriceDisplayRule: ").Append(PriceDisplayRule).Append("\n");
            sb.Append("  PriceDisplayValue: ").Append(PriceDisplayValue).Append("\n");
            sb.Append("  NegativeCapable: ").Append(NegativeCapable).Append("\n");
            sb.Append("  MessageVersion: ").Append(MessageVersion).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  TravelTime: ").Append(TravelTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HistoryData);
        }

        /// <summary>
        /// Returns true if HistoryData instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.PriceFactor == input.PriceFactor ||
                    (this.PriceFactor != null &&
                    this.PriceFactor.Equals(input.PriceFactor))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.TimePeriod == input.TimePeriod ||
                    (this.TimePeriod != null &&
                    this.TimePeriod.Equals(input.TimePeriod))
                ) && 
                (
                    this.BarLength == input.BarLength ||
                    (this.BarLength != null &&
                    this.BarLength.Equals(input.BarLength))
                ) && 
                (
                    this.MdAvailability == input.MdAvailability ||
                    (this.MdAvailability != null &&
                    this.MdAvailability.Equals(input.MdAvailability))
                ) && 
                (
                    this.MktDataDelay == input.MktDataDelay ||
                    (this.MktDataDelay != null &&
                    this.MktDataDelay.Equals(input.MktDataDelay))
                ) && 
                (
                    this.OutsideRth == input.OutsideRth ||
                    (this.OutsideRth != null &&
                    this.OutsideRth.Equals(input.OutsideRth))
                ) && 
                (
                    this.TradingDayDuration == input.TradingDayDuration ||
                    (this.TradingDayDuration != null &&
                    this.TradingDayDuration.Equals(input.TradingDayDuration))
                ) && 
                (
                    this.VolumeFactor == input.VolumeFactor ||
                    (this.VolumeFactor != null &&
                    this.VolumeFactor.Equals(input.VolumeFactor))
                ) && 
                (
                    this.PriceDisplayRule == input.PriceDisplayRule ||
                    (this.PriceDisplayRule != null &&
                    this.PriceDisplayRule.Equals(input.PriceDisplayRule))
                ) && 
                (
                    this.PriceDisplayValue == input.PriceDisplayValue ||
                    (this.PriceDisplayValue != null &&
                    this.PriceDisplayValue.Equals(input.PriceDisplayValue))
                ) && 
                (
                    this.NegativeCapable == input.NegativeCapable ||
                    (this.NegativeCapable != null &&
                    this.NegativeCapable.Equals(input.NegativeCapable))
                ) && 
                (
                    this.MessageVersion == input.MessageVersion ||
                    (this.MessageVersion != null &&
                    this.MessageVersion.Equals(input.MessageVersion))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
                ) && 
                (
                    this.TravelTime == input.TravelTime ||
                    (this.TravelTime != null &&
                    this.TravelTime.Equals(input.TravelTime))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.PriceFactor != null)
                    hashCode = hashCode * 59 + this.PriceFactor.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.TimePeriod != null)
                    hashCode = hashCode * 59 + this.TimePeriod.GetHashCode();
                if (this.BarLength != null)
                    hashCode = hashCode * 59 + this.BarLength.GetHashCode();
                if (this.MdAvailability != null)
                    hashCode = hashCode * 59 + this.MdAvailability.GetHashCode();
                if (this.MktDataDelay != null)
                    hashCode = hashCode * 59 + this.MktDataDelay.GetHashCode();
                if (this.OutsideRth != null)
                    hashCode = hashCode * 59 + this.OutsideRth.GetHashCode();
                if (this.TradingDayDuration != null)
                    hashCode = hashCode * 59 + this.TradingDayDuration.GetHashCode();
                if (this.VolumeFactor != null)
                    hashCode = hashCode * 59 + this.VolumeFactor.GetHashCode();
                if (this.PriceDisplayRule != null)
                    hashCode = hashCode * 59 + this.PriceDisplayRule.GetHashCode();
                if (this.PriceDisplayValue != null)
                    hashCode = hashCode * 59 + this.PriceDisplayValue.GetHashCode();
                if (this.NegativeCapable != null)
                    hashCode = hashCode * 59 + this.NegativeCapable.GetHashCode();
                if (this.MessageVersion != null)
                    hashCode = hashCode * 59 + this.MessageVersion.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.TravelTime != null)
                    hashCode = hashCode * 59 + this.TravelTime.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

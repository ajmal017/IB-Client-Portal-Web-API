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
    /// Contains all details of the contract, including rules you can use when placing orders
    /// </summary>
    [DataContract]
    public partial class Contract :  IEquatable<Contract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// </summary>
        /// <param name="rTH">true means you can trade outside RTH(regular trading hours).</param>
        /// <param name="conId">same as that in request.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="exchange">exchange.</param>
        /// <param name="localSymbol">for exmple FB.</param>
        /// <param name="instrumentType">for example STK.</param>
        /// <param name="currency">currency.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="category">category.</param>
        /// <param name="industry">industry.</param>
        /// <param name="rules">rules.</param>
        public Contract(bool? rTH = default(bool?), string conId = default(string), string companyName = default(string), string exchange = default(string), string localSymbol = default(string), string instrumentType = default(string), string currency = default(string), string companyName2 = default(string), string category = default(string), string industry = default(string), Object rules = default(Object))
        {
            this.RTH = rTH;
            this.ConId = conId;
            this.CompanyName = companyName;
            this.Exchange = exchange;
            this.LocalSymbol = localSymbol;
            this.InstrumentType = instrumentType;
            this.Currency = currency;
            this.CompanyName2 = companyName2;
            this.Category = category;
            this.Industry = industry;
            this.Rules = rules;
        }
        
        /// <summary>
        /// true means you can trade outside RTH(regular trading hours)
        /// </summary>
        /// <value>true means you can trade outside RTH(regular trading hours)</value>
        [DataMember(Name="r_t_h", EmitDefaultValue=false)]
        public bool? RTH { get; set; }

        /// <summary>
        /// same as that in request
        /// </summary>
        /// <value>same as that in request</value>
        [DataMember(Name="con_id", EmitDefaultValue=false)]
        public string ConId { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// for exmple FB
        /// </summary>
        /// <value>for exmple FB</value>
        [DataMember(Name="local_symbol", EmitDefaultValue=false)]
        public string LocalSymbol { get; set; }

        /// <summary>
        /// for example STK
        /// </summary>
        /// <value>for example STK</value>
        [DataMember(Name="instrument_type", EmitDefaultValue=false)]
        public string InstrumentType { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName2 { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public Object Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
            sb.Append("  RTH: ").Append(RTH).Append("\n");
            sb.Append("  ConId: ").Append(ConId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  LocalSymbol: ").Append(LocalSymbol).Append("\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName2).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return this.Equals(input as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="input">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RTH == input.RTH ||
                    (this.RTH != null &&
                    this.RTH.Equals(input.RTH))
                ) && 
                (
                    this.ConId == input.ConId ||
                    (this.ConId != null &&
                    this.ConId.Equals(input.ConId))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.LocalSymbol == input.LocalSymbol ||
                    (this.LocalSymbol != null &&
                    this.LocalSymbol.Equals(input.LocalSymbol))
                ) && 
                (
                    this.InstrumentType == input.InstrumentType ||
                    (this.InstrumentType != null &&
                    this.InstrumentType.Equals(input.InstrumentType))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CompanyName2 == input.CompanyName2 ||
                    (this.CompanyName2 != null &&
                    this.CompanyName2.Equals(input.CompanyName2))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
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
                if (this.RTH != null)
                    hashCode = hashCode * 59 + this.RTH.GetHashCode();
                if (this.ConId != null)
                    hashCode = hashCode * 59 + this.ConId.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.LocalSymbol != null)
                    hashCode = hashCode * 59 + this.LocalSymbol.GetHashCode();
                if (this.InstrumentType != null)
                    hashCode = hashCode * 59 + this.InstrumentType.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CompanyName2 != null)
                    hashCode = hashCode * 59 + this.CompanyName2.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
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

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
    /// account information
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="accountVan">accountVan.</param>
        /// <param name="accountTitle">accountTitle.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="accountAlias">accountAlias.</param>
        /// <param name="accountStatus">accountStatus.</param>
        /// <param name="currency">currency.</param>
        /// <param name="type">type.</param>
        /// <param name="tradingType">tradingType.</param>
        /// <param name="faclient">faclient.</param>
        /// <param name="parent">parent.</param>
        /// <param name="desc">desc.</param>
        /// <param name="covestor">covestor.</param>
        /// <param name="master">master.</param>
        public Account(string id = default(string), string accountId = default(string), string accountVan = default(string), string accountTitle = default(string), string displayName = default(string), string accountAlias = default(string), decimal? accountStatus = default(decimal?), string currency = default(string), string type = default(string), string tradingType = default(string), bool? faclient = default(bool?), string parent = default(string), string desc = default(string), bool? covestor = default(bool?), Object master = default(Object))
        {
            this.Id = id;
            this.AccountId = accountId;
            this.AccountVan = accountVan;
            this.AccountTitle = accountTitle;
            this.DisplayName = displayName;
            this.AccountAlias = accountAlias;
            this.AccountStatus = accountStatus;
            this.Currency = currency;
            this.Type = type;
            this.TradingType = tradingType;
            this.Faclient = faclient;
            this.Parent = parent;
            this.Desc = desc;
            this.Covestor = covestor;
            this.Master = master;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AccountVan
        /// </summary>
        [DataMember(Name="accountVan", EmitDefaultValue=false)]
        public string AccountVan { get; set; }

        /// <summary>
        /// Gets or Sets AccountTitle
        /// </summary>
        [DataMember(Name="accountTitle", EmitDefaultValue=false)]
        public string AccountTitle { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets AccountAlias
        /// </summary>
        [DataMember(Name="accountAlias", EmitDefaultValue=false)]
        public string AccountAlias { get; set; }

        /// <summary>
        /// Gets or Sets AccountStatus
        /// </summary>
        [DataMember(Name="accountStatus", EmitDefaultValue=false)]
        public decimal? AccountStatus { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TradingType
        /// </summary>
        [DataMember(Name="tradingType", EmitDefaultValue=false)]
        public string TradingType { get; set; }

        /// <summary>
        /// Gets or Sets Faclient
        /// </summary>
        [DataMember(Name="faclient", EmitDefaultValue=false)]
        public bool? Faclient { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public string Parent { get; set; }

        /// <summary>
        /// Gets or Sets Desc
        /// </summary>
        [DataMember(Name="desc", EmitDefaultValue=false)]
        public string Desc { get; set; }

        /// <summary>
        /// Gets or Sets Covestor
        /// </summary>
        [DataMember(Name="covestor", EmitDefaultValue=false)]
        public bool? Covestor { get; set; }

        /// <summary>
        /// Gets or Sets Master
        /// </summary>
        [DataMember(Name="master", EmitDefaultValue=false)]
        public Object Master { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountVan: ").Append(AccountVan).Append("\n");
            sb.Append("  AccountTitle: ").Append(AccountTitle).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  AccountAlias: ").Append(AccountAlias).Append("\n");
            sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TradingType: ").Append(TradingType).Append("\n");
            sb.Append("  Faclient: ").Append(Faclient).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  Covestor: ").Append(Covestor).Append("\n");
            sb.Append("  Master: ").Append(Master).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountVan == input.AccountVan ||
                    (this.AccountVan != null &&
                    this.AccountVan.Equals(input.AccountVan))
                ) && 
                (
                    this.AccountTitle == input.AccountTitle ||
                    (this.AccountTitle != null &&
                    this.AccountTitle.Equals(input.AccountTitle))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.AccountAlias == input.AccountAlias ||
                    (this.AccountAlias != null &&
                    this.AccountAlias.Equals(input.AccountAlias))
                ) && 
                (
                    this.AccountStatus == input.AccountStatus ||
                    (this.AccountStatus != null &&
                    this.AccountStatus.Equals(input.AccountStatus))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TradingType == input.TradingType ||
                    (this.TradingType != null &&
                    this.TradingType.Equals(input.TradingType))
                ) && 
                (
                    this.Faclient == input.Faclient ||
                    (this.Faclient != null &&
                    this.Faclient.Equals(input.Faclient))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.Covestor == input.Covestor ||
                    (this.Covestor != null &&
                    this.Covestor.Equals(input.Covestor))
                ) && 
                (
                    this.Master == input.Master ||
                    (this.Master != null &&
                    this.Master.Equals(input.Master))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountVan != null)
                    hashCode = hashCode * 59 + this.AccountVan.GetHashCode();
                if (this.AccountTitle != null)
                    hashCode = hashCode * 59 + this.AccountTitle.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.AccountAlias != null)
                    hashCode = hashCode * 59 + this.AccountAlias.GetHashCode();
                if (this.AccountStatus != null)
                    hashCode = hashCode * 59 + this.AccountStatus.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TradingType != null)
                    hashCode = hashCode * 59 + this.TradingType.GetHashCode();
                if (this.Faclient != null)
                    hashCode = hashCode * 59 + this.Faclient.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.Desc != null)
                    hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.Covestor != null)
                    hashCode = hashCode * 59 + this.Covestor.GetHashCode();
                if (this.Master != null)
                    hashCode = hashCode * 59 + this.Master.GetHashCode();
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

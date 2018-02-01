/* 
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  [View Changelog](/app/apiChangelog)    #### Getting Started   ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](https://www.bitmex.com/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)    ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
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
    /// Exchange Statistics
    /// </summary>
    [DataContract]
    public partial class Stats :  IEquatable<Stats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Stats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Stats" /> class.
        /// </summary>
        /// <param name="RootSymbol">RootSymbol (required).</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Volume24h">Volume24h.</param>
        /// <param name="Turnover24h">Turnover24h.</param>
        /// <param name="OpenInterest">OpenInterest.</param>
        /// <param name="OpenValue">OpenValue.</param>
        public Stats(string RootSymbol = default(string), string Currency = default(string), decimal? Volume24h = default(decimal?), decimal? Turnover24h = default(decimal?), decimal? OpenInterest = default(decimal?), decimal? OpenValue = default(decimal?))
        {
            // to ensure "RootSymbol" is required (not null)
            if (RootSymbol == null)
            {
                throw new InvalidDataException("RootSymbol is a required property for Stats and cannot be null");
            }
            else
            {
                this.RootSymbol = RootSymbol;
            }
            this.Currency = Currency;
            this.Volume24h = Volume24h;
            this.Turnover24h = Turnover24h;
            this.OpenInterest = OpenInterest;
            this.OpenValue = OpenValue;
        }
        
        /// <summary>
        /// Gets or Sets RootSymbol
        /// </summary>
        [DataMember(Name="rootSymbol", EmitDefaultValue=false)]
        public string RootSymbol { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Volume24h
        /// </summary>
        [DataMember(Name="volume24h", EmitDefaultValue=false)]
        public decimal? Volume24h { get; set; }

        /// <summary>
        /// Gets or Sets Turnover24h
        /// </summary>
        [DataMember(Name="turnover24h", EmitDefaultValue=false)]
        public decimal? Turnover24h { get; set; }

        /// <summary>
        /// Gets or Sets OpenInterest
        /// </summary>
        [DataMember(Name="openInterest", EmitDefaultValue=false)]
        public decimal? OpenInterest { get; set; }

        /// <summary>
        /// Gets or Sets OpenValue
        /// </summary>
        [DataMember(Name="openValue", EmitDefaultValue=false)]
        public decimal? OpenValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stats {\n");
            sb.Append("  RootSymbol: ").Append(RootSymbol).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Volume24h: ").Append(Volume24h).Append("\n");
            sb.Append("  Turnover24h: ").Append(Turnover24h).Append("\n");
            sb.Append("  OpenInterest: ").Append(OpenInterest).Append("\n");
            sb.Append("  OpenValue: ").Append(OpenValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as Stats);
        }

        /// <summary>
        /// Returns true if Stats instances are equal
        /// </summary>
        /// <param name="input">Instance of Stats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RootSymbol == input.RootSymbol ||
                    (this.RootSymbol != null &&
                    this.RootSymbol.Equals(input.RootSymbol))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Volume24h == input.Volume24h ||
                    (this.Volume24h != null &&
                    this.Volume24h.Equals(input.Volume24h))
                ) && 
                (
                    this.Turnover24h == input.Turnover24h ||
                    (this.Turnover24h != null &&
                    this.Turnover24h.Equals(input.Turnover24h))
                ) && 
                (
                    this.OpenInterest == input.OpenInterest ||
                    (this.OpenInterest != null &&
                    this.OpenInterest.Equals(input.OpenInterest))
                ) && 
                (
                    this.OpenValue == input.OpenValue ||
                    (this.OpenValue != null &&
                    this.OpenValue.Equals(input.OpenValue))
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
                if (this.RootSymbol != null)
                    hashCode = hashCode * 59 + this.RootSymbol.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Volume24h != null)
                    hashCode = hashCode * 59 + this.Volume24h.GetHashCode();
                if (this.Turnover24h != null)
                    hashCode = hashCode * 59 + this.Turnover24h.GetHashCode();
                if (this.OpenInterest != null)
                    hashCode = hashCode * 59 + this.OpenInterest.GetHashCode();
                if (this.OpenValue != null)
                    hashCode = hashCode * 59 + this.OpenValue.GetHashCode();
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
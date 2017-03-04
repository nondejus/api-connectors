/* 
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  [Changelog](/app/apiChangelog)    #### Getting Started   ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](https://www.bitmex.com/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OrderBook
    /// </summary>
    [DataContract]
    public partial class OrderBook :  IEquatable<OrderBook>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderBook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBook" /> class.
        /// </summary>
        /// <param name="Symbol">Symbol (required).</param>
        /// <param name="Level">Level (required).</param>
        /// <param name="BidSize">BidSize.</param>
        /// <param name="BidPrice">BidPrice.</param>
        /// <param name="AskPrice">AskPrice.</param>
        /// <param name="AskSize">AskSize.</param>
        /// <param name="Timestamp">Timestamp.</param>
        public OrderBook(string Symbol = null, decimal? Level = null, decimal? BidSize = null, double? BidPrice = null, double? AskPrice = null, decimal? AskSize = null, DateTime? Timestamp = null)
        {
            // to ensure "Symbol" is required (not null)
            if (Symbol == null)
            {
                throw new InvalidDataException("Symbol is a required property for OrderBook and cannot be null");
            }
            else
            {
                this.Symbol = Symbol;
            }
            // to ensure "Level" is required (not null)
            if (Level == null)
            {
                throw new InvalidDataException("Level is a required property for OrderBook and cannot be null");
            }
            else
            {
                this.Level = Level;
            }
            this.BidSize = BidSize;
            this.BidPrice = BidPrice;
            this.AskPrice = AskPrice;
            this.AskSize = AskSize;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public decimal? Level { get; set; }
        /// <summary>
        /// Gets or Sets BidSize
        /// </summary>
        [DataMember(Name="bidSize", EmitDefaultValue=false)]
        public decimal? BidSize { get; set; }
        /// <summary>
        /// Gets or Sets BidPrice
        /// </summary>
        [DataMember(Name="bidPrice", EmitDefaultValue=false)]
        public double? BidPrice { get; set; }
        /// <summary>
        /// Gets or Sets AskPrice
        /// </summary>
        [DataMember(Name="askPrice", EmitDefaultValue=false)]
        public double? AskPrice { get; set; }
        /// <summary>
        /// Gets or Sets AskSize
        /// </summary>
        [DataMember(Name="askSize", EmitDefaultValue=false)]
        public decimal? AskSize { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderBook {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
            sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderBook);
        }

        /// <summary>
        /// Returns true if OrderBook instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderBook other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Symbol == other.Symbol ||
                    this.Symbol != null &&
                    this.Symbol.Equals(other.Symbol)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.BidSize == other.BidSize ||
                    this.BidSize != null &&
                    this.BidSize.Equals(other.BidSize)
                ) && 
                (
                    this.BidPrice == other.BidPrice ||
                    this.BidPrice != null &&
                    this.BidPrice.Equals(other.BidPrice)
                ) && 
                (
                    this.AskPrice == other.AskPrice ||
                    this.AskPrice != null &&
                    this.AskPrice.Equals(other.AskPrice)
                ) && 
                (
                    this.AskSize == other.AskSize ||
                    this.AskSize != null &&
                    this.AskSize.Equals(other.AskSize)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Symbol != null)
                    hash = hash * 59 + this.Symbol.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.BidSize != null)
                    hash = hash * 59 + this.BidSize.GetHashCode();
                if (this.BidPrice != null)
                    hash = hash * 59 + this.BidPrice.GetHashCode();
                if (this.AskPrice != null)
                    hash = hash * 59 + this.AskPrice.GetHashCode();
                if (this.AskSize != null)
                    hash = hash * 59 + this.AskSize.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                return hash;
            }
        }
    }

}

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
    /// Wallet
    /// </summary>
    [DataContract]
    public partial class Wallet :  IEquatable<Wallet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Wallet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet" /> class.
        /// </summary>
        /// <param name="Account">Account (required).</param>
        /// <param name="Currency">Currency (required).</param>
        /// <param name="PrevDeposited">PrevDeposited.</param>
        /// <param name="PrevWithdrawn">PrevWithdrawn.</param>
        /// <param name="PrevAmount">PrevAmount.</param>
        /// <param name="PrevTimestamp">PrevTimestamp.</param>
        /// <param name="DeltaDeposited">DeltaDeposited.</param>
        /// <param name="DeltaWithdrawn">DeltaWithdrawn.</param>
        /// <param name="DeltaAmount">DeltaAmount.</param>
        /// <param name="Deposited">Deposited.</param>
        /// <param name="Withdrawn">Withdrawn.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="PendingCredit">PendingCredit.</param>
        /// <param name="PendingDebit">PendingDebit.</param>
        /// <param name="ConfirmedDebit">ConfirmedDebit.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="Addr">Addr.</param>
        /// <param name="WithdrawalLock">WithdrawalLock.</param>
        public Wallet(decimal? Account = null, string Currency = null, decimal? PrevDeposited = null, decimal? PrevWithdrawn = null, decimal? PrevAmount = null, DateTime? PrevTimestamp = null, decimal? DeltaDeposited = null, decimal? DeltaWithdrawn = null, decimal? DeltaAmount = null, decimal? Deposited = null, decimal? Withdrawn = null, decimal? Amount = null, decimal? PendingCredit = null, decimal? PendingDebit = null, decimal? ConfirmedDebit = null, DateTime? Timestamp = null, string Addr = null, List<XAny> WithdrawalLock = null)
        {
            // to ensure "Account" is required (not null)
            if (Account == null)
            {
                throw new InvalidDataException("Account is a required property for Wallet and cannot be null");
            }
            else
            {
                this.Account = Account;
            }
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for Wallet and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            this.PrevDeposited = PrevDeposited;
            this.PrevWithdrawn = PrevWithdrawn;
            this.PrevAmount = PrevAmount;
            this.PrevTimestamp = PrevTimestamp;
            this.DeltaDeposited = DeltaDeposited;
            this.DeltaWithdrawn = DeltaWithdrawn;
            this.DeltaAmount = DeltaAmount;
            this.Deposited = Deposited;
            this.Withdrawn = Withdrawn;
            this.Amount = Amount;
            this.PendingCredit = PendingCredit;
            this.PendingDebit = PendingDebit;
            this.ConfirmedDebit = ConfirmedDebit;
            this.Timestamp = Timestamp;
            this.Addr = Addr;
            this.WithdrawalLock = WithdrawalLock;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public decimal? Account { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets PrevDeposited
        /// </summary>
        [DataMember(Name="prevDeposited", EmitDefaultValue=false)]
        public decimal? PrevDeposited { get; set; }
        /// <summary>
        /// Gets or Sets PrevWithdrawn
        /// </summary>
        [DataMember(Name="prevWithdrawn", EmitDefaultValue=false)]
        public decimal? PrevWithdrawn { get; set; }
        /// <summary>
        /// Gets or Sets PrevAmount
        /// </summary>
        [DataMember(Name="prevAmount", EmitDefaultValue=false)]
        public decimal? PrevAmount { get; set; }
        /// <summary>
        /// Gets or Sets PrevTimestamp
        /// </summary>
        [DataMember(Name="prevTimestamp", EmitDefaultValue=false)]
        public DateTime? PrevTimestamp { get; set; }
        /// <summary>
        /// Gets or Sets DeltaDeposited
        /// </summary>
        [DataMember(Name="deltaDeposited", EmitDefaultValue=false)]
        public decimal? DeltaDeposited { get; set; }
        /// <summary>
        /// Gets or Sets DeltaWithdrawn
        /// </summary>
        [DataMember(Name="deltaWithdrawn", EmitDefaultValue=false)]
        public decimal? DeltaWithdrawn { get; set; }
        /// <summary>
        /// Gets or Sets DeltaAmount
        /// </summary>
        [DataMember(Name="deltaAmount", EmitDefaultValue=false)]
        public decimal? DeltaAmount { get; set; }
        /// <summary>
        /// Gets or Sets Deposited
        /// </summary>
        [DataMember(Name="deposited", EmitDefaultValue=false)]
        public decimal? Deposited { get; set; }
        /// <summary>
        /// Gets or Sets Withdrawn
        /// </summary>
        [DataMember(Name="withdrawn", EmitDefaultValue=false)]
        public decimal? Withdrawn { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }
        /// <summary>
        /// Gets or Sets PendingCredit
        /// </summary>
        [DataMember(Name="pendingCredit", EmitDefaultValue=false)]
        public decimal? PendingCredit { get; set; }
        /// <summary>
        /// Gets or Sets PendingDebit
        /// </summary>
        [DataMember(Name="pendingDebit", EmitDefaultValue=false)]
        public decimal? PendingDebit { get; set; }
        /// <summary>
        /// Gets or Sets ConfirmedDebit
        /// </summary>
        [DataMember(Name="confirmedDebit", EmitDefaultValue=false)]
        public decimal? ConfirmedDebit { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets Addr
        /// </summary>
        [DataMember(Name="addr", EmitDefaultValue=false)]
        public string Addr { get; set; }
        /// <summary>
        /// Gets or Sets WithdrawalLock
        /// </summary>
        [DataMember(Name="withdrawalLock", EmitDefaultValue=false)]
        public List<XAny> WithdrawalLock { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Wallet {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PrevDeposited: ").Append(PrevDeposited).Append("\n");
            sb.Append("  PrevWithdrawn: ").Append(PrevWithdrawn).Append("\n");
            sb.Append("  PrevAmount: ").Append(PrevAmount).Append("\n");
            sb.Append("  PrevTimestamp: ").Append(PrevTimestamp).Append("\n");
            sb.Append("  DeltaDeposited: ").Append(DeltaDeposited).Append("\n");
            sb.Append("  DeltaWithdrawn: ").Append(DeltaWithdrawn).Append("\n");
            sb.Append("  DeltaAmount: ").Append(DeltaAmount).Append("\n");
            sb.Append("  Deposited: ").Append(Deposited).Append("\n");
            sb.Append("  Withdrawn: ").Append(Withdrawn).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PendingCredit: ").Append(PendingCredit).Append("\n");
            sb.Append("  PendingDebit: ").Append(PendingDebit).Append("\n");
            sb.Append("  ConfirmedDebit: ").Append(ConfirmedDebit).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Addr: ").Append(Addr).Append("\n");
            sb.Append("  WithdrawalLock: ").Append(WithdrawalLock).Append("\n");
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
            return this.Equals(obj as Wallet);
        }

        /// <summary>
        /// Returns true if Wallet instances are equal
        /// </summary>
        /// <param name="other">Instance of Wallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Wallet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.PrevDeposited == other.PrevDeposited ||
                    this.PrevDeposited != null &&
                    this.PrevDeposited.Equals(other.PrevDeposited)
                ) && 
                (
                    this.PrevWithdrawn == other.PrevWithdrawn ||
                    this.PrevWithdrawn != null &&
                    this.PrevWithdrawn.Equals(other.PrevWithdrawn)
                ) && 
                (
                    this.PrevAmount == other.PrevAmount ||
                    this.PrevAmount != null &&
                    this.PrevAmount.Equals(other.PrevAmount)
                ) && 
                (
                    this.PrevTimestamp == other.PrevTimestamp ||
                    this.PrevTimestamp != null &&
                    this.PrevTimestamp.Equals(other.PrevTimestamp)
                ) && 
                (
                    this.DeltaDeposited == other.DeltaDeposited ||
                    this.DeltaDeposited != null &&
                    this.DeltaDeposited.Equals(other.DeltaDeposited)
                ) && 
                (
                    this.DeltaWithdrawn == other.DeltaWithdrawn ||
                    this.DeltaWithdrawn != null &&
                    this.DeltaWithdrawn.Equals(other.DeltaWithdrawn)
                ) && 
                (
                    this.DeltaAmount == other.DeltaAmount ||
                    this.DeltaAmount != null &&
                    this.DeltaAmount.Equals(other.DeltaAmount)
                ) && 
                (
                    this.Deposited == other.Deposited ||
                    this.Deposited != null &&
                    this.Deposited.Equals(other.Deposited)
                ) && 
                (
                    this.Withdrawn == other.Withdrawn ||
                    this.Withdrawn != null &&
                    this.Withdrawn.Equals(other.Withdrawn)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.PendingCredit == other.PendingCredit ||
                    this.PendingCredit != null &&
                    this.PendingCredit.Equals(other.PendingCredit)
                ) && 
                (
                    this.PendingDebit == other.PendingDebit ||
                    this.PendingDebit != null &&
                    this.PendingDebit.Equals(other.PendingDebit)
                ) && 
                (
                    this.ConfirmedDebit == other.ConfirmedDebit ||
                    this.ConfirmedDebit != null &&
                    this.ConfirmedDebit.Equals(other.ConfirmedDebit)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Addr == other.Addr ||
                    this.Addr != null &&
                    this.Addr.Equals(other.Addr)
                ) && 
                (
                    this.WithdrawalLock == other.WithdrawalLock ||
                    this.WithdrawalLock != null &&
                    this.WithdrawalLock.SequenceEqual(other.WithdrawalLock)
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
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.PrevDeposited != null)
                    hash = hash * 59 + this.PrevDeposited.GetHashCode();
                if (this.PrevWithdrawn != null)
                    hash = hash * 59 + this.PrevWithdrawn.GetHashCode();
                if (this.PrevAmount != null)
                    hash = hash * 59 + this.PrevAmount.GetHashCode();
                if (this.PrevTimestamp != null)
                    hash = hash * 59 + this.PrevTimestamp.GetHashCode();
                if (this.DeltaDeposited != null)
                    hash = hash * 59 + this.DeltaDeposited.GetHashCode();
                if (this.DeltaWithdrawn != null)
                    hash = hash * 59 + this.DeltaWithdrawn.GetHashCode();
                if (this.DeltaAmount != null)
                    hash = hash * 59 + this.DeltaAmount.GetHashCode();
                if (this.Deposited != null)
                    hash = hash * 59 + this.Deposited.GetHashCode();
                if (this.Withdrawn != null)
                    hash = hash * 59 + this.Withdrawn.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.PendingCredit != null)
                    hash = hash * 59 + this.PendingCredit.GetHashCode();
                if (this.PendingDebit != null)
                    hash = hash * 59 + this.PendingDebit.GetHashCode();
                if (this.ConfirmedDebit != null)
                    hash = hash * 59 + this.ConfirmedDebit.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Addr != null)
                    hash = hash * 59 + this.Addr.GetHashCode();
                if (this.WithdrawalLock != null)
                    hash = hash * 59 + this.WithdrawalLock.GetHashCode();
                return hash;
            }
        }
    }

}

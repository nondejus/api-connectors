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
    /// UserPreferences
    /// </summary>
    [DataContract]
    public partial class UserPreferences :  IEquatable<UserPreferences>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferences" /> class.
        /// </summary>
        /// <param name="AnimationsEnabled">AnimationsEnabled.</param>
        /// <param name="AnnouncementsLastSeen">AnnouncementsLastSeen.</param>
        /// <param name="ChatChannelID">ChatChannelID.</param>
        /// <param name="ColorTheme">ColorTheme.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Debug">Debug.</param>
        /// <param name="DisableEmails">DisableEmails.</param>
        /// <param name="HideConfirmDialogs">HideConfirmDialogs.</param>
        /// <param name="HideConnectionModal">HideConnectionModal.</param>
        /// <param name="HideFromLeaderboard">HideFromLeaderboard (default to false).</param>
        /// <param name="HideNameFromLeaderboard">HideNameFromLeaderboard (default to true).</param>
        /// <param name="HideNotifications">HideNotifications.</param>
        /// <param name="Locale">Locale (default to &quot;en-US&quot;).</param>
        /// <param name="MsgsSeen">MsgsSeen.</param>
        /// <param name="OrderBookBinning">OrderBookBinning.</param>
        /// <param name="OrderBookType">OrderBookType.</param>
        /// <param name="OrderControlsPlusMinus">OrderControlsPlusMinus.</param>
        /// <param name="Sounds">Sounds.</param>
        /// <param name="StrictIPCheck">StrictIPCheck (default to false).</param>
        /// <param name="StrictTimeout">StrictTimeout (default to true).</param>
        /// <param name="TickerGroup">TickerGroup.</param>
        /// <param name="TickerPinned">TickerPinned.</param>
        /// <param name="TradeLayout">TradeLayout.</param>
        public UserPreferences(bool? AnimationsEnabled = null, DateTime? AnnouncementsLastSeen = null, double? ChatChannelID = null, string ColorTheme = null, string Currency = null, bool? Debug = null, List<string> DisableEmails = null, List<string> HideConfirmDialogs = null, bool? HideConnectionModal = null, bool? HideFromLeaderboard = null, bool? HideNameFromLeaderboard = null, List<string> HideNotifications = null, string Locale = null, List<string> MsgsSeen = null, XAny OrderBookBinning = null, string OrderBookType = null, bool? OrderControlsPlusMinus = null, List<string> Sounds = null, bool? StrictIPCheck = null, bool? StrictTimeout = null, string TickerGroup = null, bool? TickerPinned = null, string TradeLayout = null)
        {
            this.AnimationsEnabled = AnimationsEnabled;
            this.AnnouncementsLastSeen = AnnouncementsLastSeen;
            this.ChatChannelID = ChatChannelID;
            this.ColorTheme = ColorTheme;
            this.Currency = Currency;
            this.Debug = Debug;
            this.DisableEmails = DisableEmails;
            this.HideConfirmDialogs = HideConfirmDialogs;
            this.HideConnectionModal = HideConnectionModal;
            // use default value if no "HideFromLeaderboard" provided
            if (HideFromLeaderboard == null)
            {
                this.HideFromLeaderboard = false;
            }
            else
            {
                this.HideFromLeaderboard = HideFromLeaderboard;
            }
            // use default value if no "HideNameFromLeaderboard" provided
            if (HideNameFromLeaderboard == null)
            {
                this.HideNameFromLeaderboard = true;
            }
            else
            {
                this.HideNameFromLeaderboard = HideNameFromLeaderboard;
            }
            this.HideNotifications = HideNotifications;
            // use default value if no "Locale" provided
            if (Locale == null)
            {
                this.Locale = "en-US";
            }
            else
            {
                this.Locale = Locale;
            }
            this.MsgsSeen = MsgsSeen;
            this.OrderBookBinning = OrderBookBinning;
            this.OrderBookType = OrderBookType;
            this.OrderControlsPlusMinus = OrderControlsPlusMinus;
            this.Sounds = Sounds;
            // use default value if no "StrictIPCheck" provided
            if (StrictIPCheck == null)
            {
                this.StrictIPCheck = false;
            }
            else
            {
                this.StrictIPCheck = StrictIPCheck;
            }
            // use default value if no "StrictTimeout" provided
            if (StrictTimeout == null)
            {
                this.StrictTimeout = true;
            }
            else
            {
                this.StrictTimeout = StrictTimeout;
            }
            this.TickerGroup = TickerGroup;
            this.TickerPinned = TickerPinned;
            this.TradeLayout = TradeLayout;
        }
        
        /// <summary>
        /// Gets or Sets AnimationsEnabled
        /// </summary>
        [DataMember(Name="animationsEnabled", EmitDefaultValue=false)]
        public bool? AnimationsEnabled { get; set; }
        /// <summary>
        /// Gets or Sets AnnouncementsLastSeen
        /// </summary>
        [DataMember(Name="announcementsLastSeen", EmitDefaultValue=false)]
        public DateTime? AnnouncementsLastSeen { get; set; }
        /// <summary>
        /// Gets or Sets ChatChannelID
        /// </summary>
        [DataMember(Name="chatChannelID", EmitDefaultValue=false)]
        public double? ChatChannelID { get; set; }
        /// <summary>
        /// Gets or Sets ColorTheme
        /// </summary>
        [DataMember(Name="colorTheme", EmitDefaultValue=false)]
        public string ColorTheme { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets Debug
        /// </summary>
        [DataMember(Name="debug", EmitDefaultValue=false)]
        public bool? Debug { get; set; }
        /// <summary>
        /// Gets or Sets DisableEmails
        /// </summary>
        [DataMember(Name="disableEmails", EmitDefaultValue=false)]
        public List<string> DisableEmails { get; set; }
        /// <summary>
        /// Gets or Sets HideConfirmDialogs
        /// </summary>
        [DataMember(Name="hideConfirmDialogs", EmitDefaultValue=false)]
        public List<string> HideConfirmDialogs { get; set; }
        /// <summary>
        /// Gets or Sets HideConnectionModal
        /// </summary>
        [DataMember(Name="hideConnectionModal", EmitDefaultValue=false)]
        public bool? HideConnectionModal { get; set; }
        /// <summary>
        /// Gets or Sets HideFromLeaderboard
        /// </summary>
        [DataMember(Name="hideFromLeaderboard", EmitDefaultValue=false)]
        public bool? HideFromLeaderboard { get; set; }
        /// <summary>
        /// Gets or Sets HideNameFromLeaderboard
        /// </summary>
        [DataMember(Name="hideNameFromLeaderboard", EmitDefaultValue=false)]
        public bool? HideNameFromLeaderboard { get; set; }
        /// <summary>
        /// Gets or Sets HideNotifications
        /// </summary>
        [DataMember(Name="hideNotifications", EmitDefaultValue=false)]
        public List<string> HideNotifications { get; set; }
        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }
        /// <summary>
        /// Gets or Sets MsgsSeen
        /// </summary>
        [DataMember(Name="msgsSeen", EmitDefaultValue=false)]
        public List<string> MsgsSeen { get; set; }
        /// <summary>
        /// Gets or Sets OrderBookBinning
        /// </summary>
        [DataMember(Name="orderBookBinning", EmitDefaultValue=false)]
        public XAny OrderBookBinning { get; set; }
        /// <summary>
        /// Gets or Sets OrderBookType
        /// </summary>
        [DataMember(Name="orderBookType", EmitDefaultValue=false)]
        public string OrderBookType { get; set; }
        /// <summary>
        /// Gets or Sets OrderControlsPlusMinus
        /// </summary>
        [DataMember(Name="orderControlsPlusMinus", EmitDefaultValue=false)]
        public bool? OrderControlsPlusMinus { get; set; }
        /// <summary>
        /// Gets or Sets Sounds
        /// </summary>
        [DataMember(Name="sounds", EmitDefaultValue=false)]
        public List<string> Sounds { get; set; }
        /// <summary>
        /// Gets or Sets StrictIPCheck
        /// </summary>
        [DataMember(Name="strictIPCheck", EmitDefaultValue=false)]
        public bool? StrictIPCheck { get; set; }
        /// <summary>
        /// Gets or Sets StrictTimeout
        /// </summary>
        [DataMember(Name="strictTimeout", EmitDefaultValue=false)]
        public bool? StrictTimeout { get; set; }
        /// <summary>
        /// Gets or Sets TickerGroup
        /// </summary>
        [DataMember(Name="tickerGroup", EmitDefaultValue=false)]
        public string TickerGroup { get; set; }
        /// <summary>
        /// Gets or Sets TickerPinned
        /// </summary>
        [DataMember(Name="tickerPinned", EmitDefaultValue=false)]
        public bool? TickerPinned { get; set; }
        /// <summary>
        /// Gets or Sets TradeLayout
        /// </summary>
        [DataMember(Name="tradeLayout", EmitDefaultValue=false)]
        public string TradeLayout { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPreferences {\n");
            sb.Append("  AnimationsEnabled: ").Append(AnimationsEnabled).Append("\n");
            sb.Append("  AnnouncementsLastSeen: ").Append(AnnouncementsLastSeen).Append("\n");
            sb.Append("  ChatChannelID: ").Append(ChatChannelID).Append("\n");
            sb.Append("  ColorTheme: ").Append(ColorTheme).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Debug: ").Append(Debug).Append("\n");
            sb.Append("  DisableEmails: ").Append(DisableEmails).Append("\n");
            sb.Append("  HideConfirmDialogs: ").Append(HideConfirmDialogs).Append("\n");
            sb.Append("  HideConnectionModal: ").Append(HideConnectionModal).Append("\n");
            sb.Append("  HideFromLeaderboard: ").Append(HideFromLeaderboard).Append("\n");
            sb.Append("  HideNameFromLeaderboard: ").Append(HideNameFromLeaderboard).Append("\n");
            sb.Append("  HideNotifications: ").Append(HideNotifications).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  MsgsSeen: ").Append(MsgsSeen).Append("\n");
            sb.Append("  OrderBookBinning: ").Append(OrderBookBinning).Append("\n");
            sb.Append("  OrderBookType: ").Append(OrderBookType).Append("\n");
            sb.Append("  OrderControlsPlusMinus: ").Append(OrderControlsPlusMinus).Append("\n");
            sb.Append("  Sounds: ").Append(Sounds).Append("\n");
            sb.Append("  StrictIPCheck: ").Append(StrictIPCheck).Append("\n");
            sb.Append("  StrictTimeout: ").Append(StrictTimeout).Append("\n");
            sb.Append("  TickerGroup: ").Append(TickerGroup).Append("\n");
            sb.Append("  TickerPinned: ").Append(TickerPinned).Append("\n");
            sb.Append("  TradeLayout: ").Append(TradeLayout).Append("\n");
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
            return this.Equals(obj as UserPreferences);
        }

        /// <summary>
        /// Returns true if UserPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of UserPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnimationsEnabled == other.AnimationsEnabled ||
                    this.AnimationsEnabled != null &&
                    this.AnimationsEnabled.Equals(other.AnimationsEnabled)
                ) && 
                (
                    this.AnnouncementsLastSeen == other.AnnouncementsLastSeen ||
                    this.AnnouncementsLastSeen != null &&
                    this.AnnouncementsLastSeen.Equals(other.AnnouncementsLastSeen)
                ) && 
                (
                    this.ChatChannelID == other.ChatChannelID ||
                    this.ChatChannelID != null &&
                    this.ChatChannelID.Equals(other.ChatChannelID)
                ) && 
                (
                    this.ColorTheme == other.ColorTheme ||
                    this.ColorTheme != null &&
                    this.ColorTheme.Equals(other.ColorTheme)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Debug == other.Debug ||
                    this.Debug != null &&
                    this.Debug.Equals(other.Debug)
                ) && 
                (
                    this.DisableEmails == other.DisableEmails ||
                    this.DisableEmails != null &&
                    this.DisableEmails.SequenceEqual(other.DisableEmails)
                ) && 
                (
                    this.HideConfirmDialogs == other.HideConfirmDialogs ||
                    this.HideConfirmDialogs != null &&
                    this.HideConfirmDialogs.SequenceEqual(other.HideConfirmDialogs)
                ) && 
                (
                    this.HideConnectionModal == other.HideConnectionModal ||
                    this.HideConnectionModal != null &&
                    this.HideConnectionModal.Equals(other.HideConnectionModal)
                ) && 
                (
                    this.HideFromLeaderboard == other.HideFromLeaderboard ||
                    this.HideFromLeaderboard != null &&
                    this.HideFromLeaderboard.Equals(other.HideFromLeaderboard)
                ) && 
                (
                    this.HideNameFromLeaderboard == other.HideNameFromLeaderboard ||
                    this.HideNameFromLeaderboard != null &&
                    this.HideNameFromLeaderboard.Equals(other.HideNameFromLeaderboard)
                ) && 
                (
                    this.HideNotifications == other.HideNotifications ||
                    this.HideNotifications != null &&
                    this.HideNotifications.SequenceEqual(other.HideNotifications)
                ) && 
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) && 
                (
                    this.MsgsSeen == other.MsgsSeen ||
                    this.MsgsSeen != null &&
                    this.MsgsSeen.SequenceEqual(other.MsgsSeen)
                ) && 
                (
                    this.OrderBookBinning == other.OrderBookBinning ||
                    this.OrderBookBinning != null &&
                    this.OrderBookBinning.Equals(other.OrderBookBinning)
                ) && 
                (
                    this.OrderBookType == other.OrderBookType ||
                    this.OrderBookType != null &&
                    this.OrderBookType.Equals(other.OrderBookType)
                ) && 
                (
                    this.OrderControlsPlusMinus == other.OrderControlsPlusMinus ||
                    this.OrderControlsPlusMinus != null &&
                    this.OrderControlsPlusMinus.Equals(other.OrderControlsPlusMinus)
                ) && 
                (
                    this.Sounds == other.Sounds ||
                    this.Sounds != null &&
                    this.Sounds.SequenceEqual(other.Sounds)
                ) && 
                (
                    this.StrictIPCheck == other.StrictIPCheck ||
                    this.StrictIPCheck != null &&
                    this.StrictIPCheck.Equals(other.StrictIPCheck)
                ) && 
                (
                    this.StrictTimeout == other.StrictTimeout ||
                    this.StrictTimeout != null &&
                    this.StrictTimeout.Equals(other.StrictTimeout)
                ) && 
                (
                    this.TickerGroup == other.TickerGroup ||
                    this.TickerGroup != null &&
                    this.TickerGroup.Equals(other.TickerGroup)
                ) && 
                (
                    this.TickerPinned == other.TickerPinned ||
                    this.TickerPinned != null &&
                    this.TickerPinned.Equals(other.TickerPinned)
                ) && 
                (
                    this.TradeLayout == other.TradeLayout ||
                    this.TradeLayout != null &&
                    this.TradeLayout.Equals(other.TradeLayout)
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
                if (this.AnimationsEnabled != null)
                    hash = hash * 59 + this.AnimationsEnabled.GetHashCode();
                if (this.AnnouncementsLastSeen != null)
                    hash = hash * 59 + this.AnnouncementsLastSeen.GetHashCode();
                if (this.ChatChannelID != null)
                    hash = hash * 59 + this.ChatChannelID.GetHashCode();
                if (this.ColorTheme != null)
                    hash = hash * 59 + this.ColorTheme.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Debug != null)
                    hash = hash * 59 + this.Debug.GetHashCode();
                if (this.DisableEmails != null)
                    hash = hash * 59 + this.DisableEmails.GetHashCode();
                if (this.HideConfirmDialogs != null)
                    hash = hash * 59 + this.HideConfirmDialogs.GetHashCode();
                if (this.HideConnectionModal != null)
                    hash = hash * 59 + this.HideConnectionModal.GetHashCode();
                if (this.HideFromLeaderboard != null)
                    hash = hash * 59 + this.HideFromLeaderboard.GetHashCode();
                if (this.HideNameFromLeaderboard != null)
                    hash = hash * 59 + this.HideNameFromLeaderboard.GetHashCode();
                if (this.HideNotifications != null)
                    hash = hash * 59 + this.HideNotifications.GetHashCode();
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                if (this.MsgsSeen != null)
                    hash = hash * 59 + this.MsgsSeen.GetHashCode();
                if (this.OrderBookBinning != null)
                    hash = hash * 59 + this.OrderBookBinning.GetHashCode();
                if (this.OrderBookType != null)
                    hash = hash * 59 + this.OrderBookType.GetHashCode();
                if (this.OrderControlsPlusMinus != null)
                    hash = hash * 59 + this.OrderControlsPlusMinus.GetHashCode();
                if (this.Sounds != null)
                    hash = hash * 59 + this.Sounds.GetHashCode();
                if (this.StrictIPCheck != null)
                    hash = hash * 59 + this.StrictIPCheck.GetHashCode();
                if (this.StrictTimeout != null)
                    hash = hash * 59 + this.StrictTimeout.GetHashCode();
                if (this.TickerGroup != null)
                    hash = hash * 59 + this.TickerGroup.GetHashCode();
                if (this.TickerPinned != null)
                    hash = hash * 59 + this.TickerPinned.GetHashCode();
                if (this.TradeLayout != null)
                    hash = hash * 59 + this.TradeLayout.GetHashCode();
                return hash;
            }
        }
    }

}

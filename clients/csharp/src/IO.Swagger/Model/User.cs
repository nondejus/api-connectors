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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="OwnerId">OwnerId.</param>
        /// <param name="Firstname">Firstname.</param>
        /// <param name="Lastname">Lastname.</param>
        /// <param name="Username">Username (required).</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Created">Created.</param>
        /// <param name="LastUpdated">LastUpdated.</param>
        /// <param name="Preferences">Preferences.</param>
        /// <param name="TFAEnabled">TFAEnabled.</param>
        /// <param name="AffiliateID">AffiliateID.</param>
        /// <param name="PgpPubKey">PgpPubKey.</param>
        /// <param name="Country">Country.</param>
        public User(decimal? Id = null, decimal? OwnerId = null, string Firstname = null, string Lastname = null, string Username = null, string Email = null, string Phone = null, DateTime? Created = null, DateTime? LastUpdated = null, UserPreferences Preferences = null, string TFAEnabled = null, string AffiliateID = null, string PgpPubKey = null, string Country = null)
        {
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for User and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for User and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.Id = Id;
            this.OwnerId = OwnerId;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Phone = Phone;
            this.Created = Created;
            this.LastUpdated = LastUpdated;
            this.Preferences = Preferences;
            this.TFAEnabled = TFAEnabled;
            this.AffiliateID = AffiliateID;
            this.PgpPubKey = PgpPubKey;
            this.Country = Country;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }
        /// <summary>
        /// Gets or Sets OwnerId
        /// </summary>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public decimal? OwnerId { get; set; }
        /// <summary>
        /// Gets or Sets Firstname
        /// </summary>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }
        /// <summary>
        /// Gets or Sets Lastname
        /// </summary>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name="lastUpdated", EmitDefaultValue=false)]
        public DateTime? LastUpdated { get; set; }
        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public UserPreferences Preferences { get; set; }
        /// <summary>
        /// Gets or Sets TFAEnabled
        /// </summary>
        [DataMember(Name="TFAEnabled", EmitDefaultValue=false)]
        public string TFAEnabled { get; set; }
        /// <summary>
        /// Gets or Sets AffiliateID
        /// </summary>
        [DataMember(Name="affiliateID", EmitDefaultValue=false)]
        public string AffiliateID { get; set; }
        /// <summary>
        /// Gets or Sets PgpPubKey
        /// </summary>
        [DataMember(Name="pgpPubKey", EmitDefaultValue=false)]
        public string PgpPubKey { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  TFAEnabled: ").Append(TFAEnabled).Append("\n");
            sb.Append("  AffiliateID: ").Append(AffiliateID).Append("\n");
            sb.Append("  PgpPubKey: ").Append(PgpPubKey).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.OwnerId == other.OwnerId ||
                    this.OwnerId != null &&
                    this.OwnerId.Equals(other.OwnerId)
                ) && 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.LastUpdated == other.LastUpdated ||
                    this.LastUpdated != null &&
                    this.LastUpdated.Equals(other.LastUpdated)
                ) && 
                (
                    this.Preferences == other.Preferences ||
                    this.Preferences != null &&
                    this.Preferences.Equals(other.Preferences)
                ) && 
                (
                    this.TFAEnabled == other.TFAEnabled ||
                    this.TFAEnabled != null &&
                    this.TFAEnabled.Equals(other.TFAEnabled)
                ) && 
                (
                    this.AffiliateID == other.AffiliateID ||
                    this.AffiliateID != null &&
                    this.AffiliateID.Equals(other.AffiliateID)
                ) && 
                (
                    this.PgpPubKey == other.PgpPubKey ||
                    this.PgpPubKey != null &&
                    this.PgpPubKey.Equals(other.PgpPubKey)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.OwnerId != null)
                    hash = hash * 59 + this.OwnerId.GetHashCode();
                if (this.Firstname != null)
                    hash = hash * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hash = hash * 59 + this.Lastname.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.LastUpdated != null)
                    hash = hash * 59 + this.LastUpdated.GetHashCode();
                if (this.Preferences != null)
                    hash = hash * 59 + this.Preferences.GetHashCode();
                if (this.TFAEnabled != null)
                    hash = hash * 59 + this.TFAEnabled.GetHashCode();
                if (this.AffiliateID != null)
                    hash = hash * 59 + this.AffiliateID.GetHashCode();
                if (this.PgpPubKey != null)
                    hash = hash * 59 + this.PgpPubKey.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                return hash;
            }
        }
    }

}

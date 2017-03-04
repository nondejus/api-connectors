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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' UserApi
            Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        
        /// <summary>
        /// Test UserCancelWithdrawal
        /// </summary>
        [Test]
        public void UserCancelWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.UserCancelWithdrawal(token);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test UserCheckReferralCode
        /// </summary>
        [Test]
        public void UserCheckReferralCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string referralCode = null;
            //var response = instance.UserCheckReferralCode(referralCode);
            //Assert.IsInstanceOf<double?> (response, "response is double?");
        }
        
        /// <summary>
        /// Test UserConfirm
        /// </summary>
        [Test]
        public void UserConfirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.UserConfirm(token);
            //Assert.IsInstanceOf<AccessToken> (response, "response is AccessToken");
        }
        
        /// <summary>
        /// Test UserConfirmEnableTFA
        /// </summary>
        [Test]
        public void UserConfirmEnableTFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string type = null;
            //var response = instance.UserConfirmEnableTFA(token, type);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserConfirmWithdrawal
        /// </summary>
        [Test]
        public void UserConfirmWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.UserConfirmWithdrawal(token);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test UserDisableTFA
        /// </summary>
        [Test]
        public void UserDisableTFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //string type = null;
            //var response = instance.UserDisableTFA(token, type);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserGet
        /// </summary>
        [Test]
        public void UserGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGet();
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test UserGetAffiliateStatus
        /// </summary>
        [Test]
        public void UserGetAffiliateStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGetAffiliateStatus();
            //Assert.IsInstanceOf<List<Affiliate>> (response, "response is List<Affiliate>");
        }
        
        /// <summary>
        /// Test UserGetCommission
        /// </summary>
        [Test]
        public void UserGetCommissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGetCommission();
            //Assert.IsInstanceOf<List<UserCommission>> (response, "response is List<UserCommission>");
        }
        
        /// <summary>
        /// Test UserGetDepositAddress
        /// </summary>
        [Test]
        public void UserGetDepositAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetDepositAddress(currency);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test UserGetMargin
        /// </summary>
        [Test]
        public void UserGetMarginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetMargin(currency);
            //Assert.IsInstanceOf<Margin> (response, "response is Margin");
        }
        
        /// <summary>
        /// Test UserGetWallet
        /// </summary>
        [Test]
        public void UserGetWalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetWallet(currency);
            //Assert.IsInstanceOf<Wallet> (response, "response is Wallet");
        }
        
        /// <summary>
        /// Test UserGetWalletHistory
        /// </summary>
        [Test]
        public void UserGetWalletHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetWalletHistory(currency);
            //Assert.IsInstanceOf<List<Transaction>> (response, "response is List<Transaction>");
        }
        
        /// <summary>
        /// Test UserGetWalletSummary
        /// </summary>
        [Test]
        public void UserGetWalletSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserGetWalletSummary(currency);
            //Assert.IsInstanceOf<List<Transaction>> (response, "response is List<Transaction>");
        }
        
        /// <summary>
        /// Test UserLogout
        /// </summary>
        [Test]
        public void UserLogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.UserLogout();
            
        }
        
        /// <summary>
        /// Test UserLogoutAll
        /// </summary>
        [Test]
        public void UserLogoutAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserLogoutAll();
            //Assert.IsInstanceOf<double?> (response, "response is double?");
        }
        
        /// <summary>
        /// Test UserMinWithdrawalFee
        /// </summary>
        [Test]
        public void UserMinWithdrawalFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.UserMinWithdrawalFee(currency);
            //Assert.IsInstanceOf<double?> (response, "response is double?");
        }
        
        /// <summary>
        /// Test UserRequestEnableTFA
        /// </summary>
        [Test]
        public void UserRequestEnableTFATest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //var response = instance.UserRequestEnableTFA(type);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test UserRequestWithdrawal
        /// </summary>
        [Test]
        public void UserRequestWithdrawalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //decimal? amount = null;
            //string address = null;
            //string otpToken = null;
            //double? fee = null;
            //var response = instance.UserRequestWithdrawal(currency, amount, address, otpToken, fee);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test UserSavePreferences
        /// </summary>
        [Test]
        public void UserSavePreferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string prefs = null;
            //bool? overwrite = null;
            //var response = instance.UserSavePreferences(prefs, overwrite);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test UserUpdate
        /// </summary>
        [Test]
        public void UserUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string firstname = null;
            //string lastname = null;
            //string oldPassword = null;
            //string newPassword = null;
            //string newPasswordConfirm = null;
            //string username = null;
            //string country = null;
            //string pgpPubKey = null;
            //var response = instance.UserUpdate(firstname, lastname, oldPassword, newPassword, newPasswordConfirm, username, country, pgpPubKey);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
    }

}

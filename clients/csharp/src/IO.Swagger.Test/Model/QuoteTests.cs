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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Quote
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class QuoteTests
    {
        // TODO uncomment below to declare an instance variable for Quote
        //private Quote instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Quote
            //instance = new Quote();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Quote
        /// </summary>
        [Test]
        public void QuoteInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Quote
            //Assert.IsInstanceOfType<Quote> (instance, "variable 'instance' is a Quote");
        }

        /// <summary>
        /// Test the property 'Timestamp'
        /// </summary>
        [Test]
        public void TimestampTest()
        {
            // TODO unit test for the property 'Timestamp'
        }
        /// <summary>
        /// Test the property 'Symbol'
        /// </summary>
        [Test]
        public void SymbolTest()
        {
            // TODO unit test for the property 'Symbol'
        }
        /// <summary>
        /// Test the property 'BidSize'
        /// </summary>
        [Test]
        public void BidSizeTest()
        {
            // TODO unit test for the property 'BidSize'
        }
        /// <summary>
        /// Test the property 'BidPrice'
        /// </summary>
        [Test]
        public void BidPriceTest()
        {
            // TODO unit test for the property 'BidPrice'
        }
        /// <summary>
        /// Test the property 'AskPrice'
        /// </summary>
        [Test]
        public void AskPriceTest()
        {
            // TODO unit test for the property 'AskPrice'
        }
        /// <summary>
        /// Test the property 'AskSize'
        /// </summary>
        [Test]
        public void AskSizeTest()
        {
            // TODO unit test for the property 'AskSize'
        }

    }

}

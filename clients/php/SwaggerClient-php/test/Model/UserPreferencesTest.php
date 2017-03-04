<?php
/**
 * UserPreferencesTest
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
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

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Please update the test case below to test the model.
 */

namespace Swagger\Client;

/**
 * UserPreferencesTest Class Doc Comment
 *
 * @category    Class */
// * @description UserPreferences
/**
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class UserPreferencesTest extends \PHPUnit_Framework_TestCase
{

    /**
     * Setup before running any test case
     */
    public static function setUpBeforeClass()
    {

    }

    /**
     * Setup before running each test case
     */
    public function setUp()
    {

    }

    /**
     * Clean up after running each test case
     */
    public function tearDown()
    {

    }

    /**
     * Clean up after running all test cases
     */
    public static function tearDownAfterClass()
    {

    }

    /**
     * Test "UserPreferences"
     */
    public function testUserPreferences()
    {

    }

    /**
     * Test attribute "animations_enabled"
     */
    public function testPropertyAnimationsEnabled()
    {

    }

    /**
     * Test attribute "announcements_last_seen"
     */
    public function testPropertyAnnouncementsLastSeen()
    {

    }

    /**
     * Test attribute "chat_channel_id"
     */
    public function testPropertyChatChannelID()
    {

    }

    /**
     * Test attribute "color_theme"
     */
    public function testPropertyColorTheme()
    {

    }

    /**
     * Test attribute "currency"
     */
    public function testPropertyCurrency()
    {

    }

    /**
     * Test attribute "debug"
     */
    public function testPropertyDebug()
    {

    }

    /**
     * Test attribute "disable_emails"
     */
    public function testPropertyDisableEmails()
    {

    }

    /**
     * Test attribute "hide_confirm_dialogs"
     */
    public function testPropertyHideConfirmDialogs()
    {

    }

    /**
     * Test attribute "hide_connection_modal"
     */
    public function testPropertyHideConnectionModal()
    {

    }

    /**
     * Test attribute "hide_from_leaderboard"
     */
    public function testPropertyHideFromLeaderboard()
    {

    }

    /**
     * Test attribute "hide_name_from_leaderboard"
     */
    public function testPropertyHideNameFromLeaderboard()
    {

    }

    /**
     * Test attribute "hide_notifications"
     */
    public function testPropertyHideNotifications()
    {

    }

    /**
     * Test attribute "locale"
     */
    public function testPropertyLocale()
    {

    }

    /**
     * Test attribute "msgs_seen"
     */
    public function testPropertyMsgsSeen()
    {

    }

    /**
     * Test attribute "order_book_binning"
     */
    public function testPropertyOrderBookBinning()
    {

    }

    /**
     * Test attribute "order_book_type"
     */
    public function testPropertyOrderBookType()
    {

    }

    /**
     * Test attribute "order_controls_plus_minus"
     */
    public function testPropertyOrderControlsPlusMinus()
    {

    }

    /**
     * Test attribute "sounds"
     */
    public function testPropertySounds()
    {

    }

    /**
     * Test attribute "strict_ip_check"
     */
    public function testPropertyStrictIPCheck()
    {

    }

    /**
     * Test attribute "strict_timeout"
     */
    public function testPropertyStrictTimeout()
    {

    }

    /**
     * Test attribute "ticker_group"
     */
    public function testPropertyTickerGroup()
    {

    }

    /**
     * Test attribute "ticker_pinned"
     */
    public function testPropertyTickerPinned()
    {

    }

    /**
     * Test attribute "trade_layout"
     */
    public function testPropertyTradeLayout()
    {

    }

}

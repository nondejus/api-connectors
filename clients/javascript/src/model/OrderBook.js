/**
 * BitMEX API
 * ## REST API for the BitMEX Trading Platform  [Changelog](/app/apiChangelog)    #### Getting Started   ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](https://www.bitmex.com/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.BitMexApi) {
      root.BitMexApi = {};
    }
    root.BitMexApi.OrderBook = factory(root.BitMexApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The OrderBook model module.
   * @module model/OrderBook
   * @version 1.2.0
   */

  /**
   * Constructs a new <code>OrderBook</code>.
   * @alias module:model/OrderBook
   * @class
   * @param symbol {String} 
   * @param level {Number} 
   */
  var exports = function(symbol, level) {
    var _this = this;

    _this['symbol'] = symbol;
    _this['level'] = level;





  };

  /**
   * Constructs a <code>OrderBook</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/OrderBook} obj Optional instance to populate.
   * @return {module:model/OrderBook} The populated <code>OrderBook</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('symbol')) {
        obj['symbol'] = ApiClient.convertToType(data['symbol'], 'String');
      }
      if (data.hasOwnProperty('level')) {
        obj['level'] = ApiClient.convertToType(data['level'], 'Number');
      }
      if (data.hasOwnProperty('bidSize')) {
        obj['bidSize'] = ApiClient.convertToType(data['bidSize'], 'Number');
      }
      if (data.hasOwnProperty('bidPrice')) {
        obj['bidPrice'] = ApiClient.convertToType(data['bidPrice'], 'Number');
      }
      if (data.hasOwnProperty('askPrice')) {
        obj['askPrice'] = ApiClient.convertToType(data['askPrice'], 'Number');
      }
      if (data.hasOwnProperty('askSize')) {
        obj['askSize'] = ApiClient.convertToType(data['askSize'], 'Number');
      }
      if (data.hasOwnProperty('timestamp')) {
        obj['timestamp'] = ApiClient.convertToType(data['timestamp'], 'Date');
      }
    }
    return obj;
  }

  /**
   * @member {String} symbol
   */
  exports.prototype['symbol'] = undefined;
  /**
   * @member {Number} level
   */
  exports.prototype['level'] = undefined;
  /**
   * @member {Number} bidSize
   */
  exports.prototype['bidSize'] = undefined;
  /**
   * @member {Number} bidPrice
   */
  exports.prototype['bidPrice'] = undefined;
  /**
   * @member {Number} askPrice
   */
  exports.prototype['askPrice'] = undefined;
  /**
   * @member {Number} askSize
   */
  exports.prototype['askSize'] = undefined;
  /**
   * @member {Date} timestamp
   */
  exports.prototype['timestamp'] = undefined;



  return exports;
}));



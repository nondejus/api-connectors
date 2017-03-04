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
    define(['ApiClient', 'model/APIKey', 'model/Error', 'model/InlineResponse200'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/APIKey'), require('../model/Error'), require('../model/InlineResponse200'));
  } else {
    // Browser globals (root is window)
    if (!root.BitMexApi) {
      root.BitMexApi = {};
    }
    root.BitMexApi.APIKeyApi = factory(root.BitMexApi.ApiClient, root.BitMexApi.APIKey, root.BitMexApi.Error, root.BitMexApi.InlineResponse200);
  }
}(this, function(ApiClient, APIKey, Error, InlineResponse200) {
  'use strict';

  /**
   * APIKey service.
   * @module api/APIKeyApi
   * @version 1.2.0
   */

  /**
   * Constructs a new APIKeyApi. 
   * @alias module:api/APIKeyApi
   * @class
   * @param {module:ApiClient} apiClient Optional API client implementation to use,
   * default to {@link module:ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the aPIKeyDisable operation.
     * @callback module:api/APIKeyApi~aPIKeyDisableCallback
     * @param {String} error Error message, if any.
     * @param {module:model/APIKey} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Disable an API Key.
     * @param {String} apiKeyID API Key ID (public component).
     * @param {module:api/APIKeyApi~aPIKeyDisableCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/APIKey}
     */
    this.aPIKeyDisable = function(apiKeyID, callback) {
      var postBody = null;

      // verify the required parameter 'apiKeyID' is set
      if (apiKeyID == undefined || apiKeyID == null) {
        throw "Missing the required parameter 'apiKeyID' when calling aPIKeyDisable";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
        'apiKeyID': apiKeyID
      };

      var authNames = [];
      var contentTypes = ['application/json', 'application/x-www-form-urlencoded'];
      var accepts = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript'];
      var returnType = APIKey;

      return this.apiClient.callApi(
        '/apiKey/disable', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the aPIKeyEnable operation.
     * @callback module:api/APIKeyApi~aPIKeyEnableCallback
     * @param {String} error Error message, if any.
     * @param {module:model/APIKey} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Enable an API Key.
     * @param {String} apiKeyID API Key ID (public component).
     * @param {module:api/APIKeyApi~aPIKeyEnableCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/APIKey}
     */
    this.aPIKeyEnable = function(apiKeyID, callback) {
      var postBody = null;

      // verify the required parameter 'apiKeyID' is set
      if (apiKeyID == undefined || apiKeyID == null) {
        throw "Missing the required parameter 'apiKeyID' when calling aPIKeyEnable";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
        'apiKeyID': apiKeyID
      };

      var authNames = [];
      var contentTypes = ['application/json', 'application/x-www-form-urlencoded'];
      var accepts = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript'];
      var returnType = APIKey;

      return this.apiClient.callApi(
        '/apiKey/enable', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the aPIKeyGet operation.
     * @callback module:api/APIKeyApi~aPIKeyGetCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/APIKey>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get your API Keys.
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.reverse If true, will sort results newest first. (default to false)
     * @param {module:api/APIKeyApi~aPIKeyGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {Array.<module:model/APIKey>}
     */
    this.aPIKeyGet = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
        'reverse': opts['reverse']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json', 'application/x-www-form-urlencoded'];
      var accepts = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript'];
      var returnType = [APIKey];

      return this.apiClient.callApi(
        '/apiKey', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the aPIKeyNew operation.
     * @callback module:api/APIKeyApi~aPIKeyNewCallback
     * @param {String} error Error message, if any.
     * @param {module:model/APIKey} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create a new API Key.
     * API Keys can also be created via [this Python script](https://github.com/BitMEX/market-maker/blob/master/generate-api-key.py) See the [API Key Documentation](/app/apiKeys) for more information on capabilities.
     * @param {Object} opts Optional parameters
     * @param {String} opts.name Key name. This name is for reference only.
     * @param {String} opts.cidr CIDR block to restrict this key to. To restrict to a single address, append \&quot;/32\&quot;, e.g. 207.39.29.22/32. Leave blank or set to 0.0.0.0/0 to allow all IPs. Only one block may be set. &lt;a href&#x3D;\&quot;http://software77.net/cidr-101.html\&quot;&gt;More on CIDR blocks&lt;/a&gt;
     * @param {String} opts.permissions Key Permissions. All keys can read margin and position data. Additional permissions must be added. Available: [\&quot;order\&quot;, \&quot;withdraw\&quot;].
     * @param {Boolean} opts.enabled Set to true to enable this key on creation. Otherwise, it must be explicitly enabled via /apiKey/enable. (default to false)
     * @param {String} opts.token OTP Token (YubiKey, Google Authenticator)
     * @param {module:api/APIKeyApi~aPIKeyNewCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/APIKey}
     */
    this.aPIKeyNew = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
        'name': opts['name'],
        'cidr': opts['cidr'],
        'permissions': opts['permissions'],
        'enabled': opts['enabled'],
        'token': opts['token']
      };

      var authNames = [];
      var contentTypes = ['application/json', 'application/x-www-form-urlencoded'];
      var accepts = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript'];
      var returnType = APIKey;

      return this.apiClient.callApi(
        '/apiKey', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the aPIKeyRemove operation.
     * @callback module:api/APIKeyApi~aPIKeyRemoveCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponse200} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove an API Key.
     * @param {String} apiKeyID API Key ID (public component).
     * @param {module:api/APIKeyApi~aPIKeyRemoveCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponse200}
     */
    this.aPIKeyRemove = function(apiKeyID, callback) {
      var postBody = null;

      // verify the required parameter 'apiKeyID' is set
      if (apiKeyID == undefined || apiKeyID == null) {
        throw "Missing the required parameter 'apiKeyID' when calling aPIKeyRemove";
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
        'apiKeyID': apiKeyID
      };

      var authNames = [];
      var contentTypes = ['application/json', 'application/x-www-form-urlencoded'];
      var accepts = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript'];
      var returnType = InlineResponse200;

      return this.apiClient.callApi(
        '/apiKey', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));

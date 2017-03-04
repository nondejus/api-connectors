=begin
#BitMEX API

### REST API for the BitMEX Trading Platform  [Changelog](/app/apiChangelog)    #### Getting Started   ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](https://www.bitmex.com/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  -  ## All API Endpoints  Click to expand a section. 

OpenAPI spec version: 1.2.0
Contact: support@bitmex.com
Generated by: https://github.com/swagger-api/swagger-codegen.git

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

=end

require "uri"

module SwaggerClient
  class PositionApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Get your positions.
    # See <a href=\"http://www.onixs.biz/fix-dictionary/5.0.SP2/msgType_AP_6580.html\">the FIX Spec</a> for explanations of these fields.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filter Table filter. For example, send {\&quot;symbol\&quot;: \&quot;XBT24H\&quot;}.
    # @option opts [String] :columns Which columns to fetch. For example, send [\&quot;columnName\&quot;].
    # @option opts [Float] :count Number of rows to fetch.
    # @return [Array<Position>]
    def position_get(opts = {})
      data, _status_code, _headers = position_get_with_http_info(opts)
      return data
    end

    # Get your positions.
    # See &lt;a href&#x3D;\&quot;http://www.onixs.biz/fix-dictionary/5.0.SP2/msgType_AP_6580.html\&quot;&gt;the FIX Spec&lt;/a&gt; for explanations of these fields.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :filter Table filter. For example, send {\&quot;symbol\&quot;: \&quot;XBT24H\&quot;}.
    # @option opts [String] :columns Which columns to fetch. For example, send [\&quot;columnName\&quot;].
    # @option opts [Float] :count Number of rows to fetch.
    # @return [Array<(Array<Position>, Fixnum, Hash)>] Array<Position> data, response status code and response headers
    def position_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: PositionApi.position_get ..."
      end
      # resource path
      local_var_path = "/position".sub('{format}','json')

      # query parameters
      query_params = {}
      query_params[:'filter'] = opts[:'filter'] if !opts[:'filter'].nil?
      query_params[:'columns'] = opts[:'columns'] if !opts[:'columns'].nil?
      query_params[:'count'] = opts[:'count'] if !opts[:'count'].nil?

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      local_header_accept = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript']
      local_header_accept_result = @api_client.select_header_accept(local_header_accept) and header_params['Accept'] = local_header_accept_result

      # HTTP header 'Content-Type'
      local_header_content_type = ['application/json', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(local_header_content_type)

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      auth_names = []
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<Position>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionApi#position_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Enable isolated margin or cross margin per-position.
    # On Speculative (DPE-Enabled) contracts, users can switch isolate margin per-position. This function allows switching margin isolation (aka fixed margin) on and off.
    # @param symbol Position symbol to isolate.
    # @param [Hash] opts the optional parameters
    # @option opts [BOOLEAN] :enabled True for isolated margin, false for cross margin. (default to true)
    # @return [Position]
    def position_isolate_margin(symbol, opts = {})
      data, _status_code, _headers = position_isolate_margin_with_http_info(symbol, opts)
      return data
    end

    # Enable isolated margin or cross margin per-position.
    # On Speculative (DPE-Enabled) contracts, users can switch isolate margin per-position. This function allows switching margin isolation (aka fixed margin) on and off.
    # @param symbol Position symbol to isolate.
    # @param [Hash] opts the optional parameters
    # @option opts [BOOLEAN] :enabled True for isolated margin, false for cross margin.
    # @return [Array<(Position, Fixnum, Hash)>] Position data, response status code and response headers
    def position_isolate_margin_with_http_info(symbol, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: PositionApi.position_isolate_margin ..."
      end
      # verify the required parameter 'symbol' is set
      fail ArgumentError, "Missing the required parameter 'symbol' when calling PositionApi.position_isolate_margin" if symbol.nil?
      # resource path
      local_var_path = "/position/isolate".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      local_header_accept = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript']
      local_header_accept_result = @api_client.select_header_accept(local_header_accept) and header_params['Accept'] = local_header_accept_result

      # HTTP header 'Content-Type'
      local_header_content_type = ['application/json', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(local_header_content_type)

      # form parameters
      form_params = {}
      form_params["symbol"] = symbol
      form_params["enabled"] = opts[:'enabled'] if !opts[:'enabled'].nil?

      # http body (model)
      post_body = nil
      auth_names = []
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Position')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionApi#position_isolate_margin\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Transfer equity in or out of a position.
    # When margin is isolated on a position, use this function to add or remove margin from the position. Note that you cannot remove margin below the initial margin threshold.
    # @param symbol Symbol of position to isolate.
    # @param amount Amount to transfer, in Satoshis. May be negative.
    # @param [Hash] opts the optional parameters
    # @return [Position]
    def position_transfer_isolated_margin(symbol, amount, opts = {})
      data, _status_code, _headers = position_transfer_isolated_margin_with_http_info(symbol, amount, opts)
      return data
    end

    # Transfer equity in or out of a position.
    # When margin is isolated on a position, use this function to add or remove margin from the position. Note that you cannot remove margin below the initial margin threshold.
    # @param symbol Symbol of position to isolate.
    # @param amount Amount to transfer, in Satoshis. May be negative.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Position, Fixnum, Hash)>] Position data, response status code and response headers
    def position_transfer_isolated_margin_with_http_info(symbol, amount, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: PositionApi.position_transfer_isolated_margin ..."
      end
      # verify the required parameter 'symbol' is set
      fail ArgumentError, "Missing the required parameter 'symbol' when calling PositionApi.position_transfer_isolated_margin" if symbol.nil?
      # verify the required parameter 'amount' is set
      fail ArgumentError, "Missing the required parameter 'amount' when calling PositionApi.position_transfer_isolated_margin" if amount.nil?
      # resource path
      local_var_path = "/position/transferMargin".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      local_header_accept = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript']
      local_header_accept_result = @api_client.select_header_accept(local_header_accept) and header_params['Accept'] = local_header_accept_result

      # HTTP header 'Content-Type'
      local_header_content_type = ['application/json', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(local_header_content_type)

      # form parameters
      form_params = {}
      form_params["symbol"] = symbol
      form_params["amount"] = amount

      # http body (model)
      post_body = nil
      auth_names = []
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Position')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionApi#position_transfer_isolated_margin\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Choose leverage for a position.
    # On Speculative (DPE-Enabled) contracts, users can choose an isolated leverage. This will automatically enable isolated margin.
    # @param symbol Symbol of position to adjust.
    # @param leverage Leverage value. Send a number between 0.01 and 100 to enable isolated margin with a fixed leverage. Send 0 to enable cross margin.
    # @param [Hash] opts the optional parameters
    # @return [Position]
    def position_update_leverage(symbol, leverage, opts = {})
      data, _status_code, _headers = position_update_leverage_with_http_info(symbol, leverage, opts)
      return data
    end

    # Choose leverage for a position.
    # On Speculative (DPE-Enabled) contracts, users can choose an isolated leverage. This will automatically enable isolated margin.
    # @param symbol Symbol of position to adjust.
    # @param leverage Leverage value. Send a number between 0.01 and 100 to enable isolated margin with a fixed leverage. Send 0 to enable cross margin.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Position, Fixnum, Hash)>] Position data, response status code and response headers
    def position_update_leverage_with_http_info(symbol, leverage, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: PositionApi.position_update_leverage ..."
      end
      # verify the required parameter 'symbol' is set
      fail ArgumentError, "Missing the required parameter 'symbol' when calling PositionApi.position_update_leverage" if symbol.nil?
      # verify the required parameter 'leverage' is set
      fail ArgumentError, "Missing the required parameter 'leverage' when calling PositionApi.position_update_leverage" if leverage.nil?
      # resource path
      local_var_path = "/position/leverage".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      local_header_accept = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript']
      local_header_accept_result = @api_client.select_header_accept(local_header_accept) and header_params['Accept'] = local_header_accept_result

      # HTTP header 'Content-Type'
      local_header_content_type = ['application/json', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(local_header_content_type)

      # form parameters
      form_params = {}
      form_params["symbol"] = symbol
      form_params["leverage"] = leverage

      # http body (model)
      post_body = nil
      auth_names = []
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Position')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionApi#position_update_leverage\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update your risk limit.
    # Risk Limits limit the size of positions you can trade at various margin levels. Larger positions require more margin. Please see the Risk Limit documentation for more details.
    # @param symbol Symbol of position to isolate.
    # @param risk_limit New Risk Limit, in Satoshis.
    # @param [Hash] opts the optional parameters
    # @return [Position]
    def position_update_risk_limit(symbol, risk_limit, opts = {})
      data, _status_code, _headers = position_update_risk_limit_with_http_info(symbol, risk_limit, opts)
      return data
    end

    # Update your risk limit.
    # Risk Limits limit the size of positions you can trade at various margin levels. Larger positions require more margin. Please see the Risk Limit documentation for more details.
    # @param symbol Symbol of position to isolate.
    # @param risk_limit New Risk Limit, in Satoshis.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Position, Fixnum, Hash)>] Position data, response status code and response headers
    def position_update_risk_limit_with_http_info(symbol, risk_limit, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: PositionApi.position_update_risk_limit ..."
      end
      # verify the required parameter 'symbol' is set
      fail ArgumentError, "Missing the required parameter 'symbol' when calling PositionApi.position_update_risk_limit" if symbol.nil?
      # verify the required parameter 'risk_limit' is set
      fail ArgumentError, "Missing the required parameter 'risk_limit' when calling PositionApi.position_update_risk_limit" if risk_limit.nil?
      # resource path
      local_var_path = "/position/riskLimit".sub('{format}','json')

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}

      # HTTP header 'Accept' (if needed)
      local_header_accept = ['application/json', 'application/xml', 'text/xml', 'application/javascript', 'text/javascript']
      local_header_accept_result = @api_client.select_header_accept(local_header_accept) and header_params['Accept'] = local_header_accept_result

      # HTTP header 'Content-Type'
      local_header_content_type = ['application/json', 'application/x-www-form-urlencoded']
      header_params['Content-Type'] = @api_client.select_header_content_type(local_header_content_type)

      # form parameters
      form_params = {}
      form_params["symbol"] = symbol
      form_params["riskLimit"] = risk_limit

      # http body (model)
      post_body = nil
      auth_names = []
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Position')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: PositionApi#position_update_risk_limit\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end

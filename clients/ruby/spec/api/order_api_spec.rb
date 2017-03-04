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

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::OrderApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'OrderApi' do
  before do
    # run before each test
    @instance = SwaggerClient::OrderApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of OrderApi' do
    it 'should create an instact of OrderApi' do
      expect(@instance).to be_instance_of(SwaggerClient::OrderApi)
    end
  end

  # unit tests for order_amend
  # Amend the quantity or price of an open order.
  # Send an &#x60;orderID&#x60; or &#x60;origClOrdID&#x60; to identify the order you wish to amend.  Both order quantity and price can be amended. Only one &#x60;qty&#x60; field can be used to amend.  Use the &#x60;leavesQty&#x60; field to specify how much of the order you wish to remain open. This can be useful if you want to adjust your position&#39;s delta by a certain amount, regardless of how much of the order has already filled.  Use the &#x60;simpleOrderQty&#x60; and &#x60;simpleLeavesQty&#x60; fields to specify order size in Bitcoin, rather than contracts. These fields will round up to the nearest contract.  Like order placement, amending can be done in bulk. Simply send a request to &#x60;PUT /api/v1/order/bulk&#x60; with a JSON body of the shape: &#x60;{\&quot;orders\&quot;: [{...}, {...}]}&#x60;, each object containing the fields used in this endpoint. 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :order_id Order ID
  # @option opts [String] :orig_cl_ord_id Client Order ID. See POST /order.
  # @option opts [String] :cl_ord_id Optional new Client Order ID, requires &#x60;origClOrdID&#x60;.
  # @option opts [Float] :simple_order_qty Optional order quantity in units of the underlying instrument (i.e. Bitcoin).
  # @option opts [Float] :order_qty Optional order quantity in units of the instrument (i.e. contracts).
  # @option opts [Float] :simple_leaves_qty Optional leaves quantity in units of the underlying instrument (i.e. Bitcoin). Useful for amending partially filled orders.
  # @option opts [Float] :leaves_qty Optional leaves quantity in units of the instrument (i.e. contracts). Useful for amending partially filled orders.
  # @option opts [Float] :price Optional limit price for &#39;Limit&#39;, &#39;StopLimit&#39;, and &#39;LimitIfTouched&#39; orders.
  # @option opts [Float] :stop_px Optional trigger price for &#39;Stop&#39;, &#39;StopLimit&#39;, &#39;MarketIfTouched&#39;, and &#39;LimitIfTouched&#39; orders. Use a price below the current price for stop-sell orders and buy-if-touched orders.
  # @option opts [Float] :peg_offset_value Optional trailing offset from the current price for &#39;Stop&#39;, &#39;StopLimit&#39;, &#39;MarketIfTouched&#39;, and &#39;LimitIfTouched&#39; orders; use a negative offset for stop-sell orders and buy-if-touched orders. Optional offset from the peg price for &#39;Pegged&#39; orders.
  # @option opts [String] :text Optional amend annotation. e.g. &#39;Adjust skew&#39;.
  # @return [Order]
  describe 'order_amend test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_amend_bulk
  # Amend multiple orders.
  # Similar to POST /amend, but with multiple orders. &#x60;application/json&#x60; only. Ratelimited at 50%.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :orders An array of orders.
  # @return [Array<Order>]
  describe 'order_amend_bulk test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_cancel
  # Cancel order(s). Send multiple order IDs to cancel in bulk.
  # Either an orderID or a clOrdID must be provided.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :order_id Order ID(s).
  # @option opts [String] :cl_ord_id Client Order ID(s). See POST /order.
  # @option opts [String] :text Optional cancellation annotation. e.g. &#39;Spread Exceeded&#39;.
  # @return [Array<Order>]
  describe 'order_cancel test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_cancel_all
  # Cancels all of your orders.
  # 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :symbol Optional symbol. If provided, only cancels orders for that symbol.
  # @option opts [String] :filter Optional filter for cancellation. Use to only cancel some orders, e.g. &#x60;{\&quot;side\&quot;: \&quot;Buy\&quot;}&#x60;.
  # @option opts [String] :text Optional cancellation annotation. e.g. &#39;Spread Exceeded&#39;
  # @return [Object]
  describe 'order_cancel_all test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_cancel_all_after
  # Automatically cancel all your orders after a specified timeout.
  # Useful as a dead-man&#39;s switch to ensure your orders are canceled in case of an outage. If called repeatedly, the existing offset will be canceled and a new one will be inserted in its place.  Example usage: call this route at 15s intervals with an offset of 60000 (60s). If this route is not called within 60 seconds, all your orders will be automatically canceled.  This is also available via [WebSocket](https://www.bitmex.com/app/wsAPI#dead-man-s-switch-auto-cancel-). 
  # @param timeout Timeout in ms. Set to 0 to cancel this timer. 
  # @param [Hash] opts the optional parameters
  # @return [Object]
  describe 'order_cancel_all_after test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_close_position
  # Close a position. [Deprecated, use POST /order with execInst: &#39;Close&#39;]
  # If no &#x60;price&#x60; is specified, a market order will be submitted to close the whole of your position. This will also close all other open orders in this symbol.
  # @param symbol Symbol of position to close.
  # @param [Hash] opts the optional parameters
  # @option opts [Float] :price Optional limit price.
  # @return [Order]
  describe 'order_close_position test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_get_orders
  # Get your orders.
  # To get open orders only, send {\&quot;open\&quot;: true} in the filter param.  See &lt;a href&#x3D;\&quot;http://www.onixs.biz/fix-dictionary/5.0.SP2/msgType_D_68.html\&quot;&gt;the FIX Spec&lt;/a&gt; for explanations of these fields.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :symbol Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;.
  # @option opts [String] :filter Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details.
  # @option opts [String] :columns Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect.
  # @option opts [Float] :count Number of results to fetch.
  # @option opts [Float] :start Starting point for results.
  # @option opts [BOOLEAN] :reverse If true, will sort results newest first.
  # @option opts [Date] :start_time Starting date filter for results.
  # @option opts [Date] :end_time Ending date filter for results.
  # @return [Array<Order>]
  describe 'order_get_orders test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_new
  # Create a new order.
  # This endpoint is used for placing orders. Valid order types are Market, Limit, Stop, StopLimit, MarketIfTouched, LimitIfTouched, MarketWithLeftOverAsLimit, and Pegged.  If no order type is provided, BitMEX will assume &#39;Limit&#39;. Be very careful with &#39;Market&#39; and &#39;Stop&#39; orders as you may be filled at an unfavourable price.  You can submit bulk orders by POSTing an array of orders to &#x60;/api/v1/order/bulk&#x60;. Send a JSON payload with the shape: &#x60;{\&quot;orders\&quot;: [{...}, {...}]}&#x60;, with each inner object containing the same fields that would be sent to this endpoint.  A note on API tools: if you want to keep track of order IDs yourself, set a unique clOrdID per order. This clOrdID will come back as a property on the order and any related executions (including on the WebSocket), and can be used to get or cancel the order. Max length is 36 characters.  To generate a clOrdID, consider setting a prefix, and incrementing a counter or generating a UUID. Some UUIDs are longer than 36 characters, so use a url-safe base64 encoding. For example, the prefix &#x60;&#39;bmex_mm_&#39;&#x60; and the UUID &#x60;&#39;7fbd6545-bb0c-11e4-a273-6003088a7c04&#39;&#x60; creates &#x60;&#39;bmex_mm_f71lRbsMEeSic2ADCIp8BA&#39;&#x60;.  See the [BitMEX Reference Market Maker](https://github.com/BitMEX/market-maker/blob/22c75a2b6db63e20212813e9afdb845db1b09b2a/bitmex.py#L152) for an example of how to use and generate clOrdIDs. 
  # @param symbol Instrument symbol. e.g. &#39;XBT24H&#39;.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :side Order side. Valid options: Buy, Sell. Defaults to &#39;Buy&#39; unless &#x60;orderQty&#x60; or &#x60;simpleOrderQty&#x60; is negative.
  # @option opts [Float] :simple_order_qty Order quantity in units of the underlying instrument (i.e. Bitcoin).
  # @option opts [Float] :quantity Deprecated: use &#x60;orderQty&#x60;.
  # @option opts [Float] :order_qty Order quantity in units of the instrument (i.e. contracts).
  # @option opts [Float] :price Optional limit price for &#39;Limit&#39;, &#39;StopLimit&#39;, and &#39;LimitIfTouched&#39; orders.
  # @option opts [Float] :display_qty Optional quantity to display in the book. Use 0 for a hidden order.
  # @option opts [Float] :stop_price Deprecated: use &#x60;stopPx&#x60;.
  # @option opts [Float] :stop_px Optional trigger price for &#39;Stop&#39;, &#39;StopLimit&#39;, &#39;MarketIfTouched&#39;, and &#39;LimitIfTouched&#39; orders. Use a price below the current price for stop-sell orders and buy-if-touched orders. Use &#x60;execInst&#x60; of &#39;MarkPrice&#39; or &#39;LastPrice&#39; to define the current price used for triggering.
  # @option opts [String] :cl_ord_id Optional Client Order ID. This clOrdID will come back on the order and any related executions.
  # @option opts [String] :cl_ord_link_id Optional Client Order Link ID for contingent orders.
  # @option opts [Float] :peg_offset_value Optional trailing offset from the current price for &#39;Stop&#39;, &#39;StopLimit&#39;, &#39;MarketIfTouched&#39;, and &#39;LimitIfTouched&#39; orders; use a negative offset for stop-sell orders and buy-if-touched orders. Optional offset from the peg price for &#39;Pegged&#39; orders.
  # @option opts [String] :peg_price_type Optional peg price type. Valid options: LastPeg, MidPricePeg, MarketPeg, PrimaryPeg, TrailingStopPeg, TrailingStopPeg.
  # @option opts [String] :type Deprecated: use &#x60;ordType&#x60;.
  # @option opts [String] :ord_type Order type. Valid options: Market, Limit, Stop, StopLimit, MarketIfTouched, LimitIfTouched, MarketWithLeftOverAsLimit, Pegged. Defaults to &#39;Limit&#39; when &#x60;price&#x60; is specified. Defaults to &#39;Stop&#39; when &#x60;stopPx&#x60; is specified. Defaults to &#39;StopLimit&#39; when &#x60;price&#x60; and &#x60;stopPx&#x60; are specified.
  # @option opts [String] :time_in_force Time in force. Valid options: Day, GoodTillCancel, ImmediateOrCancel, FillOrKill. Defaults to &#39;GoodTillCancel&#39; for &#39;Limit&#39;, &#39;StopLimit&#39;, &#39;LimitIfTouched&#39;, and &#39;MarketWithLeftOverAsLimit&#39; orders.
  # @option opts [String] :exec_inst Optional execution instructions. Valid options: ParticipateDoNotInitiate, AllOrNone, MarkPrice, IndexPrice, LastPrice, Close, ReduceOnly, Fixed. &#39;AllOrNone&#39; instruction requires &#x60;displayQty&#x60; to be 0. &#39;MarkPrice&#39; or &#39;LastPrice&#39; instruction valid for &#39;Stop&#39;, &#39;StopLimit&#39;, &#39;MarketIfTouched&#39;, and &#39;LimitIfTouched&#39; orders.
  # @option opts [String] :contingency_type Optional contingency type for use with &#x60;clOrdLinkID&#x60;. Valid options: OneCancelsTheOther, OneTriggersTheOther, OneUpdatesTheOtherAbsolute, OneUpdatesTheOtherProportional.
  # @option opts [String] :text Optional order annotation. e.g. &#39;Take profit&#39;.
  # @return [Order]
  describe 'order_new test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_new_bulk
  # Create multiple new orders.
  # This endpoint is used for placing bulk orders. Valid order types are Market, Limit, Stop, StopLimit, MarketIfTouched, LimitIfTouched, MarketWithLeftOverAsLimit, and Pegged.  Each individual order object in the array should have the same properties as an individual POST /order call.  This endpoint is much faster for getting many orders into the book at once. Because it reduces load on BitMEX systems, this endpoint is ratelimited at &#x60;ceil(0.5 * orders)&#x60;. Submitting 10 orders via a bulk order call will only count as 5 requests.  For now, only &#x60;application/json&#x60; is supported on this endpoint. 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :orders An array of orders.
  # @return [Array<Order>]
  describe 'order_new_bulk test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end

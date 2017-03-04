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

# Unit tests for SwaggerClient::OrderBookApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'OrderBookApi' do
  before do
    # run before each test
    @instance = SwaggerClient::OrderBookApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of OrderBookApi' do
    it 'should create an instact of OrderBookApi' do
      expect(@instance).to be_instance_of(SwaggerClient::OrderBookApi)
    end
  end

  # unit tests for order_book_get
  # Get current orderbook [deprecated, use /orderBook/L2].
  # 
  # @param symbol Instrument symbol. Send a series (e.g. XBT) to get data for the nearest contract in that series.
  # @param [Hash] opts the optional parameters
  # @option opts [Float] :depth Orderbook depth.
  # @return [Array<OrderBook>]
  describe 'order_book_get test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for order_book_get_l2
  # Get current orderbook in vertical format.
  # 
  # @param symbol Instrument symbol. Send a series (e.g. XBT) to get data for the nearest contract in that series.
  # @param [Hash] opts the optional parameters
  # @option opts [Float] :depth Orderbook depth per side. Send 0 for full depth.
  # @return [Array<OrderBookL2>]
  describe 'order_book_get_l2 test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end

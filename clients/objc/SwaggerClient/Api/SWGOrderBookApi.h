#import <Foundation/Foundation.h>
#import "SWGOrderBook.h"
#import "SWGError.h"
#import "SWGOrderBookL2.h"
#import "SWGApi.h"

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


@interface SWGOrderBookApi: NSObject <SWGApi>

extern NSString* kSWGOrderBookApiErrorDomain;
extern NSInteger kSWGOrderBookApiMissingParamErrorCode;

+(instancetype) sharedAPI;

/// Get current orderbook [deprecated, use /orderBook/L2].
/// 
///
/// @param symbol Instrument symbol. Send a series (e.g. XBT) to get data for the nearest contract in that series.
/// @param depth Orderbook depth. (optional) (default to 25)
/// 
///  code:200 message:"Request was successful",
///  code:400 message:"Parameter Error",
///  code:401 message:"Unauthorized",
///  code:404 message:"Not Found"
///
/// @return NSArray<SWGOrderBook>*
-(NSNumber*) orderBookGetWithSymbol: (NSString*) symbol
    depth: (NSNumber*) depth
    completionHandler: (void (^)(NSArray<SWGOrderBook>* output, NSError* error)) handler;


/// Get current orderbook in vertical format.
/// 
///
/// @param symbol Instrument symbol. Send a series (e.g. XBT) to get data for the nearest contract in that series.
/// @param depth Orderbook depth per side. Send 0 for full depth. (optional) (default to 25)
/// 
///  code:200 message:"Request was successful",
///  code:400 message:"Parameter Error",
///  code:401 message:"Unauthorized",
///  code:404 message:"Not Found"
///
/// @return NSArray<SWGOrderBookL2>*
-(NSNumber*) orderBookGetL2WithSymbol: (NSString*) symbol
    depth: (NSNumber*) depth
    completionHandler: (void (^)(NSArray<SWGOrderBookL2>* output, NSError* error)) handler;



@end

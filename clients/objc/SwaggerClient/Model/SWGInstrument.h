#import <Foundation/Foundation.h>
#import "SWGObject.h"

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



@protocol SWGInstrument
@end

@interface SWGInstrument : SWGObject


@property(nonatomic) NSString* symbol;

@property(nonatomic) NSString* rootSymbol;

@property(nonatomic) NSString* state;

@property(nonatomic) NSString* typ;

@property(nonatomic) NSDate* listing;

@property(nonatomic) NSDate* front;

@property(nonatomic) NSDate* expiry;

@property(nonatomic) NSDate* settle;

@property(nonatomic) NSDate* relistInterval;

@property(nonatomic) NSString* inverseLeg;

@property(nonatomic) NSString* sellLeg;

@property(nonatomic) NSString* buyLeg;

@property(nonatomic) NSString* positionCurrency;

@property(nonatomic) NSString* underlying;

@property(nonatomic) NSString* quoteCurrency;

@property(nonatomic) NSString* underlyingSymbol;

@property(nonatomic) NSString* reference;

@property(nonatomic) NSString* referenceSymbol;

@property(nonatomic) NSDate* calcInterval;

@property(nonatomic) NSDate* publishInterval;

@property(nonatomic) NSDate* publishTime;

@property(nonatomic) NSNumber* maxOrderQty;

@property(nonatomic) NSNumber* maxPrice;

@property(nonatomic) NSNumber* lotSize;

@property(nonatomic) NSNumber* tickSize;

@property(nonatomic) NSNumber* multiplier;

@property(nonatomic) NSString* settlCurrency;

@property(nonatomic) NSNumber* underlyingToPositionMultiplier;

@property(nonatomic) NSNumber* underlyingToSettleMultiplier;

@property(nonatomic) NSNumber* quoteToSettleMultiplier;

@property(nonatomic) NSNumber* isQuanto;

@property(nonatomic) NSNumber* isInverse;

@property(nonatomic) NSNumber* initMargin;

@property(nonatomic) NSNumber* maintMargin;

@property(nonatomic) NSNumber* riskLimit;

@property(nonatomic) NSNumber* riskStep;

@property(nonatomic) NSNumber* limit;

@property(nonatomic) NSNumber* capped;

@property(nonatomic) NSNumber* taxed;

@property(nonatomic) NSNumber* deleverage;

@property(nonatomic) NSNumber* makerFee;

@property(nonatomic) NSNumber* takerFee;

@property(nonatomic) NSNumber* settlementFee;

@property(nonatomic) NSNumber* insuranceFee;

@property(nonatomic) NSString* fundingBaseSymbol;

@property(nonatomic) NSString* fundingQuoteSymbol;

@property(nonatomic) NSString* fundingPremiumSymbol;

@property(nonatomic) NSDate* fundingTimestamp;

@property(nonatomic) NSDate* fundingInterval;

@property(nonatomic) NSNumber* fundingRate;

@property(nonatomic) NSNumber* indicativeFundingRate;

@property(nonatomic) NSDate* rebalanceTimestamp;

@property(nonatomic) NSDate* rebalanceInterval;

@property(nonatomic) NSDate* openingTimestamp;

@property(nonatomic) NSDate* closingTimestamp;

@property(nonatomic) NSDate* sessionInterval;

@property(nonatomic) NSNumber* prevClosePrice;

@property(nonatomic) NSNumber* limitDownPrice;

@property(nonatomic) NSNumber* limitUpPrice;

@property(nonatomic) NSNumber* bankruptLimitDownPrice;

@property(nonatomic) NSNumber* bankruptLimitUpPrice;

@property(nonatomic) NSNumber* prevTotalVolume;

@property(nonatomic) NSNumber* totalVolume;

@property(nonatomic) NSNumber* volume;

@property(nonatomic) NSNumber* volume24h;

@property(nonatomic) NSNumber* prevTotalTurnover;

@property(nonatomic) NSNumber* totalTurnover;

@property(nonatomic) NSNumber* turnover;

@property(nonatomic) NSNumber* turnover24h;

@property(nonatomic) NSNumber* prevPrice24h;

@property(nonatomic) NSNumber* vwap;

@property(nonatomic) NSNumber* highPrice;

@property(nonatomic) NSNumber* lowPrice;

@property(nonatomic) NSNumber* lastPrice;

@property(nonatomic) NSNumber* lastPriceProtected;

@property(nonatomic) NSString* lastTickDirection;

@property(nonatomic) NSNumber* lastChangePcnt;

@property(nonatomic) NSNumber* bidPrice;

@property(nonatomic) NSNumber* midPrice;

@property(nonatomic) NSNumber* askPrice;

@property(nonatomic) NSNumber* impactBidPrice;

@property(nonatomic) NSNumber* impactMidPrice;

@property(nonatomic) NSNumber* impactAskPrice;

@property(nonatomic) NSNumber* hasLiquidity;

@property(nonatomic) NSNumber* openInterest;

@property(nonatomic) NSNumber* openValue;

@property(nonatomic) NSString* fairMethod;

@property(nonatomic) NSNumber* fairBasisRate;

@property(nonatomic) NSNumber* fairBasis;

@property(nonatomic) NSNumber* fairPrice;

@property(nonatomic) NSString* markMethod;

@property(nonatomic) NSNumber* markPrice;

@property(nonatomic) NSNumber* indicativeTaxRate;

@property(nonatomic) NSNumber* indicativeSettlePrice;

@property(nonatomic) NSNumber* settledPrice;

@property(nonatomic) NSDate* timestamp;

@end

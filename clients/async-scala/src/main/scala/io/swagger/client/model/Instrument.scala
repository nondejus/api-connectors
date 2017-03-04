package io.swagger.client.model

import org.joda.time.DateTime
import java.util.UUID


case class Instrument (
  symbol: String,
rootSymbol: Option[String],
state: Option[String],
typ: Option[String],
listing: Option[DateTime],
front: Option[DateTime],
expiry: Option[DateTime],
settle: Option[DateTime],
relistInterval: Option[DateTime],
inverseLeg: Option[String],
sellLeg: Option[String],
buyLeg: Option[String],
positionCurrency: Option[String],
underlying: Option[String],
quoteCurrency: Option[String],
underlyingSymbol: Option[String],
reference: Option[String],
referenceSymbol: Option[String],
calcInterval: Option[DateTime],
publishInterval: Option[DateTime],
publishTime: Option[DateTime],
maxOrderQty: Option[Number],
maxPrice: Option[Double],
lotSize: Option[Number],
tickSize: Option[Double],
multiplier: Option[Number],
settlCurrency: Option[String],
underlyingToPositionMultiplier: Option[Number],
underlyingToSettleMultiplier: Option[Number],
quoteToSettleMultiplier: Option[Number],
isQuanto: Option[Boolean],
isInverse: Option[Boolean],
initMargin: Option[Double],
maintMargin: Option[Double],
riskLimit: Option[Number],
riskStep: Option[Number],
limit: Option[Double],
capped: Option[Boolean],
taxed: Option[Boolean],
deleverage: Option[Boolean],
makerFee: Option[Double],
takerFee: Option[Double],
settlementFee: Option[Double],
insuranceFee: Option[Double],
fundingBaseSymbol: Option[String],
fundingQuoteSymbol: Option[String],
fundingPremiumSymbol: Option[String],
fundingTimestamp: Option[DateTime],
fundingInterval: Option[DateTime],
fundingRate: Option[Double],
indicativeFundingRate: Option[Double],
rebalanceTimestamp: Option[DateTime],
rebalanceInterval: Option[DateTime],
openingTimestamp: Option[DateTime],
closingTimestamp: Option[DateTime],
sessionInterval: Option[DateTime],
prevClosePrice: Option[Double],
limitDownPrice: Option[Double],
limitUpPrice: Option[Double],
bankruptLimitDownPrice: Option[Double],
bankruptLimitUpPrice: Option[Double],
prevTotalVolume: Option[Number],
totalVolume: Option[Number],
volume: Option[Number],
volume24h: Option[Number],
prevTotalTurnover: Option[Number],
totalTurnover: Option[Number],
turnover: Option[Number],
turnover24h: Option[Number],
prevPrice24h: Option[Double],
vwap: Option[Double],
highPrice: Option[Double],
lowPrice: Option[Double],
lastPrice: Option[Double],
lastPriceProtected: Option[Double],
lastTickDirection: Option[String],
lastChangePcnt: Option[Double],
bidPrice: Option[Double],
midPrice: Option[Double],
askPrice: Option[Double],
impactBidPrice: Option[Double],
impactMidPrice: Option[Double],
impactAskPrice: Option[Double],
hasLiquidity: Option[Boolean],
openInterest: Option[Number],
openValue: Option[Number],
fairMethod: Option[String],
fairBasisRate: Option[Double],
fairBasis: Option[Double],
fairPrice: Option[Double],
markMethod: Option[String],
markPrice: Option[Double],
indicativeTaxRate: Option[Double],
indicativeSettlePrice: Option[Double],
settledPrice: Option[Double],
timestamp: Option[DateTime]
)

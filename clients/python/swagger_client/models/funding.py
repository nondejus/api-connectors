# coding: utf-8

"""
    BitMEX API

    ## REST API for the BitMEX Trading Platform  [Changelog](/app/apiChangelog)    #### Getting Started   ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](https://www.bitmex.com/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  -  ## All API Endpoints  Click to expand a section. 

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
"""

from pprint import pformat
from six import iteritems
import re


class Funding(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, timestamp=None, symbol=None, funding_interval=None, funding_rate=None, funding_rate_daily=None):
        """
        Funding - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'timestamp': 'datetime',
            'symbol': 'str',
            'funding_interval': 'datetime',
            'funding_rate': 'float',
            'funding_rate_daily': 'float'
        }

        self.attribute_map = {
            'timestamp': 'timestamp',
            'symbol': 'symbol',
            'funding_interval': 'fundingInterval',
            'funding_rate': 'fundingRate',
            'funding_rate_daily': 'fundingRateDaily'
        }

        self._timestamp = timestamp
        self._symbol = symbol
        self._funding_interval = funding_interval
        self._funding_rate = funding_rate
        self._funding_rate_daily = funding_rate_daily

    @property
    def timestamp(self):
        """
        Gets the timestamp of this Funding.


        :return: The timestamp of this Funding.
        :rtype: datetime
        """
        return self._timestamp

    @timestamp.setter
    def timestamp(self, timestamp):
        """
        Sets the timestamp of this Funding.


        :param timestamp: The timestamp of this Funding.
        :type: datetime
        """

        self._timestamp = timestamp

    @property
    def symbol(self):
        """
        Gets the symbol of this Funding.


        :return: The symbol of this Funding.
        :rtype: str
        """
        return self._symbol

    @symbol.setter
    def symbol(self, symbol):
        """
        Sets the symbol of this Funding.


        :param symbol: The symbol of this Funding.
        :type: str
        """

        self._symbol = symbol

    @property
    def funding_interval(self):
        """
        Gets the funding_interval of this Funding.


        :return: The funding_interval of this Funding.
        :rtype: datetime
        """
        return self._funding_interval

    @funding_interval.setter
    def funding_interval(self, funding_interval):
        """
        Sets the funding_interval of this Funding.


        :param funding_interval: The funding_interval of this Funding.
        :type: datetime
        """

        self._funding_interval = funding_interval

    @property
    def funding_rate(self):
        """
        Gets the funding_rate of this Funding.


        :return: The funding_rate of this Funding.
        :rtype: float
        """
        return self._funding_rate

    @funding_rate.setter
    def funding_rate(self, funding_rate):
        """
        Sets the funding_rate of this Funding.


        :param funding_rate: The funding_rate of this Funding.
        :type: float
        """

        self._funding_rate = funding_rate

    @property
    def funding_rate_daily(self):
        """
        Gets the funding_rate_daily of this Funding.


        :return: The funding_rate_daily of this Funding.
        :rtype: float
        """
        return self._funding_rate_daily

    @funding_rate_daily.setter
    def funding_rate_daily(self, funding_rate_daily):
        """
        Sets the funding_rate_daily of this Funding.


        :param funding_rate_daily: The funding_rate_daily of this Funding.
        :type: float
        """

        self._funding_rate_daily = funding_rate_daily

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other

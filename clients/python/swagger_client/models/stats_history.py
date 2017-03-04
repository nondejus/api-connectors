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


class StatsHistory(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, date=None, root_symbol=None, currency=None, volume=None, turnover=None):
        """
        StatsHistory - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'date': 'datetime',
            'root_symbol': 'str',
            'currency': 'str',
            'volume': 'float',
            'turnover': 'float'
        }

        self.attribute_map = {
            'date': 'date',
            'root_symbol': 'rootSymbol',
            'currency': 'currency',
            'volume': 'volume',
            'turnover': 'turnover'
        }

        self._date = date
        self._root_symbol = root_symbol
        self._currency = currency
        self._volume = volume
        self._turnover = turnover

    @property
    def date(self):
        """
        Gets the date of this StatsHistory.


        :return: The date of this StatsHistory.
        :rtype: datetime
        """
        return self._date

    @date.setter
    def date(self, date):
        """
        Sets the date of this StatsHistory.


        :param date: The date of this StatsHistory.
        :type: datetime
        """

        self._date = date

    @property
    def root_symbol(self):
        """
        Gets the root_symbol of this StatsHistory.


        :return: The root_symbol of this StatsHistory.
        :rtype: str
        """
        return self._root_symbol

    @root_symbol.setter
    def root_symbol(self, root_symbol):
        """
        Sets the root_symbol of this StatsHistory.


        :param root_symbol: The root_symbol of this StatsHistory.
        :type: str
        """

        self._root_symbol = root_symbol

    @property
    def currency(self):
        """
        Gets the currency of this StatsHistory.


        :return: The currency of this StatsHistory.
        :rtype: str
        """
        return self._currency

    @currency.setter
    def currency(self, currency):
        """
        Sets the currency of this StatsHistory.


        :param currency: The currency of this StatsHistory.
        :type: str
        """

        self._currency = currency

    @property
    def volume(self):
        """
        Gets the volume of this StatsHistory.


        :return: The volume of this StatsHistory.
        :rtype: float
        """
        return self._volume

    @volume.setter
    def volume(self, volume):
        """
        Sets the volume of this StatsHistory.


        :param volume: The volume of this StatsHistory.
        :type: float
        """

        self._volume = volume

    @property
    def turnover(self):
        """
        Gets the turnover of this StatsHistory.


        :return: The turnover of this StatsHistory.
        :rtype: float
        """
        return self._turnover

    @turnover.setter
    def turnover(self, turnover):
        """
        Sets the turnover of this StatsHistory.


        :param turnover: The turnover of this StatsHistory.
        :type: float
        """

        self._turnover = turnover

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

/* 
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  [Changelog](/app/apiChangelog)    #### Getting Started   ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](https://www.bitmex.com/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  -  ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFundingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get funding history.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>List&lt;Funding&gt;</returns>
        List<Funding> FundingGet (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get funding history.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>ApiResponse of List&lt;Funding&gt;</returns>
        ApiResponse<List<Funding>> FundingGetWithHttpInfo (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get funding history.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>Task of List&lt;Funding&gt;</returns>
        System.Threading.Tasks.Task<List<Funding>> FundingGetAsync (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get funding history.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Funding&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Funding>>> FundingGetAsyncWithHttpInfo (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FundingApi : IFundingApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FundingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FundingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FundingApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get funding history. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>List&lt;Funding&gt;</returns>
        public List<Funding> FundingGet (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<List<Funding>> localVarResponse = FundingGetWithHttpInfo(symbol, filter, columns, count, start, reverse, startTime, endTime);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get funding history. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>ApiResponse of List&lt;Funding&gt;</returns>
        public ApiResponse< List<Funding> > FundingGetWithHttpInfo (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null)
        {

            var localVarPath = "/funding";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (symbol != null) localVarQueryParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (columns != null) localVarQueryParams.Add("columns", Configuration.ApiClient.ParameterToString(columns)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (reverse != null) localVarQueryParams.Add("reverse", Configuration.ApiClient.ParameterToString(reverse)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FundingGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Funding>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Funding>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Funding>)));
            
        }

        /// <summary>
        /// Get funding history. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>Task of List&lt;Funding&gt;</returns>
        public async System.Threading.Tasks.Task<List<Funding>> FundingGetAsync (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<List<Funding>> localVarResponse = await FundingGetAsyncWithHttpInfo(symbol, filter, columns, count, start, reverse, startTime, endTime);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get funding history. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="symbol">Instrument symbol. Send a bare series (e.g. XBU) to get data for the nearest expiring contract in that series.  You can also send a timeframe, e.g. &#x60;XBU:monthly&#x60;. Timeframes are &#x60;daily&#x60;, &#x60;weekly&#x60;, &#x60;monthly&#x60;, &#x60;quarterly&#x60;, and &#x60;biquarterly&#x60;. (optional)</param>
        /// <param name="filter">Generic table filter. Send JSON key/value pairs, such as &#x60;{\&quot;key\&quot;: \&quot;value\&quot;}&#x60;. You can key on individual fields, and do more advanced querying on timestamps. See the [Timestamp Docs](https://www.bitmex.com/app/restAPI#timestamp-filters) for more details. (optional)</param>
        /// <param name="columns">Array of column names to fetch. If omitted, will return all columns.  Note that this method will always return item keys, even when not specified, so you may receive more columns that you expect. (optional)</param>
        /// <param name="count">Number of results to fetch. (optional, default to 100)</param>
        /// <param name="start">Starting point for results. (optional, default to 0)</param>
        /// <param name="reverse">If true, will sort results newest first. (optional, default to false)</param>
        /// <param name="startTime">Starting date filter for results. (optional)</param>
        /// <param name="endTime">Ending date filter for results. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;Funding&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Funding>>> FundingGetAsyncWithHttpInfo (string symbol = null, string filter = null, string columns = null, decimal? count = null, decimal? start = null, bool? reverse = null, DateTime? startTime = null, DateTime? endTime = null)
        {

            var localVarPath = "/funding";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (symbol != null) localVarQueryParams.Add("symbol", Configuration.ApiClient.ParameterToString(symbol)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (columns != null) localVarQueryParams.Add("columns", Configuration.ApiClient.ParameterToString(columns)); // query parameter
            if (count != null) localVarQueryParams.Add("count", Configuration.ApiClient.ParameterToString(count)); // query parameter
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (reverse != null) localVarQueryParams.Add("reverse", Configuration.ApiClient.ParameterToString(reverse)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FundingGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Funding>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Funding>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Funding>)));
            
        }

    }
}

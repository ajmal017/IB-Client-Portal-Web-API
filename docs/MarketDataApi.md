# IO.Swagger.Api.MarketDataApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverMarketdataConidUnsubscribeGet**](MarketDataApi.md#iservermarketdataconidunsubscribeget) | **GET** /iserver/marketdata/{conid}/unsubscribe | Market Data Cancel (Single)
[**IserverMarketdataHistoryGet**](MarketDataApi.md#iservermarketdatahistoryget) | **GET** /iserver/marketdata/history | Market Data History
[**IserverMarketdataSnapshotGet**](MarketDataApi.md#iservermarketdatasnapshotget) | **GET** /iserver/marketdata/snapshot | Market Data
[**IserverMarketdataUnsubscribeallGet**](MarketDataApi.md#iservermarketdataunsubscribeallget) | **GET** /iserver/marketdata/unsubscribeall | Market Data Cancel (All)


<a name="iservermarketdataconidunsubscribeget"></a>
# **IserverMarketdataConidUnsubscribeGet**
> Object IserverMarketdataConidUnsubscribeGet (string conid)

Market Data Cancel (Single)

Cancel market data for given conid. To cancel all market data request(s), see /iserver/marketdata/unsubscribeall. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverMarketdataConidUnsubscribeGetExample
    {
        public void main()
        {
            var apiInstance = new MarketDataApi();
            var conid = conid_example;  // string | contract id

            try
            {
                // Market Data Cancel (Single)
                Object result = apiInstance.IserverMarketdataConidUnsubscribeGet(conid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketDataApi.IserverMarketdataConidUnsubscribeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conid** | **string**| contract id | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iservermarketdatahistoryget"></a>
# **IserverMarketdataHistoryGet**
> HistoryData IserverMarketdataHistoryGet (string conid, string period, string exchange = null, string bar = null, bool? outsideRth = null)

Market Data History

Get historical market Data for given conid, length of data is controlled by 'period' and 'bar'. Formatted as: min=minute, h=hour, d=day, w=week, m=month, y=year e.g. period =1y with bar =1w returns 52 data points (Max of 1000 data points supported). **Note**: There's a limit of 5 concurrent requests. Excessive requests will return a 'Too many requests' status 429 response. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverMarketdataHistoryGetExample
    {
        public void main()
        {
            var apiInstance = new MarketDataApi();
            var conid = conid_example;  // string | contract id
            var period = period_example;  // string | available time period- - {1-30}min, {1-8}h, {1-1000}d, {1-792}w, {1-182}m, {1-15}y
            var exchange = exchange_example;  // string | Exchange of the conid (e.g. ISLAND, NYSE, etc.). Default value is empty which corresponds to primary exchange of the conid. (optional) 
            var bar = bar_example;  // string | possible value- - 1min, 2min, 3min, 5min, 10min, 15min, 30min, 1h, 2h, 3h, 4h, 8h, 1d, 1w, 1m (optional) 
            var outsideRth = true;  // bool? | For contracts that support it, will determine if historical data includes outside of regular trading hours. (optional) 

            try
            {
                // Market Data History
                HistoryData result = apiInstance.IserverMarketdataHistoryGet(conid, period, exchange, bar, outsideRth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketDataApi.IserverMarketdataHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conid** | **string**| contract id | 
 **period** | **string**| available time period- - {1-30}min, {1-8}h, {1-1000}d, {1-792}w, {1-182}m, {1-15}y | 
 **exchange** | **string**| Exchange of the conid (e.g. ISLAND, NYSE, etc.). Default value is empty which corresponds to primary exchange of the conid. | [optional] 
 **bar** | **string**| possible value- - 1min, 2min, 3min, 5min, 10min, 15min, 30min, 1h, 2h, 3h, 4h, 8h, 1d, 1w, 1m | [optional] 
 **outsideRth** | **bool?**| For contracts that support it, will determine if historical data includes outside of regular trading hours. | [optional] 

### Return type

[**HistoryData**](HistoryData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iservermarketdatasnapshotget"></a>
# **IserverMarketdataSnapshotGet**
> List<Object> IserverMarketdataSnapshotGet (string conids, int? since = null, string fields = null)

Market Data

Get Market Data for the given conid(s). The endpoint will return by default bid, ask, last, change, change pct, close, listing exchange. See response fields for a list of available fields that can be request via fields argument. The endpoint /iserver/accounts must be called prior to /iserver/marketdata/snapshot. For derivative contracts the endpoint /iserver/secdef/search must be called first. First /snapshot endpoint call for given conid will initiate the market data request.  To receive all available fields the /snapshot endpoint will need to be called several times. To receive streaming market data the endpoint /ws can be used. Refer to [Streaming WebSocket Data](https://interactivebrokers.github.io/cpwebapi/RealtimeSubscription.html) for details. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverMarketdataSnapshotGetExample
    {
        public void main()
        {
            var apiInstance = new MarketDataApi();
            var conids = conids_example;  // string | list of conids separated by comma
            var since = 56;  // int? | time period since which updates are required. uses epoch time with milliseconds. (optional) 
            var fields = fields_example;  // string | list of fields separated by comma (optional) 

            try
            {
                // Market Data
                List&lt;Object&gt; result = apiInstance.IserverMarketdataSnapshotGet(conids, since, fields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketDataApi.IserverMarketdataSnapshotGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conids** | **string**| list of conids separated by comma | 
 **since** | **int?**| time period since which updates are required. uses epoch time with milliseconds. | [optional] 
 **fields** | **string**| list of fields separated by comma | [optional] 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iservermarketdataunsubscribeallget"></a>
# **IserverMarketdataUnsubscribeallGet**
> Object IserverMarketdataUnsubscribeallGet ()

Market Data Cancel (All)

Cancel all market data request(s). To cancel market data for given conid, see /iserver/marketdata/{conid}/unsubscribe.  

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverMarketdataUnsubscribeallGetExample
    {
        public void main()
        {
            var apiInstance = new MarketDataApi();

            try
            {
                // Market Data Cancel (All)
                Object result = apiInstance.IserverMarketdataUnsubscribeallGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketDataApi.IserverMarketdataUnsubscribeallGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


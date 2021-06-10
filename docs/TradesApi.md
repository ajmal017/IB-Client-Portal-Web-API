# IO.Swagger.Api.TradesApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverAccountTradesGet**](TradesApi.md#iserveraccounttradesget) | **GET** /iserver/account/trades | List of Trades for the selected account


<a name="iserveraccounttradesget"></a>
# **IserverAccountTradesGet**
> List<Trade> IserverAccountTradesGet ()

List of Trades for the selected account

Returns a list of trades for the currently selected account for current day and six previous days. It is advised to call this endpoint once per session. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountTradesGetExample
    {
        public void main()
        {
            var apiInstance = new TradesApi();

            try
            {
                // List of Trades for the selected account
                List&lt;Trade&gt; result = apiInstance.IserverAccountTradesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TradesApi.IserverAccountTradesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Trade>**](Trade.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


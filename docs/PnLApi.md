# IO.Swagger.Api.PnLApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverAccountPnlPartitionedGet**](PnLApi.md#iserveraccountpnlpartitionedget) | **GET** /iserver/account/pnl/partitioned | PnL for the selected account


<a name="iserveraccountpnlpartitionedget"></a>
# **IserverAccountPnlPartitionedGet**
> Object IserverAccountPnlPartitionedGet ()

PnL for the selected account

Returns an object containing PnL for the selected account and its models (if any). To receive streaming PnL the endpoint /ws can be used. Refer to [Streaming WebSocket Data](https://interactivebrokers.github.io/cpwebapi/RealtimeSubscription.html) for details. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountPnlPartitionedGetExample
    {
        public void main()
        {
            var apiInstance = new PnLApi();

            try
            {
                // PnL for the selected account
                Object result = apiInstance.IserverAccountPnlPartitionedGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PnLApi.IserverAccountPnlPartitionedGet: " + e.Message );
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


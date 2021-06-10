# IO.Swagger.Api.StreamingApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WsPost**](StreamingApi.md#wspost) | **POST** /ws | Websocket Endpoint


<a name="wspost"></a>
# **WsPost**
> void WsPost ()

Websocket Endpoint

The streaming API is documented under [Streaming WebSocket Data](https://interactivebrokers.github.io/cpwebapi/RealtimeSubscription.html) for details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WsPostExample
    {
        public void main()
        {
            var apiInstance = new StreamingApi();

            try
            {
                // Websocket Endpoint
                apiInstance.WsPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreamingApi.WsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


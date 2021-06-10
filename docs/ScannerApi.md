# IO.Swagger.Api.ScannerApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverScannerParamsGet**](ScannerApi.md#iserverscannerparamsget) | **GET** /iserver/scanner/params | Scanner Parameters
[**IserverScannerRunPost**](ScannerApi.md#iserverscannerrunpost) | **POST** /iserver/scanner/run | run scanner to get a list of contracts


<a name="iserverscannerparamsget"></a>
# **IserverScannerParamsGet**
> Object IserverScannerParamsGet ()

Scanner Parameters

Returns an object contains four lists contain all parameters for scanners

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverScannerParamsGetExample
    {
        public void main()
        {
            var apiInstance = new ScannerApi();

            try
            {
                // Scanner Parameters
                Object result = apiInstance.IserverScannerParamsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScannerApi.IserverScannerParamsGet: " + e.Message );
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

<a name="iserverscannerrunpost"></a>
# **IserverScannerRunPost**
> List<Object> IserverScannerRunPost (ScannerParams body)

run scanner to get a list of contracts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverScannerRunPostExample
    {
        public void main()
        {
            var apiInstance = new ScannerApi();
            var body = new ScannerParams(); // ScannerParams | scanner-params request

            try
            {
                // run scanner to get a list of contracts
                List&lt;Object&gt; result = apiInstance.IserverScannerRunPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScannerApi.IserverScannerRunPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ScannerParams**](ScannerParams.md)| scanner-params request | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


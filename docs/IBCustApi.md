# IO.Swagger.Api.IBCustApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IbcustEntityInfoGet**](IBCustApi.md#ibcustentityinfoget) | **GET** /ibcust/entity/info | IBCust Entity Info


<a name="ibcustentityinfoget"></a>
# **IbcustEntityInfoGet**
> List<Object> IbcustEntityInfoGet ()

IBCust Entity Info

Returns Applicant Id with all owner related entities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IbcustEntityInfoGetExample
    {
        public void main()
        {
            var apiInstance = new IBCustApi();

            try
            {
                // IBCust Entity Info
                List&lt;Object&gt; result = apiInstance.IbcustEntityInfoGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IBCustApi.IbcustEntityInfoGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


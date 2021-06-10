# IO.Swagger.Api.PortfolioAnalystApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PaPerformancePost**](PortfolioAnalystApi.md#paperformancepost) | **POST** /pa/performance | Account Performance
[**PaSummaryPost**](PortfolioAnalystApi.md#pasummarypost) | **POST** /pa/summary | Account Balance&#39;s Summary
[**PaTransactionsPost**](PortfolioAnalystApi.md#patransactionspost) | **POST** /pa/transactions | Position&#39;s Transaction History


<a name="paperformancepost"></a>
# **PaPerformancePost**
> Performance PaPerformancePost (Body body)

Account Performance

Returns the performance (MTM) for the given accounts, if more than one account is passed, the result is consolidated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PaPerformancePostExample
    {
        public void main()
        {
            var apiInstance = new PortfolioAnalystApi();
            var body = new Body(); // Body | an array of account ids

            try
            {
                // Account Performance
                Performance result = apiInstance.PaPerformancePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioAnalystApi.PaPerformancePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| an array of account ids | 

### Return type

[**Performance**](Performance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pasummarypost"></a>
# **PaSummaryPost**
> Summary PaSummaryPost (Body body)

Account Balance's Summary

Returns a summary of all account balances for the given accounts, if more than one account is passed, the result is consolidated.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PaSummaryPostExample
    {
        public void main()
        {
            var apiInstance = new PortfolioAnalystApi();
            var body = new Body(); // Body | an array of account ids

            try
            {
                // Account Balance's Summary
                Summary result = apiInstance.PaSummaryPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioAnalystApi.PaSummaryPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| an array of account ids | 

### Return type

[**Summary**](Summary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patransactionspost"></a>
# **PaTransactionsPost**
> Transactions PaTransactionsPost (Body body)

Position's Transaction History

transaction history for a given number of conids and accounts. Types of transactions include dividend payments, buy and sell transactions, transfers. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PaTransactionsPostExample
    {
        public void main()
        {
            var apiInstance = new PortfolioAnalystApi();
            var body = new Body(); // Body | 

            try
            {
                // Position's Transaction History
                Transactions result = apiInstance.PaTransactionsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioAnalystApi.PaTransactionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 

### Return type

[**Transactions**](Transactions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


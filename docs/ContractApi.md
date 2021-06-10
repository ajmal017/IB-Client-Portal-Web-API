# IO.Swagger.Api.ContractApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverContractConidInfoAndRulesGet**](ContractApi.md#iservercontractconidinfoandrulesget) | **GET** /iserver/contract/{conid}/info-and-rules | Info and Rules
[**IserverContractConidInfoGet**](ContractApi.md#iservercontractconidinfoget) | **GET** /iserver/contract/{conid}/info | Contract Details
[**IserverSecdefInfoGet**](ContractApi.md#iserversecdefinfoget) | **GET** /iserver/secdef/info | Secdef Info
[**IserverSecdefSearchPost**](ContractApi.md#iserversecdefsearchpost) | **POST** /iserver/secdef/search | Search by Symbol or Name
[**IserverSecdefStrikesGet**](ContractApi.md#iserversecdefstrikesget) | **GET** /iserver/secdef/strikes | Search Strikes
[**TrsrvFuturesGet**](ContractApi.md#trsrvfuturesget) | **GET** /trsrv/futures | Security Futures by Symbol
[**TrsrvSecdefPost**](ContractApi.md#trsrvsecdefpost) | **POST** /trsrv/secdef | Secdef by Conid
[**TrsrvSecdefScheduleGet**](ContractApi.md#trsrvsecdefscheduleget) | **GET** /trsrv/secdef/schedule | Get trading schedule for symbol
[**TrsrvStocksGet**](ContractApi.md#trsrvstocksget) | **GET** /trsrv/stocks | Security Stocks by Symbol


<a name="iservercontractconidinfoandrulesget"></a>
# **IserverContractConidInfoAndRulesGet**
> Object IserverContractConidInfoAndRulesGet (string conid, bool? isBuy)

Info and Rules

Returns trading related rules and info for contract

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverContractConidInfoAndRulesGetExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var conid = conid_example;  // string | IBKR contract identifier
            var isBuy = true;  // bool? | Side of the market rules apply too. Set to true for Buy Orders, set to false for Sell Orders

            try
            {
                // Info and Rules
                Object result = apiInstance.IserverContractConidInfoAndRulesGet(conid, isBuy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.IserverContractConidInfoAndRulesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conid** | **string**| IBKR contract identifier | 
 **isBuy** | **bool?**| Side of the market rules apply too. Set to true for Buy Orders, set to false for Sell Orders | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iservercontractconidinfoget"></a>
# **IserverContractConidInfoGet**
> Contract IserverContractConidInfoGet (string conid)

Contract Details

Using the Contract Identifier get contract info. You can use this to prefill your order before you submit an order

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverContractConidInfoGetExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var conid = conid_example;  // string | contract id

            try
            {
                // Contract Details
                Contract result = apiInstance.IserverContractConidInfoGet(conid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.IserverContractConidInfoGet: " + e.Message );
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

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserversecdefinfoget"></a>
# **IserverSecdefInfoGet**
> Object IserverSecdefInfoGet (string conid, string sectype, string month = null, string exchange = null, string strike = null, string right = null)

Secdef Info

Provides Contract Details of Futures, Options, Warrants, Cash and CFDs based on conid. To get the strike price for Options/Warrants use \"/iserver/secdef/strikes\" endpoint. Must call /secdef/search for the underlying contract first.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverSecdefInfoGetExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var conid = conid_example;  // string | underlying contract id
            var sectype = sectype_example;  // string | FUT/OPT/WAR/CASH/CFD
            var month = month_example;  // string | contract month, only required for FUT/OPT/WAR in the format MMMYY, example JAN00 (optional) 
            var exchange = exchange_example;  // string | optional, default is SMART (optional) 
            var strike = strike_example;  // string | optional, only required for OPT/WAR (optional) 
            var right = right_example;  // string | C for call, P for put (optional) 

            try
            {
                // Secdef Info
                Object result = apiInstance.IserverSecdefInfoGet(conid, sectype, month, exchange, strike, right);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.IserverSecdefInfoGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conid** | **string**| underlying contract id | 
 **sectype** | **string**| FUT/OPT/WAR/CASH/CFD | 
 **month** | **string**| contract month, only required for FUT/OPT/WAR in the format MMMYY, example JAN00 | [optional] 
 **exchange** | **string**| optional, default is SMART | [optional] 
 **strike** | **string**| optional, only required for OPT/WAR | [optional] 
 **right** | **string**| C for call, P for put | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserversecdefsearchpost"></a>
# **IserverSecdefSearchPost**
> List<Object> IserverSecdefSearchPost (Symbol symbol)

Search by Symbol or Name

Search by underlying or company name. Relays back what derivative contract(s) it has. This endpoint must be called before using /secdef/info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverSecdefSearchPostExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var symbol = new Symbol(); // Symbol | Symbol or Company Name to be searched

            try
            {
                // Search by Symbol or Name
                List&lt;Object&gt; result = apiInstance.IserverSecdefSearchPost(symbol);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.IserverSecdefSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | [**Symbol**](Symbol.md)| Symbol or Company Name to be searched | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserversecdefstrikesget"></a>
# **IserverSecdefStrikesGet**
> Object IserverSecdefStrikesGet (string conid, string sectype, string month, string exchange = null)

Search Strikes

Query strikes for Options/Warrants. For available contract months and exchanges use \"/iserver/secdef/search\"

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverSecdefStrikesGetExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var conid = conid_example;  // string | contract id
            var sectype = sectype_example;  // string | OPT/WAR
            var month = month_example;  // string | contract month
            var exchange = exchange_example;  // string | optional, default is SMART (optional) 

            try
            {
                // Search Strikes
                Object result = apiInstance.IserverSecdefStrikesGet(conid, sectype, month, exchange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.IserverSecdefStrikesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conid** | **string**| contract id | 
 **sectype** | **string**| OPT/WAR | 
 **month** | **string**| contract month | 
 **exchange** | **string**| optional, default is SMART | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trsrvfuturesget"></a>
# **TrsrvFuturesGet**
> Object TrsrvFuturesGet (string symbols)

Security Futures by Symbol

Returns a list of non-expired future contracts for given symbol(s)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrsrvFuturesGetExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var symbols = symbols_example;  // string | list of case-sensitive symbols separated by comma

            try
            {
                // Security Futures by Symbol
                Object result = apiInstance.TrsrvFuturesGet(symbols);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.TrsrvFuturesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbols** | **string**| list of case-sensitive symbols separated by comma | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trsrvsecdefpost"></a>
# **TrsrvSecdefPost**
> Secdef TrsrvSecdefPost (Body body)

Secdef by Conid

Returns a list of security definitions for the given conids

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrsrvSecdefPostExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var body = new Body(); // Body | request body

            try
            {
                // Secdef by Conid
                Secdef result = apiInstance.TrsrvSecdefPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.TrsrvSecdefPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| request body | 

### Return type

[**Secdef**](Secdef.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trsrvsecdefscheduleget"></a>
# **TrsrvSecdefScheduleGet**
> Object TrsrvSecdefScheduleGet (string assetClass, string symbol, string exchange = null)

Get trading schedule for symbol

Returns the trading schedule up to a month for the requested contract

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrsrvSecdefScheduleGetExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var assetClass = assetClass_example;  // string | specify the asset class of the contract. Available values- - Stock: STK, Option: OPT, Future: FUT, Contract For Difference: CFD, Warrant: WAR, Forex: SWP, Mutual Fund: FND, Bond: BND, Inter-Commodity Spreads: ICS 
            var symbol = symbol_example;  // string | Underlying Symbol for specified contract, for example 'AAPL' for US Stock - Apple Inc.
            var exchange = exchange_example;  // string | Native exchange for contract, for example 'NASDAQ' for US Stock - Apple Inc. (optional) 

            try
            {
                // Get trading schedule for symbol
                Object result = apiInstance.TrsrvSecdefScheduleGet(assetClass, symbol, exchange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.TrsrvSecdefScheduleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetClass** | **string**| specify the asset class of the contract. Available values- - Stock: STK, Option: OPT, Future: FUT, Contract For Difference: CFD, Warrant: WAR, Forex: SWP, Mutual Fund: FND, Bond: BND, Inter-Commodity Spreads: ICS  | 
 **symbol** | **string**| Underlying Symbol for specified contract, for example &#39;AAPL&#39; for US Stock - Apple Inc. | 
 **exchange** | **string**| Native exchange for contract, for example &#39;NASDAQ&#39; for US Stock - Apple Inc. | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trsrvstocksget"></a>
# **TrsrvStocksGet**
> Object TrsrvStocksGet (string symbols)

Security Stocks by Symbol

Returns an object contains all stock contracts for given symbol(s)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TrsrvStocksGetExample
    {
        public void main()
        {
            var apiInstance = new ContractApi();
            var symbols = symbols_example;  // string | list of upper-sensitive symbols separated by comma

            try
            {
                // Security Stocks by Symbol
                Object result = apiInstance.TrsrvStocksGet(symbols);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractApi.TrsrvStocksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbols** | **string**| list of upper-sensitive symbols separated by comma | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


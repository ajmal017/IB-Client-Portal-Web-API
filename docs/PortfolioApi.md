# IO.Swagger.Api.PortfolioApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PortfolioAccountIdAllocationGet**](PortfolioApi.md#portfolioaccountidallocationget) | **GET** /portfolio/{accountId}/allocation | Account Allocation
[**PortfolioAccountIdLedgerGet**](PortfolioApi.md#portfolioaccountidledgerget) | **GET** /portfolio/{accountId}/ledger | Account Ledger
[**PortfolioAccountIdMetaGet**](PortfolioApi.md#portfolioaccountidmetaget) | **GET** /portfolio/{accountId}/meta | Account Information
[**PortfolioAccountIdPositionConidGet**](PortfolioApi.md#portfolioaccountidpositionconidget) | **GET** /portfolio/{accountId}/position/{conid} | Position by Conid
[**PortfolioAccountIdPositionsInvalidatePost**](PortfolioApi.md#portfolioaccountidpositionsinvalidatepost) | **POST** /portfolio/{accountId}/positions/invalidate | Invalidates the backend cache of the Portfolio
[**PortfolioAccountIdPositionsPageIdGet**](PortfolioApi.md#portfolioaccountidpositionspageidget) | **GET** /portfolio/{accountId}/positions/{pageId} | Portfolio Positions
[**PortfolioAccountIdSummaryGet**](PortfolioApi.md#portfolioaccountidsummaryget) | **GET** /portfolio/{accountId}/summary | Account Summary
[**PortfolioAccountsGet**](PortfolioApi.md#portfolioaccountsget) | **GET** /portfolio/accounts | Portfolio Accounts
[**PortfolioAllocationPost**](PortfolioApi.md#portfolioallocationpost) | **POST** /portfolio/allocation | Account Alloction (All Accounts)
[**PortfolioPositionsConidGet**](PortfolioApi.md#portfoliopositionsconidget) | **GET** /portfolio/positions/{conid} | Positions by Conid
[**PortfolioSubaccountsGet**](PortfolioApi.md#portfoliosubaccountsget) | **GET** /portfolio/subaccounts | List of Sub-Accounts


<a name="portfolioaccountidallocationget"></a>
# **PortfolioAccountIdAllocationGet**
> Allocation PortfolioAccountIdAllocationGet (string accountId)

Account Allocation

Information about the account's portfolio allocation by Asset Class, Industry and Category.  /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountIdAllocationGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Account Allocation
                Allocation result = apiInstance.PortfolioAccountIdAllocationGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountIdAllocationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 

### Return type

[**Allocation**](Allocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioaccountidledgerget"></a>
# **PortfolioAccountIdLedgerGet**
> Object PortfolioAccountIdLedgerGet (string accountId)

Account Ledger

Information regarding settled cash, cash balances, etc. in the account's base currency and any other cash balances hold in other currencies.  /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint. The list of supported currencies is available at https://www.interactivebrokers.com/en/index.php?f=3185.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountIdLedgerGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Account Ledger
                Object result = apiInstance.PortfolioAccountIdLedgerGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountIdLedgerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioaccountidmetaget"></a>
# **PortfolioAccountIdMetaGet**
> Accounts PortfolioAccountIdMetaGet (string accountId)

Account Information

Account information related to account Id /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountIdMetaGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Account Information
                Accounts result = apiInstance.PortfolioAccountIdMetaGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountIdMetaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 

### Return type

[**Accounts**](Accounts.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioaccountidpositionconidget"></a>
# **PortfolioAccountIdPositionConidGet**
> Position PortfolioAccountIdPositionConidGet (string accountId, int? conid)

Position by Conid

Returns a list of all positions matching the conid. For portfolio models the conid could be in more than one model, returning an array with the name of the model it belongs to.  /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountIdPositionConidGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var accountId = accountId_example;  // string | account id
            var conid = 56;  // int? | contract id

            try
            {
                // Position by Conid
                Position result = apiInstance.PortfolioAccountIdPositionConidGet(accountId, conid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountIdPositionConidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 
 **conid** | **int?**| contract id | 

### Return type

[**Position**](Position.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioaccountidpositionsinvalidatepost"></a>
# **PortfolioAccountIdPositionsInvalidatePost**
> Object PortfolioAccountIdPositionsInvalidatePost (string accountId)

Invalidates the backend cache of the Portfolio

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountIdPositionsInvalidatePostExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Invalidates the backend cache of the Portfolio
                Object result = apiInstance.PortfolioAccountIdPositionsInvalidatePost(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountIdPositionsInvalidatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioaccountidpositionspageidget"></a>
# **PortfolioAccountIdPositionsPageIdGet**
> Position PortfolioAccountIdPositionsPageIdGet (string accountId, string pageId, string model = null, string sort = null, string direction = null, string period = null)

Portfolio Positions

Returns a list of positions for the given account. The endpoint supports paging, page's default size is 30 positions. /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountIdPositionsPageIdGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var accountId = accountId_example;  // string | account id
            var pageId = pageId_example;  // string | page id
            var model = model_example;  // string | optional (optional) 
            var sort = sort_example;  // string | declare the table to be sorted by which column (optional) 
            var direction = direction_example;  // string | in which order, a means ascending - d means descending (optional) 
            var period = period_example;  // string | period for pnl column, can be 1D, 7D, 1M... (optional) 

            try
            {
                // Portfolio Positions
                Position result = apiInstance.PortfolioAccountIdPositionsPageIdGet(accountId, pageId, model, sort, direction, period);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountIdPositionsPageIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 
 **pageId** | **string**| page id | 
 **model** | **string**| optional | [optional] 
 **sort** | **string**| declare the table to be sorted by which column | [optional] 
 **direction** | **string**| in which order, a means ascending - d means descending | [optional] 
 **period** | **string**| period for pnl column, can be 1D, 7D, 1M... | [optional] 

### Return type

[**Position**](Position.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioaccountidsummaryget"></a>
# **PortfolioAccountIdSummaryGet**
> Object PortfolioAccountIdSummaryGet (string accountId)

Account Summary

Returns information about margin, cash balances and other information related to specified account. See also /portfolio/{accountId}/ledger. /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountIdSummaryGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Account Summary
                Object result = apiInstance.PortfolioAccountIdSummaryGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountIdSummaryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioaccountsget"></a>
# **PortfolioAccountsGet**
> Accounts PortfolioAccountsGet ()

Portfolio Accounts

In non-tiered account structures, returns a list of accounts for which the user can view position and account information. This endpoint must be called prior  to calling other /portfolio endpoints for those accounts. For querying a list of accounts  which the user can trade, see /iserver/accounts. For a list of subaccounts in tiered  account structures (e.g. financial advisor or ibroker accounts) see /portfolio/subaccounts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAccountsGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();

            try
            {
                // Portfolio Accounts
                Accounts result = apiInstance.PortfolioAccountsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAccountsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Accounts**](Accounts.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfolioallocationpost"></a>
# **PortfolioAllocationPost**
> Allocation PortfolioAllocationPost (Body body)

Account Alloction (All Accounts)

Similar to /portfolio/{accountId}/allocation but returns a consolidated view of of all the accounts returned by /portfolio/accounts. /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioAllocationPostExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var body = new Body(); // Body | accounts info

            try
            {
                // Account Alloction (All Accounts)
                Allocation result = apiInstance.PortfolioAllocationPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioAllocationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| accounts info | 

### Return type

[**Allocation**](Allocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfoliopositionsconidget"></a>
# **PortfolioPositionsConidGet**
> Object PortfolioPositionsConidGet (int? conid)

Positions by Conid

Returns an object of all positions matching the conid for all the selected accounts. For portfolio models the conid could be in more than one model, returning an array with the name of the model it belongs to. /portfolio/accounts or /portfolio/subaccounts must be called prior to this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioPositionsConidGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();
            var conid = 56;  // int? | contract id

            try
            {
                // Positions by Conid
                Object result = apiInstance.PortfolioPositionsConidGet(conid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioPositionsConidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conid** | **int?**| contract id | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portfoliosubaccountsget"></a>
# **PortfolioSubaccountsGet**
> Account PortfolioSubaccountsGet ()

List of Sub-Accounts

Used in tiered account structures (such as financial advisor and ibroker accounts)  to return a list of sub-accounts for which the user can view position and  account-related information. This endpoint must be called prior to calling other  /portfolio endpoints for those subaccounts.  To query a list of accounts the user can trade, see /iserver/accounts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PortfolioSubaccountsGetExample
    {
        public void main()
        {
            var apiInstance = new PortfolioApi();

            try
            {
                // List of Sub-Accounts
                Account result = apiInstance.PortfolioSubaccountsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfolioApi.PortfolioSubaccountsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# IO.Swagger.Api.AccountApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverAccountPnlPartitionedGet**](AccountApi.md#iserveraccountpnlpartitionedget) | **GET** /iserver/account/pnl/partitioned | PnL for the selected account
[**IserverAccountPost**](AccountApi.md#iserveraccountpost) | **POST** /iserver/account | Switch Account
[**IserverAccountsGet**](AccountApi.md#iserveraccountsget) | **GET** /iserver/accounts | Brokerage Accounts
[**PortfolioAccountIdLedgerGet**](AccountApi.md#portfolioaccountidledgerget) | **GET** /portfolio/{accountId}/ledger | Account Ledger
[**PortfolioAccountIdMetaGet**](AccountApi.md#portfolioaccountidmetaget) | **GET** /portfolio/{accountId}/meta | Account Information
[**PortfolioAccountIdSummaryGet**](AccountApi.md#portfolioaccountidsummaryget) | **GET** /portfolio/{accountId}/summary | Account Summary
[**PortfolioAccountsGet**](AccountApi.md#portfolioaccountsget) | **GET** /portfolio/accounts | Portfolio Accounts
[**PortfolioSubaccountsGet**](AccountApi.md#portfoliosubaccountsget) | **GET** /portfolio/subaccounts | List of Sub-Accounts


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
            var apiInstance = new AccountApi();

            try
            {
                // PnL for the selected account
                Object result = apiInstance.IserverAccountPnlPartitionedGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.IserverAccountPnlPartitionedGet: " + e.Message );
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

<a name="iserveraccountpost"></a>
# **IserverAccountPost**
> Object IserverAccountPost (SetAccount body)

Switch Account

If an user has multiple accounts, and user wants to get orders, trades, etc. of an account other than currently selected account, then user can update the currently selected account using this API and then can fetch required information for the newly updated account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountPostExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var body = new SetAccount(); // SetAccount | account id

            try
            {
                // Switch Account
                Object result = apiInstance.IserverAccountPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.IserverAccountPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SetAccount**](SetAccount.md)| account id | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountsget"></a>
# **IserverAccountsGet**
> Object IserverAccountsGet ()

Brokerage Accounts

Returns a list of accounts the user has trading access to, their respective aliases and the currently selected account. Note this endpoint must be called before modifying an order or querying open orders.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountsGetExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();

            try
            {
                // Brokerage Accounts
                Object result = apiInstance.IserverAccountsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.IserverAccountsGet: " + e.Message );
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
            var apiInstance = new AccountApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Account Ledger
                Object result = apiInstance.PortfolioAccountIdLedgerGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PortfolioAccountIdLedgerGet: " + e.Message );
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
            var apiInstance = new AccountApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Account Information
                Accounts result = apiInstance.PortfolioAccountIdMetaGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PortfolioAccountIdMetaGet: " + e.Message );
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
            var apiInstance = new AccountApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Account Summary
                Object result = apiInstance.PortfolioAccountIdSummaryGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PortfolioAccountIdSummaryGet: " + e.Message );
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
            var apiInstance = new AccountApi();

            try
            {
                // Portfolio Accounts
                Accounts result = apiInstance.PortfolioAccountsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PortfolioAccountsGet: " + e.Message );
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
            var apiInstance = new AccountApi();

            try
            {
                // List of Sub-Accounts
                Account result = apiInstance.PortfolioSubaccountsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.PortfolioSubaccountsGet: " + e.Message );
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


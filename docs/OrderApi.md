# IO.Swagger.Api.OrderApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverAccountAccountIdOrderOrderIdDelete**](OrderApi.md#iserveraccountaccountidorderorderiddelete) | **DELETE** /iserver/account/{accountId}/order/{orderId} | Cancel Order
[**IserverAccountAccountIdOrderOrderIdPost**](OrderApi.md#iserveraccountaccountidorderorderidpost) | **POST** /iserver/account/{accountId}/order/{orderId} | Modify Order
[**IserverAccountAccountIdOrderPost**](OrderApi.md#iserveraccountaccountidorderpost) | **POST** /iserver/account/{accountId}/order | Place Order
[**IserverAccountAccountIdOrderWhatifPost**](OrderApi.md#iserveraccountaccountidorderwhatifpost) | **POST** /iserver/account/{accountId}/order/whatif | Preview Order
[**IserverAccountAccountIdOrdersPost**](OrderApi.md#iserveraccountaccountidorderspost) | **POST** /iserver/account/{accountId}/orders | Place Orders (Support bracket orders)
[**IserverAccountOrdersFaGroupPost**](OrderApi.md#iserveraccountordersfagrouppost) | **POST** /iserver/account/orders/{faGroup} | Place Orders for Financial Advisor Groups
[**IserverAccountOrdersGet**](OrderApi.md#iserveraccountordersget) | **GET** /iserver/account/orders | Live Orders
[**IserverReplyReplyidPost**](OrderApi.md#iserverreplyreplyidpost) | **POST** /iserver/reply/{replyid} | Place Order Reply


<a name="iserveraccountaccountidorderorderiddelete"></a>
# **IserverAccountAccountIdOrderOrderIdDelete**
> Object IserverAccountAccountIdOrderOrderIdDelete (string accountId, string orderId)

Cancel Order

Cancels an open order. Must call /iserver/accounts endpoint prior to cancelling an order. Use /iservers/account/orders endpoint to review open-order(s) and get latest order status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdOrderOrderIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var accountId = accountId_example;  // string | account id, or fa group if deleting a group order
            var orderId = orderId_example;  // string | Customer order id, use /iservers/account/orders endpoint to query orderId.

            try
            {
                // Cancel Order
                Object result = apiInstance.IserverAccountAccountIdOrderOrderIdDelete(accountId, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverAccountAccountIdOrderOrderIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id, or fa group if deleting a group order | 
 **orderId** | **string**| Customer order id, use /iservers/account/orders endpoint to query orderId. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountaccountidorderorderidpost"></a>
# **IserverAccountAccountIdOrderOrderIdPost**
> List<Object> IserverAccountAccountIdOrderOrderIdPost (string accountId, string orderId, ModifyOrder body)

Modify Order

Modifies an open order. Must call /iserver/accounts endpoint prior to modifying an order. Use /iservers/account/orders endpoint to review open-order(s).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdOrderOrderIdPostExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var accountId = accountId_example;  // string | account id, or fa group if modifying a group order
            var orderId = orderId_example;  // string | Customer order id, use /iservers/account/orders endpoint to query orderId.
            var body = new ModifyOrder(); // ModifyOrder | modify-order request

            try
            {
                // Modify Order
                List&lt;Object&gt; result = apiInstance.IserverAccountAccountIdOrderOrderIdPost(accountId, orderId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverAccountAccountIdOrderOrderIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id, or fa group if modifying a group order | 
 **orderId** | **string**| Customer order id, use /iservers/account/orders endpoint to query orderId. | 
 **body** | [**ModifyOrder**](ModifyOrder.md)| modify-order request | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountaccountidorderpost"></a>
# **IserverAccountAccountIdOrderPost**
> List<Object> IserverAccountAccountIdOrderPost (string accountId, OrderRequest body)

Place Order

Please note here, sometimes this endpoint alone can't make sure you submit the order successfully, you could receive some questions in the response, you have to to answer them in order to submit the order successfully. You can use \"/iserver/reply/{replyid}\" endpoint to answer questions 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdOrderPostExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var accountId = accountId_example;  // string | account id
            var body = new OrderRequest(); // OrderRequest | order request info

            try
            {
                // Place Order
                List&lt;Object&gt; result = apiInstance.IserverAccountAccountIdOrderPost(accountId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverAccountAccountIdOrderPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 
 **body** | [**OrderRequest**](OrderRequest.md)| order request info | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountaccountidorderwhatifpost"></a>
# **IserverAccountAccountIdOrderWhatifPost**
> Object IserverAccountAccountIdOrderWhatifPost (string accountId, OrderRequest body)

Preview Order

This endpoint allows you to preview order without actually submitting the order and you can get commission information in the response. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdOrderWhatifPostExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var accountId = accountId_example;  // string | account id
            var body = new OrderRequest(); // OrderRequest | order info

            try
            {
                // Preview Order
                Object result = apiInstance.IserverAccountAccountIdOrderWhatifPost(accountId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverAccountAccountIdOrderWhatifPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 
 **body** | [**OrderRequest**](OrderRequest.md)| order info | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountaccountidorderspost"></a>
# **IserverAccountAccountIdOrdersPost**
> List<Object> IserverAccountAccountIdOrdersPost (string accountId, Body body)

Place Orders (Support bracket orders)

You can pass a list of orders here 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdOrdersPostExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var accountId = accountId_example;  // string | account id
            var body = new Body(); // Body | order request info

            try
            {
                // Place Orders (Support bracket orders)
                List&lt;Object&gt; result = apiInstance.IserverAccountAccountIdOrdersPost(accountId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverAccountAccountIdOrdersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 
 **body** | [**Body**](Body.md)| order request info | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountordersfagrouppost"></a>
# **IserverAccountOrdersFaGroupPost**
> List<Object> IserverAccountOrdersFaGroupPost (string faGroup, OrderRequest body)

Place Orders for Financial Advisor Groups

Financial Advisors can use this endpoint to place an order for a specified group. To place an order for a specified account use the endpoint /iserver/account/{accountId}/order. More information about groups can be found in the [TWS Users' Guide:](https://guides.interactivebrokers.com/twsguide/twsguide.htm#usersguidebook/financialadvisors/create_an_account_group_for_share_allocation.htm). 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountOrdersFaGroupPostExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var faGroup = faGroup_example;  // string | financial advisor group
            var body = new OrderRequest(); // OrderRequest | order request info

            try
            {
                // Place Orders for Financial Advisor Groups
                List&lt;Object&gt; result = apiInstance.IserverAccountOrdersFaGroupPost(faGroup, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverAccountOrdersFaGroupPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **faGroup** | **string**| financial advisor group | 
 **body** | [**OrderRequest**](OrderRequest.md)| order request info | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountordersget"></a>
# **IserverAccountOrdersGet**
> Object IserverAccountOrdersGet (Body body = null)

Live Orders

The endpoint is meant to be used in polling mode, e.g. requesting every x seconds. The response will contain two objects, one is notification, the other is orders.  Orders is the list of live orders (cancelled, filled, submitted).  Notifications contains information about execute orders as they happen, see status field. To receive streaming live orders the endpoint /ws can be used. Refer to [Streaming WebSocket Data](https://interactivebrokers.github.io/cpwebapi/RealtimeSubscription.html) for details. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountOrdersGetExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var body = new Body(); // Body | an array of filters (optional) 

            try
            {
                // Live Orders
                Object result = apiInstance.IserverAccountOrdersGet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverAccountOrdersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| an array of filters | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserverreplyreplyidpost"></a>
# **IserverReplyReplyidPost**
> List<Object> IserverReplyReplyidPost (string replyid, Body body)

Place Order Reply

Reply to questions when placing orders and submit orders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverReplyReplyidPostExample
    {
        public void main()
        {
            var apiInstance = new OrderApi();
            var replyid = replyid_example;  // string | Please use the \"id\" from the response of \"Place Order\" endpoint
            var body = new Body(); // Body | Answer to question

            try
            {
                // Place Order Reply
                List&lt;Object&gt; result = apiInstance.IserverReplyReplyidPost(replyid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.IserverReplyReplyidPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **replyid** | **string**| Please use the \&quot;id\&quot; from the response of \&quot;Place Order\&quot; endpoint | 
 **body** | [**Body**](Body.md)| Answer to question | 

### Return type

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


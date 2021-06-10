# IO.Swagger.Api.AlertApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverAccountAccountIdAlertActivatePost**](AlertApi.md#iserveraccountaccountidalertactivatepost) | **POST** /iserver/account/{accountId}/alert/activate | Activate or deactivate an alert
[**IserverAccountAccountIdAlertAlertIdDelete**](AlertApi.md#iserveraccountaccountidalertalertiddelete) | **DELETE** /iserver/account/{accountId}/alert/{alertId} | Delete an alert
[**IserverAccountAccountIdAlertPost**](AlertApi.md#iserveraccountaccountidalertpost) | **POST** /iserver/account/{accountId}/alert | Create or modify alert
[**IserverAccountAccountIdAlertsGet**](AlertApi.md#iserveraccountaccountidalertsget) | **GET** /iserver/account/{accountId}/alerts | Get a list of available alerts
[**IserverAccountAlertIdGet**](AlertApi.md#iserveraccountalertidget) | **GET** /iserver/account/alert/{id} | Get details of an alert
[**IserverAccountMtaGet**](AlertApi.md#iserveraccountmtaget) | **GET** /iserver/account/mta | Get MTA alert


<a name="iserveraccountaccountidalertactivatepost"></a>
# **IserverAccountAccountIdAlertActivatePost**
> Object IserverAccountAccountIdAlertActivatePost (string accountId, Body body)

Activate or deactivate an alert

Please note, if alertId is 0, it will activate/deactivate all alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdAlertActivatePostExample
    {
        public void main()
        {
            var apiInstance = new AlertApi();
            var accountId = accountId_example;  // string | account id
            var body = new Body(); // Body | order request info

            try
            {
                // Activate or deactivate an alert
                Object result = apiInstance.IserverAccountAccountIdAlertActivatePost(accountId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.IserverAccountAccountIdAlertActivatePost: " + e.Message );
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountaccountidalertalertiddelete"></a>
# **IserverAccountAccountIdAlertAlertIdDelete**
> Object IserverAccountAccountIdAlertAlertIdDelete (string accountId, string alertId)

Delete an alert

Please be careful, if alertId is 0, it will delete all alerts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdAlertAlertIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new AlertApi();
            var accountId = accountId_example;  // string | account id
            var alertId = alertId_example;  // string | alert id

            try
            {
                // Delete an alert
                Object result = apiInstance.IserverAccountAccountIdAlertAlertIdDelete(accountId, alertId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.IserverAccountAccountIdAlertAlertIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 
 **alertId** | **string**| alert id | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountaccountidalertpost"></a>
# **IserverAccountAccountIdAlertPost**
> Object IserverAccountAccountIdAlertPost (string accountId, AlertRequest body)

Create or modify alert

Please note here, DO NOT pass orderId when creating a new alert, toolId is only required for MTA alert 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdAlertPostExample
    {
        public void main()
        {
            var apiInstance = new AlertApi();
            var accountId = accountId_example;  // string | account id
            var body = new AlertRequest(); // AlertRequest | alert info

            try
            {
                // Create or modify alert
                Object result = apiInstance.IserverAccountAccountIdAlertPost(accountId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.IserverAccountAccountIdAlertPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| account id | 
 **body** | [**AlertRequest**](AlertRequest.md)| alert info | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountaccountidalertsget"></a>
# **IserverAccountAccountIdAlertsGet**
> List<Object> IserverAccountAccountIdAlertsGet (string accountId)

Get a list of available alerts

The response will contain both active and inactive alerts, but it won't have MTA alert

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAccountIdAlertsGetExample
    {
        public void main()
        {
            var apiInstance = new AlertApi();
            var accountId = accountId_example;  // string | account id

            try
            {
                // Get a list of available alerts
                List&lt;Object&gt; result = apiInstance.IserverAccountAccountIdAlertsGet(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.IserverAccountAccountIdAlertsGet: " + e.Message );
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

**List<Object>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountalertidget"></a>
# **IserverAccountAlertIdGet**
> AlertResponse IserverAccountAlertIdGet (string id)

Get details of an alert

Use the endpoint /iserver/account/{accountId}/alerts to receive the alert id. The order_id in the response is the alert id. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountAlertIdGetExample
    {
        public void main()
        {
            var apiInstance = new AlertApi();
            var id = id_example;  // string | alert id

            try
            {
                // Get details of an alert
                AlertResponse result = apiInstance.IserverAccountAlertIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.IserverAccountAlertIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| alert id | 

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserveraccountmtaget"></a>
# **IserverAccountMtaGet**
> AlertResponse IserverAccountMtaGet ()

Get MTA alert

Each login user only has one mobile trading assistant (MTA) alert with it's own unique tool id. The tool id cannot be changed. When modified a new order Id is generated. MTA alerts can not be created or deleted. If you call delete /iserver/account/{accountId}/alert/{alertId}, it will reset MTA to default. See [here](https://www.interactivebrokers.com/en/software/mobileiphonemobile/mobileiphone.htm#monitor/trading-assistant.htm) for more information on MTA alerts. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAccountMtaGetExample
    {
        public void main()
        {
            var apiInstance = new AlertApi();

            try
            {
                // Get MTA alert
                AlertResponse result = apiInstance.IserverAccountMtaGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertApi.IserverAccountMtaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AlertResponse**](AlertResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


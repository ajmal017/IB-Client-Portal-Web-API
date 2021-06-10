# IO.Swagger.Api.FYIApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FyiDeliveryoptionsDeviceIdDelete**](FYIApi.md#fyideliveryoptionsdeviceiddelete) | **DELETE** /fyi/deliveryoptions/{deviceId} | Delete a device
[**FyiDeliveryoptionsDevicePost**](FYIApi.md#fyideliveryoptionsdevicepost) | **POST** /fyi/deliveryoptions/device | Enable/Disable device option
[**FyiDeliveryoptionsEmailPut**](FYIApi.md#fyideliveryoptionsemailput) | **PUT** /fyi/deliveryoptions/email | Enable/Disable email option
[**FyiDeliveryoptionsGet**](FYIApi.md#fyideliveryoptionsget) | **GET** /fyi/deliveryoptions | Get delivery options
[**FyiDisclaimerTypecodeGet**](FYIApi.md#fyidisclaimertypecodeget) | **GET** /fyi/disclaimer/{typecode} | Get disclaimer for a certain kind of fyi
[**FyiDisclaimerTypecodePut**](FYIApi.md#fyidisclaimertypecodeput) | **PUT** /fyi/disclaimer/{typecode} | Mark disclaimer read
[**FyiNotificationsGet**](FYIApi.md#fyinotificationsget) | **GET** /fyi/notifications | Get a list of notifications
[**FyiNotificationsMoreGet**](FYIApi.md#fyinotificationsmoreget) | **GET** /fyi/notifications/more | Get more notifications based on a certain one
[**FyiNotificationsNotificationIdPut**](FYIApi.md#fyinotificationsnotificationidput) | **PUT** /fyi/notifications/{notificationId} | Get a list of notifications
[**FyiSettingsGet**](FYIApi.md#fyisettingsget) | **GET** /fyi/settings | Get a list of subscriptions
[**FyiSettingsTypecodePost**](FYIApi.md#fyisettingstypecodepost) | **POST** /fyi/settings/{typecode} | Enable/Disable certain subscription
[**FyiUnreadnumberGet**](FYIApi.md#fyiunreadnumberget) | **GET** /fyi/unreadnumber | Get unread number of fyis. The HTTP method POST is also supported.


<a name="fyideliveryoptionsdeviceiddelete"></a>
# **FyiDeliveryoptionsDeviceIdDelete**
> Object FyiDeliveryoptionsDeviceIdDelete (string deviceId)

Delete a device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiDeliveryoptionsDeviceIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var deviceId = deviceId_example;  // string | device ID

            try
            {
                // Delete a device
                Object result = apiInstance.FyiDeliveryoptionsDeviceIdDelete(deviceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiDeliveryoptionsDeviceIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| device ID | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyideliveryoptionsdevicepost"></a>
# **FyiDeliveryoptionsDevicePost**
> Object FyiDeliveryoptionsDevicePost (Body body)

Enable/Disable device option

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiDeliveryoptionsDevicePostExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var body = new Body(); // Body | device info

            try
            {
                // Enable/Disable device option
                Object result = apiInstance.FyiDeliveryoptionsDevicePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiDeliveryoptionsDevicePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| device info | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyideliveryoptionsemailput"></a>
# **FyiDeliveryoptionsEmailPut**
> Object FyiDeliveryoptionsEmailPut (string enabled)

Enable/Disable email option

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiDeliveryoptionsEmailPutExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var enabled = enabled_example;  // string | true/false

            try
            {
                // Enable/Disable email option
                Object result = apiInstance.FyiDeliveryoptionsEmailPut(enabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiDeliveryoptionsEmailPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enabled** | **string**| true/false | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyideliveryoptionsget"></a>
# **FyiDeliveryoptionsGet**
> Object FyiDeliveryoptionsGet ()

Get delivery options

options for sending fyis to email and other devices 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiDeliveryoptionsGetExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();

            try
            {
                // Get delivery options
                Object result = apiInstance.FyiDeliveryoptionsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiDeliveryoptionsGet: " + e.Message );
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

<a name="fyidisclaimertypecodeget"></a>
# **FyiDisclaimerTypecodeGet**
> Object FyiDisclaimerTypecodeGet (string typecode)

Get disclaimer for a certain kind of fyi

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiDisclaimerTypecodeGetExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var typecode = typecode_example;  // string | fyi code, for example - -M8, EA

            try
            {
                // Get disclaimer for a certain kind of fyi
                Object result = apiInstance.FyiDisclaimerTypecodeGet(typecode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiDisclaimerTypecodeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typecode** | **string**| fyi code, for example - -M8, EA | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyidisclaimertypecodeput"></a>
# **FyiDisclaimerTypecodePut**
> Object FyiDisclaimerTypecodePut (string typecode)

Mark disclaimer read

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiDisclaimerTypecodePutExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var typecode = typecode_example;  // string | fyi code, for example - -M8, EA

            try
            {
                // Mark disclaimer read
                Object result = apiInstance.FyiDisclaimerTypecodePut(typecode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiDisclaimerTypecodePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typecode** | **string**| fyi code, for example - -M8, EA | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyinotificationsget"></a>
# **FyiNotificationsGet**
> Notifications FyiNotificationsGet (string max, string exclude = null, string include = null)

Get a list of notifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiNotificationsGetExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var max = max_example;  // string | max number of fyis in response
            var exclude = exclude_example;  // string | if set, don't set include (optional) 
            var include = include_example;  // string | if set, don't set exclude (optional) 

            try
            {
                // Get a list of notifications
                Notifications result = apiInstance.FyiNotificationsGet(max, exclude, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiNotificationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **max** | **string**| max number of fyis in response | 
 **exclude** | **string**| if set, don&#39;t set include | [optional] 
 **include** | **string**| if set, don&#39;t set exclude | [optional] 

### Return type

[**Notifications**](Notifications.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyinotificationsmoreget"></a>
# **FyiNotificationsMoreGet**
> Notifications FyiNotificationsMoreGet (string id)

Get more notifications based on a certain one

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiNotificationsMoreGetExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var id = id_example;  // string | id of last notification in the list

            try
            {
                // Get more notifications based on a certain one
                Notifications result = apiInstance.FyiNotificationsMoreGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiNotificationsMoreGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id of last notification in the list | 

### Return type

[**Notifications**](Notifications.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyinotificationsnotificationidput"></a>
# **FyiNotificationsNotificationIdPut**
> Object FyiNotificationsNotificationIdPut (string notificationId)

Get a list of notifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiNotificationsNotificationIdPutExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var notificationId = notificationId_example;  // string | mark a notification read

            try
            {
                // Get a list of notifications
                Object result = apiInstance.FyiNotificationsNotificationIdPut(notificationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiNotificationsNotificationIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **string**| mark a notification read | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyisettingsget"></a>
# **FyiSettingsGet**
> List<Object> FyiSettingsGet ()

Get a list of subscriptions

Return the current choices of subscriptions, we can toggle the option 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiSettingsGetExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();

            try
            {
                // Get a list of subscriptions
                List&lt;Object&gt; result = apiInstance.FyiSettingsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiSettingsGet: " + e.Message );
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

<a name="fyisettingstypecodepost"></a>
# **FyiSettingsTypecodePost**
> Object FyiSettingsTypecodePost (string typecode, Body body)

Enable/Disable certain subscription

Configure which typecode you would like to enable/disable. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiSettingsTypecodePostExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();
            var typecode = typecode_example;  // string | fyi code
            var body = new Body(); // Body | 

            try
            {
                // Enable/Disable certain subscription
                Object result = apiInstance.FyiSettingsTypecodePost(typecode, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiSettingsTypecodePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **typecode** | **string**| fyi code | 
 **body** | [**Body**](Body.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fyiunreadnumberget"></a>
# **FyiUnreadnumberGet**
> Object FyiUnreadnumberGet ()

Get unread number of fyis. The HTTP method POST is also supported.

Returns the total number of unread fyis 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FyiUnreadnumberGetExample
    {
        public void main()
        {
            var apiInstance = new FYIApi();

            try
            {
                // Get unread number of fyis. The HTTP method POST is also supported.
                Object result = apiInstance.FyiUnreadnumberGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FYIApi.FyiUnreadnumberGet: " + e.Message );
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


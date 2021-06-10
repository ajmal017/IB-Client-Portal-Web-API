# IO.Swagger.Api.SessionApi

All URIs are relative to *https://localhost:5000/v1/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IserverAuthStatusPost**](SessionApi.md#iserverauthstatuspost) | **POST** /iserver/auth/status | Authentication Status
[**IserverReauthenticatePost**](SessionApi.md#iserverreauthenticatepost) | **POST** /iserver/reauthenticate | Tries to re-authenticate to Brokerage
[**LogoutPost**](SessionApi.md#logoutpost) | **POST** /logout | Ends the current session
[**SsoValidateGet**](SessionApi.md#ssovalidateget) | **GET** /sso/validate | Validate SSO
[**TicklePost**](SessionApi.md#ticklepost) | **POST** /tickle | Ping the server to keep the session open


<a name="iserverauthstatuspost"></a>
# **IserverAuthStatusPost**
> AuthStatus IserverAuthStatusPost ()

Authentication Status

Current Authentication status to the Brokerage system. Market Data and Trading is not possible if not authenticated, e.g. authenticated shows false

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverAuthStatusPostExample
    {
        public void main()
        {
            var apiInstance = new SessionApi();

            try
            {
                // Authentication Status
                AuthStatus result = apiInstance.IserverAuthStatusPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.IserverAuthStatusPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AuthStatus**](AuthStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="iserverreauthenticatepost"></a>
# **IserverReauthenticatePost**
> AuthStatus IserverReauthenticatePost ()

Tries to re-authenticate to Brokerage

When using the CP Gateway, this endpoint provides a way to reauthenticate to the Brokerage system as long as there is a valid SSO session, see /sso/validate. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IserverReauthenticatePostExample
    {
        public void main()
        {
            var apiInstance = new SessionApi();

            try
            {
                // Tries to re-authenticate to Brokerage
                AuthStatus result = apiInstance.IserverReauthenticatePost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.IserverReauthenticatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AuthStatus**](AuthStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoutpost"></a>
# **LogoutPost**
> Object LogoutPost ()

Ends the current session

Logs the user out of the gateway session. Any further activity requires re-authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogoutPostExample
    {
        public void main()
        {
            var apiInstance = new SessionApi();

            try
            {
                // Ends the current session
                Object result = apiInstance.LogoutPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.LogoutPost: " + e.Message );
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

<a name="ssovalidateget"></a>
# **SsoValidateGet**
> Object SsoValidateGet ()

Validate SSO

Validates the current session for the SSO user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SsoValidateGetExample
    {
        public void main()
        {
            var apiInstance = new SessionApi();

            try
            {
                // Validate SSO
                Object result = apiInstance.SsoValidateGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SsoValidateGet: " + e.Message );
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

<a name="ticklepost"></a>
# **TicklePost**
> void TicklePost ()

Ping the server to keep the session open

If the gateway has not received any requests for several minutes an open session will automatically timeout. The tickle endpoint pings the server to prevent the session from ending.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TicklePostExample
    {
        public void main()
        {
            var apiInstance = new SessionApi();

            try
            {
                // Ping the server to keep the session open
                apiInstance.TicklePost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.TicklePost: " + e.Message );
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


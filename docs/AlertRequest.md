# IO.Swagger.Model.AlertRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **int?** | orderId is required when modifying alert. You can get it from /iserver/account/{accountId}/alerts  | [optional] 
**AlertName** | **string** | name of alert | [optional] 
**AlertMessage** | **string** | The message you want to receive via email or text message | [optional] 
**AlertRepeatable** | **int?** | whether alert is repeatable or not, so value can only be 0 or 1, this has to be 1 for MTA alert | [optional] 
**Email** | **string** | email address to receive alert | [optional] 
**SendMessage** | **int?** | whether allowing to send email or not, so value can only be 0 or 1,  | [optional] 
**Tif** | **string** | time in force, can only be GTC or GTD | [optional] 
**ExpireTime** | **string** | format, YYYYMMDD-HH:mm:ss, please NOTE this will only work when tif is GTD  | [optional] 
**OutsideRth** | **int?** | value can only be 0 or 1, set to 1 if the alert can be triggered outside regular trading hours.  | [optional] 
**ITWSOrdersOnly** | **int?** | value can only be 0 or 1, set to 1 to enable the alert only in IBKR mobile  | [optional] 
**ShowPopup** | **int?** | value can only be 0 or 1, set to 1 to allow to show alert in pop-ups | [optional] 
**ToolId** | **int?** | for MTA alert only, each user has a unique toolId and it will stay the same, do not send for normal alert  | [optional] 
**PlayAudio** | **string** | audio message to play when alert is triggered | [optional] 
**Conditions** | **List&lt;Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


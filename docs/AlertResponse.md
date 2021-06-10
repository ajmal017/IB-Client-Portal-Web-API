# IO.Swagger.Model.AlertResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | account id | [optional] 
**OrderId** | **int?** |  | [optional] 
**AlertName** | **string** | name of alert | [optional] 
**AlertMessage** | **string** | The message you want to receive via email or text message | [optional] 
**AlertActive** | **int?** | whether alert is active or not, so value can only be 0 or 1 | [optional] 
**AlertRepeatable** | **int?** | whether alert is repeatable or not, so value can only be 0 or 1 | [optional] 
**AlertEmail** | **string** | email address to receive alert | [optional] 
**AlertSendMessage** | **int?** | whether allowing to send email or not, so value can only be 0 or 1,  | [optional] 
**Tif** | **string** | time in force, can only be GTC or GTD | [optional] 
**ExpireTime** | **string** | format, YYYYMMDD-HH:mm:ss  | [optional] 
**OrderStatus** | **string** | status of alert | [optional] 
**OutsideRth** | **int?** | value can only be 0 or 1, set to 1 if the alert can be triggered outside regular trading hours.  | [optional] 
**ItwsOrdersOnly** | **int?** | value can only be 0 or 1, set to 1 to enable the alert only in IBKR mobile  | [optional] 
**AlertShowPopup** | **int?** | value can only be 0 or 1, set to 1 to allow to show alert in pop-ups | [optional] 
**AlertTriggered** | **bool?** | whether the alert has been triggered | [optional] 
**OrderNotEditable** | **bool?** | whether the alert can be edited | [optional] 
**ToolId** | **int?** | for MTA alert only, each user has a unique toolId and it will stay the same, do not send for normal alert  | [optional] 
**AlertPlayAudio** | **string** | audio message to play when alert is triggered | [optional] 
**AlertMtaCurrency** | **string** | MTA alert only | [optional] 
**AlertMtaDefaults** | **string** | MTA alert only | [optional] 
**TimeZone** | **string** | MTA alert only | [optional] 
**AlertDefaultType** | **string** | MTA alert only | [optional] 
**ConditionSize** | **int?** | size of conditions array | [optional] 
**ConditionOutsideRth** | **int?** | whether allowing the condition can be triggered outside of regular trading hours, 1 means allow | [optional] 
**Conditions** | **List&lt;Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# IO.Swagger.Model.Transactions
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | will always be getTransactions | [optional] 
**Currency** | **string** | same as request | [optional] 
**IncludesRealTime** | **bool?** | Indicates whether current day and realtime data is included in the result | [optional] 
**From** | **decimal?** | Period start date. Epoch time, GMT | [optional] 
**To** | **decimal?** | Period end date. Epoch time, GMT | [optional] 
**_Transactions** | **List&lt;Object&gt;** | Sorted by date descending | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


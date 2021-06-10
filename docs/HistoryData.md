# IO.Swagger.Model.HistoryData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | Underlying Symbol of the corresponding contract | [optional] 
**Text** | **string** | companyName of the corresponding contract | [optional] 
**PriceFactor** | **int?** | priceFactor is price increment obtained from display rule | [optional] 
**StartTime** | **string** | start date time in the format YYYYMMDD-HH:mm:ss | [optional] 
**High** | **string** | High value during this time series with format %h/%v/%t. %h is the high price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart  | [optional] 
**Low** | **string** | Low value during this time series with format %l/%v/%t. %l is the low price (scaled by priceFactor), %v is volume (volume factor will always be 100 (reported volume &#x3D; actual volume/100)) and %t is minutes from start time of the chart  | [optional] 
**TimePeriod** | **string** | The duration for the historical data request | [optional] 
**BarLength** | **int?** | The number of seconds in a bar | [optional] 
**MdAvailability** | **string** | Market Data Availability. The field may contain two chars. The first char is the primary code: S &#x3D; Streaming, R &#x3D; Realtime, D &#x3D; Delayed, Z &#x3D; Frozen, Y &#x3D; Frozen Delayed. The second char is the secondary code: P &#x3D; Snapshot Available, p &#x3D; Consolidated.  | [optional] 
**MktDataDelay** | **int?** | The time it takes, in milliseconds, to process the historical data request | [optional] 
**OutsideRth** | **bool?** | The historical data returned includes outside of regular trading hours  | [optional] 
**TradingDayDuration** | **int?** | The number of seconds in the trading day | [optional] 
**VolumeFactor** | **int?** |  | [optional] 
**PriceDisplayRule** | **int?** |  | [optional] 
**PriceDisplayValue** | **string** |  | [optional] 
**NegativeCapable** | **bool?** |  | [optional] 
**MessageVersion** | **int?** |  | [optional] 
**Data** | **List&lt;Object&gt;** |  | [optional] 
**Points** | **int?** | total number of points | [optional] 
**TravelTime** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


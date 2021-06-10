# IO.Swagger.Model.OrderRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcctId** | **string** | acctId is optional. It should be one of the accounts returned by /iserver/accounts. If not passed, the first one in the list is selected.  | [optional] 
**Conid** | **int?** | conid is the identifier of the security you want to trade, you can find the conid with /iserver/secdef/search.  | [optional] 
**SecType** | **string** | conid:type for example 265598:STK | [optional] 
**COID** | **string** | Customer Order ID. An arbitraty string that can be used to identify the order, e.g \&quot;my-fb-order\&quot;. The value must be unique for a 24h span. Please do not set this value for child orders when placing a bracket order.  | [optional] 
**ParentId** | **string** | When placing bracket orders, the child parentId must be equal to the cOId (customer order id) of the parent.  | [optional] 
**OrderType** | **string** | orderType can be one of MKT (Market), LMT (Limit), STP (Stop) or STP_LIMIT (stop limit)  | [optional] 
**ListingExchange** | **string** | listingExchange is optional. By default we use \&quot;SMART\&quot; routing. Possible values are available via this end point: /v1/portal/iserver/contract/{{conid}}/info, see valid_exchange: e.g: SMART,AMEX,NYSE, CBOE,ISE,CHX,ARCA,ISLAND,DRCTEDGE,BEX,BATS,EDGEA,CSFBALGO,JE FFALGO,BYX,IEX,FOXRIVER,TPLUS1,NYSENAT,PSX  | [optional] 
**OutsideRTH** | **bool?** | set to true if the order can be executed outside regular trading hours.  | [optional] 
**Price** | **decimal?** | optional if order is MKT, for LMT, this is the limit price. For STP this is the stop price.  | [optional] 
**Side** | **string** | SELL or BUY | [optional] 
**Ticker** | **string** |  | [optional] 
**Tif** | **string** | GTC (Good Till Cancel) or DAY. DAY orders are automatically cancelled at the end of the Day or Trading hours.  | [optional] 
**Referrer** | **string** | for example QuickTrade | [optional] 
**Quantity** | **decimal?** | usually integer, for some special cases can be float numbers | [optional] 
**FxQty** | **decimal?** | double number, this is the cash quantity field which can only be used for FX conversion order.  | [optional] 
**UseAdaptive** | **bool?** | If true, the system will use the Adaptive Algo to submit the order https://www.interactivebrokers.com/en/index.php?f&#x3D;19091  | [optional] 
**IsCurrencyConversion** | **bool?** | set to true if the order is a FX conversion order  | [optional] 
**AllocationMethod** | **string** | Set the allocation method when placing an order using an FA account for a group Possible allocation methods are \&quot;NetLiquidity\&quot;, \&quot;AvailableEquity\&quot;, \&quot;EqualQuantity\&quot; and \&quot;PctChange\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


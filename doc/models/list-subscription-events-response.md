
# List Subscription Events Response

Defines the fields that are included in the response from the
[ListSubscriptionEvents](#endpoint-subscriptions-listsubscriptionevents)
endpoint.

## Structure

`ListSubscriptionEventsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`IList<Models.Error>`](/doc/models/error.md) | Optional | Information about errors encountered during the request. |
| `SubscriptionEvents` | [`IList<Models.SubscriptionEvent>`](/doc/models/subscription-event.md) | Optional | The `SubscriptionEvents` retrieved. |
| `Cursor` | `string` | Optional | When a response is truncated, it includes a cursor that you can<br>use in a subsequent request to fetch the next set of events.<br>If empty, this is the final response.<br><br>For more information, see [Pagination](https://developer.squareup.com/docs/working-with-apis/pagination). |

## Example (as JSON)

```json
{
  "subscription_events": [
    {
      "effective_date": "2020-04-24",
      "id": "06809161-3867-4598-8269-8aea5be4f9de",
      "plan_id": "6JHXF3B2CW3YKHDV4XEM674H",
      "subscription_event_type": "START_SUBSCRIPTION"
    },
    {
      "effective_date": "2020-05-06",
      "id": "a0c08083-5db0-4800-85c7-d398de4fbb6e",
      "plan_id": "6JHXF3B2CW3YKHDV4XEM674H",
      "subscription_event_type": "STOP_SUBSCRIPTION"
    }
  ]
}
```


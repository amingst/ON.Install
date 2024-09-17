
# Data 34

## Structure

`Data34`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AttemptInterval` | `int?` | Optional | Number of seconds before another retry is submitted<br>**Default**: `300`<br>**Constraints**: `>= 300`, `<= 86400` |
| `BasicAuthUsername` | `string` | Optional | Basic Auth Username Information on `expand` |
| `BasicAuthPassword` | `string` | Optional | Basic Auth Password Information on `expand` |
| `Expands` | `string` | Optional | An option list of expanded data to send with base data. (i.e. set this field to “contact,account_vault” to get the contact an accountvault used to run a transaction.)<br>**Constraints**: *Maximum Length*: `512` |
| `Format` | [`FormatEnum?`](../../doc/models/format-enum.md) | Optional | Options include: api-default |
| `IsActive` | `bool` | Required | Flag to indicate whether configuration is active (in effect). |
| `LocationId` | `string` | Required | The location identifier of the resource you want to recieve postbacks from.<br>**Constraints**: *Pattern*: `^(([0-9a-fA-F\-]{24,36})\|(([0-9a-fA-F]{8})-(([0-9a-fA-F]{4}\-){3})([0-9a-fA-F]{12})))$` |
| `LocationApiId` | `string` | Optional | Location Api ID |
| `OnCreate` | `bool` | Required | To receive postbacks on the creation of a resource |
| `OnUpdate` | `bool` | Required | To receive postbacks on the updating of a resource |
| `OnDelete` | `bool` | Required | To receive postbacks when the record is deleted |
| `PostbackConfigId` | `string` | Optional | Postback Config ID<br>**Constraints**: *Pattern*: `^(([0-9a-fA-F\-]{24,36})\|(([0-9a-fA-F]{8})-(([0-9a-fA-F]{4}\-){3})([0-9a-fA-F]{12})))$` |
| `ProductTransactionId` | `string` | Optional | Required when using 'transaction' or 'transactionbatch' resource<br>**Constraints**: *Pattern*: `^(([0-9a-fA-F\-]{24,36})\|(([0-9a-fA-F]{8})-(([0-9a-fA-F]{4}\-){3})([0-9a-fA-F]{12})))$` |
| `Resource` | [`Resource12Enum`](../../doc/models/resource-12-enum.md) | Required | The resource you want to subscribe the postbacks to.<br>**Constraints**: *Maximum Length*: `128` |
| `NumberOfAttempts` | `int` | Required | Maximum number of attempts on failure<br>**Constraints**: `>= 1`, `<= 5` |
| `Url` | `string` | Required | The URL where the postback will be submitted<br>**Constraints**: *Maximum Length*: `512` |
| `Id` | `string` | Required | Postback Config ID<br>**Constraints**: *Pattern*: `^(([0-9a-fA-F\-]{24,36})\|(([0-9a-fA-F]{8})-(([0-9a-fA-F]{4}\-){3})([0-9a-fA-F]{12})))$` |
| `PostbackLogs` | [`List<PostbackLog>`](../../doc/models/postback-log.md) | Optional | Postback Log Information on `expand` |

## Example (as JSON)

```json
{
  "attempt_interval": 300,
  "basic_auth_username": "username",
  "basic_auth_password": "password",
  "expands": "changelogs,tags",
  "format": "api-default",
  "is_active": true,
  "location_id": "11e95f8ec39de8fbdb0a4f1a",
  "on_create": true,
  "on_update": true,
  "on_delete": true,
  "postback_config_id": "11e95f8ec39de8fbdb0a4f1a",
  "product_transaction_id": "11e95f8ec39de8fbdb0a4f1a",
  "resource": "contact",
  "number_of_attempts": 1,
  "url": "https://127.0.0.1/receiver",
  "id": "11e95f8ec39de8fbdb0a4f1a"
}
```

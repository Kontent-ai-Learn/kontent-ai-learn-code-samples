# DocSection: filtering_get_items_by_datetime
# system.last_modified value is stored with ms precision
# Date&Time element value is stored with minute precision

# Gets items modified after April 9 2020, 9 am UTC+0
delivery_client.items('system.last_modified'.greaterThan('2020-05-09T09:00:00.000000Z'))
# Gets items released at or after April 9 2020, 7 am UTC+0
delivery_client.items('elements.release_date'.greaterThanOrEqual('2020-05-09T07:00:00Z'))
# Gets items modified before April 5 2020 UTC+0; Last match would be at 2020-05-04T23:59:59
delivery_client.items('system.last_modified'.lessThan('2020-05-05'))
# Gets items released at or before April 5 2020 10:30 am UTC+0
delivery_client.items('elements.release_date'.lessThanOrEqual('2020-05-05T10:30:00Z'))
# EndDocSection
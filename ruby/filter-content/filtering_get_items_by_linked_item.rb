# Gets a list of items where the 'my_page' item is used in the 'navigation' element.
delivery_client.items('elements.navigation'.contains('my_page'))

# Gets items linked to at least Jane, John, or both.
delivery_client.items('elements.author'.any('jane_doe', 'john_wick'))

# Gets pages linking travel insurance as their subpage.
delivery_client.items('elements.subpages'.contains('travel_insurance'))

# Gets pages linking at least travel insurance, car insurance, or both as their subpage.
delivery_client.items('elements.subpages'.any('travel_insurance', 'car_insurance'))
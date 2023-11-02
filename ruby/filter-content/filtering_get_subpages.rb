# Gets pages linking travel insurance as their subpage.
delivery_client.items('elements.subpages'.contains('travel_insurance'))

# Gets pages linking at least travel insurance, car insurance, or both as their subpage.
delivery_client.items('elements.subpages'.any('travel_insurance', 'car_insurance'))

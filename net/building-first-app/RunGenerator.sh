# DocSection: building_first_net_app_install_generator
# Note: This overwrites existing files in the .\Models\ContentTypes folder
dotnet tool run KontentModelGenerator --projectid "<YOUR_PROJECT_ID>" --withtypeprovider true --structuredmodel true --outputdir ".\Models\ContentTypes" --namespace "MyWebsite.Models" --generatepartials true
# EndDocSection
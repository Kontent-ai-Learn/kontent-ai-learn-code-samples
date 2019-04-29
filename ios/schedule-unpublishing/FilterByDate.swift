// DocSection: schedule_unpublishing_filter_by_date
import KenticoCloud

let client = DeliveryClient.init(projectId: "14372844-0a5d-434a-8423-605b8a631623")

// Formats current date & time to ISO-8601
let dateformatter = DateFormatter()
dateformatter.dateFormat = "yyyy-MM-dd'T'HH:mm:ss'Z'"
let now = dateformatter.string(from: Date())

let customQuery = "items?system.type=article&elements.publish_until[gt]=\(now)"

// More about strongly-typed models https://github.com/Kentico/cloud-sdk-swift#using-strongly-typed-models
client.getItems(modelType: Article.self, customQuery: customQuery) { (isSuccess, itemsResponse, error) in
    if isSuccess {
        if let articles = itemsResponse?.items {
            // Use your items here
        }
    } else {
        if let error = error {
            print(error)
        }
    }
}
// EndDocSection
// DocSection: strongly_typed_models_retrieve
import com.kenticocloud.delivery.DeliveryClient;
import java.io.IOException;
import java.lang.System;

// Creates an instance of the DeliveryClient 
DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

// Gets a content item from Kentico Cloud by its codename and maps it to its strongly-typed model
try {
  Homepage homepage = client.getItem("hello_headless_world", Homepage.class);
  // Use homepage
  // System.out.println(homepage.getHeadline());
} catch (IOException e) {
  e.printStackTrace();
}
// EndDocSection
// DocSection: strongly_typed_models_retrieve
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import com.github.kentico.kontent.delivery.DeliveryClient;
import java.io.IOException;
import java.lang.System;

// Creates an instance of the DeliveryClient 
DeliveryClient client = new DeliveryClient("8d20758c-d74c-4f59-ae04-ee928c0816b7");

// Gets a content item from Kentico Kontent by its codename and maps it to its strongly typed model
try {
  Homepage homepage = client.getItem("hello_headless_world", Homepage.class);
  // Use homepage
  // System.out.println(homepage.getHeadline());
} catch (IOException e) {
  e.printStackTrace();
}
// EndDocSection
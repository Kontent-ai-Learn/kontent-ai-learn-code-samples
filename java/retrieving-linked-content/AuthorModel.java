// DocSection: linked_content_author_model
// Create strongly typed models according to https://developer.kenticocloud.com/docs/strongly-typed-models

import com.kenticocloud.delivery.ContentItemMapping;
import com.kenticocloud.delivery.ElementMapping;
import com.kenticocloud.delivery.System;
import java.lang.String;
import java.util.List;

@ContentItemMapping("author")
public class Homepage {
    @ElementMapping("name")
    String name;

    @ElementMapping("bio")
    String bio;

    System system;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getBio() {
        return bio;
    }

    public void setBio(String bio) {
        this.bio = bio;
    }

    public System getSystem() {
        return system;
    }

    public void setSystem(System system) {
        this.system = system;
    }
}
// EndDocSection
// DocSection: linked_content_author_model
// Create strongly typed models according to https://kontent.ai/learn/strongly-typed-models

import kontent.ai.delivery.ContentItemMapping;
import kontent.ai.delivery.ElementMapping;
import kontent.ai.delivery.System;
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
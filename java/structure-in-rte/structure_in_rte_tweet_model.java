// Generate strongly typed models at https://github.com/kontent-ai/java-packages/tree/master/delivery-sdk-generators
// Tip: Find more about Java SDK at https://kontent.ai/learn/java

import java.lang.String;
import java.util.List;
import kontent.ai.delivery.ContentItemMapping;
import kontent.ai.delivery.ElementMapping;
import kontent.ai.delivery.Option;
import kontent.ai.delivery.System;

@ContentItemMapping("tweet")
public class Homepage {
    @ElementMapping("tweet_link")
    String tweetLink;

    @ElementMapping("theme")
    List<Option> theme;

    @ElementMapping("display_options")
    List<Option> displayOptions;

    System system;

    public String getTweetLink() {
        return tweetLink;
    }

    public void setTweetLink(String tweetLink) {
        this.tweetLink = tweetLink;
    }

    public List<Option> getTheme() {
        return theme;
    }

    public void setTheme(List<Option> theme) {
        this.theme = theme;
    }

    public List<Option> getDisplayOptions() {
        return displayOptions;
    }

    public void setDisplayOptions(List<Option> displayOptions) {
        this.displayOptions = displayOptions;
    }

    public System getSystem() {
        return system;
    }

    public void setSystem(System system) {
        this.system = system;
    }
}

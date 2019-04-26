// DocSection: structure_in_rte_tweet_model
// Generate strongly typed models at https://github.com/Kentico/cloud-generators-java

import com.kenticocloud.delivery.ContentItemMapping;
import com.kenticocloud.delivery.ElementMapping;
import com.kenticocloud.delivery.Option;
import com.kenticocloud.delivery.System;
import java.lang.String;
import java.util.List;

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
// EndDocSection
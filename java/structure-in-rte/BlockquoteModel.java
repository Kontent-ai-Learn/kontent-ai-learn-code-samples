// DocSection: structure_in_rte_blockquote_model
// Generate strongly typed models at https://github.com/Kentico/cloud-generators-java

import com.kenticocloud.delivery.ContentItemMapping;
import com.kenticocloud.delivery.ElementMapping;
import com.kenticocloud.delivery.Option;
import com.kenticocloud.delivery.System;
import java.lang.String;
import java.util.List;

@ContentItemMapping("blockquote")
public class Homepage {
    @ElementMapping("quote")
    String quote;
  
    @ElementMapping("source")
    String source;

    System system;

    public String getQuote() {
        return quote;
    }

    public void setQuote(String quote) {
        this.quote = quote;
    }

    public String getSource() {
        return source;
    }

    public void setSource(String source) {
        this.source = source;
    }

    public System getSystem() {
        return system;
    }

    public void setSystem(System system) {
        this.system = system;
    }
}
// EndDocSection
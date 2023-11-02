// Generate strongly typed models at https://github.com/kontent-ai/java-packages/tree/master/delivery-sdk-generators
// Tip: Find more about Java SDK at https://kontent.ai/learn/java

import java.lang.String;
import java.util.List;
import kontent.ai.delivery.ContentItemMapping;
import kontent.ai.delivery.ElementMapping;
import kontent.ai.delivery.Option;
import kontent.ai.delivery.System;

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

// DocSection: structure_in_rte_blockquote_model
// Generate strongly typed models at https://github.com/Kentico/kontent-java-packages/tree/master/kontent-delivery-generators
// Tip: Find more about Java SDKs at https://docs.kontent.ai/java

import com.github.kentico.kontent.delivery.ContentItemMapping;
import com.github.kentico.kontent.delivery.ElementMapping;
import com.github.kentico.kontent.delivery.Option;
import com.github.kentico.kontent.delivery.System;
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
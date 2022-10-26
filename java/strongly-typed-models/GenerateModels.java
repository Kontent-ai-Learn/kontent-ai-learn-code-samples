// DocSection: strongly_typed_models_generators
// Find instructions on using the Java model generator at https://github.com/kontent-ai/java-packages/tree/master/delivery-sdk-generators
import com.squareup.javapoet.JavaFile
import kentico.kontent.delivery.DeliveryClient
import kentico.kontent.delivery.DeliveryOptions
import kentico.kontent.delivery.generators.CodeGenerator

buildscript {
    repositories {
        jcenter()
    }
    dependencies {
        classpath('com.github.kentico:kontent-delivery-generators:latest.release')
    }
}

// showcase task
task generateModels {
    doLast {

        // The most complex solution, you could configure the client as you want
        // i.e. set preview API key
        DeliveryOptions options = new DeliveryOptions();
        options.setProjectId("975bf280-fd91-488c-994c-2f04416e5ee3");
        DeliveryClient client = new DeliveryClient(options);

        CodeGenerator generator = new CodeGenerator(
            options.getProjectId(),
            'com.kentico.kontent.test.springapp.models',
            file('src/main/java')
        );
        List<JavaFile> sources = generator.generateSources(client);
        generator.writeSources(sources);
    }
}
// EndDocSection
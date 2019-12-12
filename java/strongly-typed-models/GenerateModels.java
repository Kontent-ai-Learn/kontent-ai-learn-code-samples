// DocSection: strongly_typed_models_generators
// For instructions on using the Java model generator, visit https://github.com/Kentico/kontent-generators-java

// Configures Gradle plugin
apply plugin: 'java'

kenticoModel {
	projectId = '8d20758c-d74c-4f59-ae04-ee928c0816b7'
	packageName = 'com.helloheadlessworld.models'
	outputDir = file('generated-sources')
}

dependencies {
    compile('com.kenticocloud:delivery-sdk-java:1.0.3')
}

// Runs generateModels task
./gradlew generateModels
// EndDocSection
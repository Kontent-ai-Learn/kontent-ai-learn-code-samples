services.AddSingleton<IHtmlResolver>(resolver);

// Alternatively, resolvers can be instantiated directly and passed to ToHtmlAsync
// without DI registration — useful for per-controller or per-service resolution

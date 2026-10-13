var result = await client.GetItem<SimpleArticle>("my_article").ExecuteAsync();

if (result.IsSuccess && result.Value.Elements.Body is { } body)
{
    // _resolver can be a local variable or resolved from DI (IHtmlResolver)
    string html = await body.ToHtmlAsync(_resolver);
}

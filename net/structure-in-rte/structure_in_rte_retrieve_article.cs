var result = await client.GetItem<SimpleArticle>("my_article").ExecuteAsync();

if (result.IsSuccess)
{
    // Resolve the rich text body to HTML
    // _resolver can be a local variable or resolved from DI (IHtmlResolver)
    string html = await result.Value.Elements.Body.ToHtmlAsync(_resolver);
}

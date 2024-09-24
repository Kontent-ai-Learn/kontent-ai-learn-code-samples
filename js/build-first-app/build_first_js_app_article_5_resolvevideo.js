const rteResolver = Kk.createRichTextHtmlResolver().resolveRichText({
  element: richTextElement,
  linkedItems: Kk.linkedItemsHelper.convertLinkedItemsToArray(response.data.linkedItems),
  urlResolver: (linkId, linkText, link) => {
    // Your link resolution logic
  },
  contentItemResolver: (itemId, item) => {
    if (item.system.type === 'hosted_video') {
      const videoID = item.elements.video_id.value;

      // Check if a video host exists
      const videoHost =
        item.elements.video_host.value && item.elements.video_host.value.length
          ? item.elements.video_host.value[0].codename
          : undefined;
      if (videoHost) {
        // Return based on hosting provider
        const htmlCode = videoHost === 'youtube'
          ? `<iframe src='https://www.youtube.com/embed/${videoID}' width='560' height='315' frameborder='0'></iframe>`
          : `<iframe src='https://player.vimeo.com/video/${videoID}' width='560' height='315' allowfullscreen frameborder='0'></iframe>`;
        return {
          contentItemHtml: htmlCode
        };
      }
    }
    return {
      contentItemHtml: ''
    };
  }
});

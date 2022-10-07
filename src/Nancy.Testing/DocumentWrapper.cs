namespace Nancy.Testing
{
    using AngleSharp.Html.Dom;
    using AngleSharp.Html.Parser;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    /// <summary>
    /// A basic wrapper around CsQuery
    /// </summary>
    public class DocumentWrapper
    {
        private readonly IHtmlDocument document;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentWrapper"/> class.
        /// </summary>
        /// <param name="buffer">The document represented as a byte array.</param>
        public DocumentWrapper(IEnumerable<byte> buffer)
        {
            var parser = new HtmlParser();
            using (var stream = new MemoryStream(buffer.ToArray()))
            {
                this.document = parser.ParseDocument(stream);
            }
        }

        /// <summary>
        /// Gets elements from CSS3 selectors
        /// </summary>
        /// <param name="selector">The CSS3 selector that should be applied.</param>
        /// <returns>A <see cref="QueryWrapper"/> instance.</returns>
        public QueryWrapper this[string selector]
        {
            get { return new QueryWrapper(this.document.QuerySelectorAll(selector).ToArray()); }
        }
    }
}

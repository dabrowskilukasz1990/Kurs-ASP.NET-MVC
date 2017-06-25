using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HtmlHelpers3_WlasyHelper.Helpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string id, string url, string tekstAlternatywny)
        {
            return Image(helper, id, url, tekstAlternatywny, null);

        }

        public static MvcHtmlString Image(this HtmlHelper helper, string id, string url, string tekstAlternatywny, object htmlAtributes)
        {
            var builder = new TagBuilder("img");

            builder.GenerateId(id);

            builder.MergeAttribute("src", url);
            builder.MergeAttribute("alt", tekstAlternatywny);
            builder.MergeAttributes(new RouteValueDictionary(htmlAtributes));

            return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));

        }
    }
}
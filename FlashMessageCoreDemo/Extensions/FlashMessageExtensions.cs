using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashMessageCoreDemo.Extensions
{
    public static class FlashMessageExtensions
    {
        public static IHtmlContent FlashMessage(this ITempDataDictionary tempData)
        {
            if (tempData[Constants.FlashMessageKey] != null)
            {
                return StatusMessage(tempData[Constants.FlashMessageKey].ToString(), tempData[Constants.FlashMessageTypeKey].ToString());
            }
            else return HtmlString.Empty;
        }

        private static IHtmlContent StatusMessage(string message, string cssClass)
        {
            TagBuilder display = new TagBuilder("div");
            display.AddCssClass("rounded");
            display.AddCssClass(cssClass);
            display.InnerHtml.Append(message);

            TagBuilder columns = new TagBuilder("div");
            columns.AddCssClass("col-lg-12");
            columns.InnerHtml.AppendHtml(display);

            TagBuilder row = new TagBuilder("div");
            row.AddCssClass("row");
            row.InnerHtml.AppendHtml(columns);

            return row.RenderBody();
        }
    }
}

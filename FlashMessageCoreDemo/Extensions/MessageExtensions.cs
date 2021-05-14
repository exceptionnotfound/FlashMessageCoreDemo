using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashMessageCoreDemo.Extensions
{
public static class MessageExtensions
{
    public static IHtmlContent ErrorMessage<TModel>(this IHtmlHelper<TModel> helper, string message)
    {
        return StatusMessage(message, "alert-danger");
    }

    public static IHtmlContent SuccessMessage<TModel>(this IHtmlHelper<TModel> helper, string message)
    {
        return StatusMessage(message, "alert-success");
    }

    public static IHtmlContent WarningMessage<TModel>(this IHtmlHelper<TModel> helper, string message)
    {
        return StatusMessage(message, "alert-warning");
    }

    public static IHtmlContent InfoMessage<TModel>(this IHtmlHelper<TModel> helper, string message)
    {
        return StatusMessage(message, "alert-info");
    }

        public static IHtmlContent FlashMessage(this ITempDataDictionary tempData)
        {
            if (tempData[Constants.FlashMessageKey] != null)
            {
                string message = tempData[Constants.FlashMessageKey].ToString();
                string type = tempData[Constants.FlashMessageTypeKey].ToString();
                return StatusMessage(message, type);
            }
            else return HtmlString.Empty;
        }

        private static IHtmlContent StatusMessage(string message, string cssClass)
        {
            //First, build the innermost div tag, the one that displays the message
            TagBuilder display = new TagBuilder("div");
            display.AddCssClass("rounded p-lg-3");
            display.AddCssClass(cssClass);
            display.InnerHtml.Append(message);

            //Now, build the wrapping column
            TagBuilder columns = new TagBuilder("div");
            columns.AddCssClass("col-lg");
            columns.InnerHtml.AppendHtml(display);

            //Finally, build the wrapping row
            TagBuilder row = new TagBuilder("div");
            row.AddCssClass("row");
            row.InnerHtml.AppendHtml(columns);

            return row;
        }
    }
}

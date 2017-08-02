using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Helpers
{
    public static class UserModelHelpers
    {
        public static MvcHtmlString GetUserModelDisplayName(this HtmlHelper helper, UserModel user, string tag = "p", string cssClass = null)
        {
            var tb = new TagBuilder(tag);
            if (!string.IsNullOrWhiteSpace(cssClass))
            {
                tb.AddCssClass(cssClass);
            }
            tb.SetInnerText($"{user.FirstName} {user.LastName}");
            return new MvcHtmlString(tb.ToString());
         }

        public static MvcHtmlString GetUserModelProfileImage(this HtmlHelper helper, UserModel model) {
            var tb = new TagBuilder("img");
            tb.AddCssClass("profile-image");
            tb.Attributes.Add("src", model.ProfileImagePath);

            return new MvcHtmlString(tb.ToString());
        }

        public static MvcHtmlString GenerateTag(this HtmlHelper helper, string innerText, string tag = "p", string cssClass = null) {
            var tb = new TagBuilder(tag);
			if (!string.IsNullOrWhiteSpace(cssClass))
			{
				tb.AddCssClass(cssClass);
			}
            tb.SetInnerText(innerText);

            return new MvcHtmlString(tb.ToString());
		}

		public static MvcHtmlString GenerateTag(this HtmlHelper helper, MvcHtmlString[] innerText, string tag = "p", string cssClass = null)
		{
			var tb = new TagBuilder(tag);
			if (!string.IsNullOrWhiteSpace(cssClass))
			{
				tb.AddCssClass(cssClass);
			}
            foreach (var inner in innerText)
            {
                tb.InnerHtml += inner;
            }

			return new MvcHtmlString(tb.ToString());
		}

        public static MvcHtmlString GetUserCard(this HtmlHelper helper, UserModel user) {
            var sb = new StringBuilder();

            var tb = new TagBuilder("h2");
            tb.AddCssClass("president-name");
            tb.SetInnerText($"{user.FirstName} {user.LastName}");
            sb.Append(tb.ToString());

			tb = new TagBuilder("h3");
			tb.AddCssClass("president-term");
            tb.SetInnerText(user.presidentialTerm);
			sb.Append(tb.ToString());

			tb = new TagBuilder("img");
			tb.AddCssClass("profile-image");
			tb.Attributes.Add("src", user.ProfileImagePath);
            sb.Append(tb.ToString());

            tb = new TagBuilder("div");
            tb.AddCssClass("user");
            tb.InnerHtml = sb.ToString();

            return new MvcHtmlString(tb.ToString());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ITP245_Model;
using Microsoft.Owin.BuilderProperties;

namespace _245_MVC_Project.HtmlHelpers
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString EmailLink(this HtmlHelper html, IEmail vendor)
        {
           
            var link = new TagBuilder("a") { InnerHtml = $"{vendor.Email}" };
            link.MergeAttribute("class", "Email");
            link.MergeAttribute("href", $"mailto:{vendor.Email}?subject={vendor.Contact}");

            string emailLink = link.ToString(TagRenderMode.Normal);

            return new MvcHtmlString(emailLink);
          
        }

        //testing css/bootstrap
        public static MvcHtmlString IndexLinks(this HtmlHelper html,IItem item, string controller)
        {
            var edit = new TagBuilder("a") { InnerHtml = "Edit" };
            edit.MergeAttribute("id", "Edit");
            edit.MergeAttribute("href",$"{controller}/Edit/{item.Id}");
            //edit.MergeAttribute("class", "label-primary badge ");
            edit.MergeAttribute("class", "btn btn-primary");
            string editLink= edit.ToString(TagRenderMode.Normal);


            var details = new TagBuilder("a") { InnerHtml = "Details" };
            details.MergeAttribute("id", "Details");
            details.MergeAttribute("href", $"{controller}/Details/{item.Id}");
            //details.MergeAttribute("class", "label-primary badge");
            details.MergeAttribute("class", "btn btn-info");
            string detailsLink = details.ToString(TagRenderMode.Normal);


            var delete = new TagBuilder("a") { InnerHtml = "Delete" };
            delete.MergeAttribute("id", "Delete");
            delete.MergeAttribute("href", $"{controller}/Delete/{item.Id}");
            //delete.MergeAttribute("class", "label-danger badge");
            delete.MergeAttribute("class", "btn btn-danger");

            string deleteLink = delete.ToString(TagRenderMode.Normal);


            return new MvcHtmlString(editLink + detailsLink + deleteLink);
            //doesnt work on vendor page..... we get different paths
        }
    }
}
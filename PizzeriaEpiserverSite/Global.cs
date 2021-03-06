﻿using EPiServer.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PizzeriaEpiserverSite
{
    public class Global
    {
        //public static class GroupNames
        //{
        //    [Display(Name = "Contact", Order = 1)]
        //    public const string Contact = "Contact";

        //    [Display(Name = "Default", Order = 2)]
        //    public const string Default = "Default";

        //    [Display(Name = "Metadata", Order = 3)]
        //    public const string MetaData = "Metadata";

        //    [Display(Name = "News", Order = 4)]
        //    public const string News = "News";

        //    [Display(Name = "Products", Order = 5)]
        //    public const string Products = "Products";

        //    [Display(Name = "SiteSettings", Order = 6)]
        //    public const string SiteSettings = "SiteSettings";

        //    [Display(Name = "Specialized", Order = 7)]
        //    public const string Specialized = "Specialized";
        //}

        

        public static class ContentAreaTags
        {
            public const string FullWidth = "span12";
            public const string TwoThirdsWidth = "span8";
            public const string HalfWidth = "span6";
            public const string OneThirdWidth = "span4";
            public const string NoRenderer = "norenderer";
        }
    }
}
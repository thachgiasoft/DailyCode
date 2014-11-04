﻿using System.Web.Optimization;

namespace Pineapple.WebSite.App_Start
{
    public class BundleConfig
    {
        // 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            //// 使用 Modernizr 的开发版本进行开发和了解信息。然后，当你做好
            //// 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            //            "~/Content/themes/base/jquery.ui.core.css",
            //            "~/Content/themes/base/jquery.ui.resizable.css",
            //            "~/Content/themes/base/jquery.ui.selectable.css",
            //            "~/Content/themes/base/jquery.ui.accordion.css",
            //            "~/Content/themes/base/jquery.ui.autocomplete.css",
            //            "~/Content/themes/base/jquery.ui.button.css",
            //            "~/Content/themes/base/jquery.ui.dialog.css",
            //            "~/Content/themes/base/jquery.ui.slider.css",
            //            "~/Content/themes/base/jquery.ui.tabs.css",
            //            "~/Content/themes/base/jquery.ui.datepicker.css",
            //            "~/Content/themes/base/jquery.ui.progressbar.css",
            //            "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include(
                "~/Content/bootstrap-3.2.0/css/bootstrap.css"
                , "~/Content/bootstrap-3.2.0/css/bootstrap-theme.css"
                , "~/Content/metro-bootstrap/css/metro-bootstrap.css"
                , "~/Content/metro-bootstrap/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/dashboard/css")
                        .Include("~/Content/css/dashboard.css"));
            
            bundles.Add(new ScriptBundle("~/Content/jquery").Include(
                "~/Content/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Content/bootstrap/js").Include(
                "~/Content/bootstrap-3.2.0/js/bootstrap.js"));
            
            bundles.Add(new ScriptBundle("~/Content/jqueryfileupload/js")
                      .Include("~/Content/js/jquery.lazyload.js")
                      .Include("~/Content/js/jquery.magnific-popup.js")
                      .Include("~/Content/js/pineaaple.jquery.fileupload.js"));
            
            bundles.Add(new StyleBundle("~/Content/jqueryfileupload/css")
                        .Include("~/Content/css/magnific-popup.css")
                        );
        }
    }
}
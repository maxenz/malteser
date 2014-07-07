using System.Web;
using System.Web.Optimization;

namespace Malteser
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            "~/Scripts/vendor/bootstrap.js",
            "~/Scripts/bootstrap-select.js",
            "~/Scripts/jquery.maskedinput.js",
            "~/Scripts/bootstrapValidator.js",
            "~/Scripts/messenger.js",
            "~/Scripts/moment.js",
            "~/Scripts/messenger-theme-future.js",
            "~/Scripts/jquery.serialize-object.js",
            "~/Scripts/jquery.maskMoney.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqwidgets").Include(
                       "~/Content/jqwidgets/jqxcore.js",
                       "~/Content/jqwidgets/jqxdata.js",
                       "~/Content/jqwidgets/jqxbuttons.js",
                       "~/Content/jqwidgets/jqxscrollbar.js",
                       "~/Content/jqwidgets/jqxmenu.js",
                       "~/Content/jqwidgets/jqxgrid.js",
                       "~/Content/jqwidgets/jqxgrid.pager.js",
                       "~/Content/jqwidgets/jqxgrid.selection.js",
                       "~/Content/jqwidgets/jqxnumberinput.js",
                       "~/Content/jqwidgets/jqxwindow.js",
                       "~/Content/jqwidgets/jqxlistbox.js",
                       "~/Content/jqwidgets/jqxdropdownlist.js",
                       "~/Content/jqwidgets/jqxcheckbox.js",
                       "~/Content/jqwidgets/jqxcombobox.js",
                       "~/Content/jqwidgets/jqxgrid.filter.js",
                       "~/Content/jqwidgets/jqxdatetimeinput.js",
                       "~/Content/jqwidgets/jqxcalendar.js",
                       "~/Content/jqwidgets/jqxgrid.aggregates.js",
                       "~/Content/jqwidgets/jqxtooltip.js",
                       "~/Content/jqwidgets/jqxdata.export.js",
                       "~/Content/jqwidgets/jqxgrid.export.js",
                       "~/Content/jqwidgets/jqxvalidator.js",
                       "~/Content/jqwidgets/globalization/globalize.js",
                       "~/Content/jqwidgets/globalization/globalize.culture.es-AR.js",
                       "~/Content/jqwidgets/jqxgrid.columnsresize.js"
                       ));

             bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/styles/droid-font.css",
                        "~/Content/styles/bootstrap-select.css",
                        "~/Content/styles/bootstrapValidator.css",
                        "~/Content/styles/messenger.css",
                        "~/Content/styles/messenger-theme-future.css",
                        "~/Content/styles/messenger-spinner.css",
                        "~/Content/styles/shapes.css",
                        "~/Content/jqwidgets/styles/jqx.base.css",
                        "~/Content/jqwidgets/styles/jqx.arctic.css",
                        "~/Content/jqwidgets/styles/jqx.bootstrap.css",
                        "~/Content/styles/main.css"));

             bundles.Add(new ScriptBundle("~/bundles/main").Include(
                         "~/Scripts/site/main.js",
                         "~/Scripts/site/svFinalizados.js"));
        

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}
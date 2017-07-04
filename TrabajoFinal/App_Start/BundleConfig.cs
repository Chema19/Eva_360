using System.Web;
using System.Web.Optimization;

namespace TrabajoFinal
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                     "~/Content/assets/plugins/morris/morris.css",
                     "~/Content/assets/css/bootstrap.min.css",
                     "~/Content/assets/css/core.css",
                     "~/Content/assets/css/components.css",
                     "~/Content/assets/css/icons.css",
                     "~/Content/assets/css/pages.css",
                     "~/Content/assets/css/responsive.css",
                     "~/Content/assets/plugins/datatables/jquery.dataTables.min.css",
                     "~/Content/assets/plugins/datatables/buttons.bootstrap.min.css",
                     "~/Content/assets/plugins/datatables/fixedHeader.bootstrap.min.css",
                     "~/Content/assets/plugins/datatables/responsive.bootstrap.min.css",
                     "~/Content/assets/plugins/datatables/scroller.bootstrap.min.css",
                     "~/Content/assets/plugins/datatables/dataTables.colVis.css",
                     "~/Content/assets/plugins/datatables/dataTables.bootstrap.min.css",
                     "~/Content/assets/plugins/datatables/fixedColumns.dataTables.min.css"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Content/assets/js/jquery.min.js",
                        "~/Content/assets/js/bootstrap.min.js",
                        "~/Content/assets/js/detect.js",
                        "~/Content/assets/js/fastclick.js",
                        "~/Content/assets/js/jquery.slimscroll.js",
                        "~/Content/assets/js/jquery.blockUI.js",
                        "~/Content/assets/js/waves.js",
                        "~/Content/assets/js/wow.min.js",
                        "~/Content/assets/js/jquery.nicescroll.js",
                        "~/Content/assets/js/jquery.scrollTo.min.js",
                        "~/Content/assets/plugins/peity/jquery.peity.min.js",
                        "~/Content/assets/plugins/waypoints/lib/jquery.waypoints.js",
                        "~/Content/assets/plugins/counterup/jquery.counterup.min.js",
                        "~/Content/assets/plugins/morris/morris.min.js",
                        "~/Content/assets/plugins/raphael/raphael-min.js",
                        "~/Content/assets/plugins/jquery-knob/jquery.knob.js",
                        "~/Content/assets/pages/jquery.dashboard.js",
                        "~/Content/assets/js/jquery.core.js",
                        "~/Content/assets/js/jquery.app.js",
                        "~/Content/assets/plugins/datatables/jquery.dataTables.min.js",
                        "~/Content/assets/plugins/datatables/dataTables.bootstrap.js",
                        "~/Content/assets/plugins/datatables/dataTables.buttons.min.js",
                        "~/Content/assets/plugins/datatables/buttons.bootstrap.min.js",
                        "~/Content/assets/plugins/datatables/jszip.min.js",
                        "~/Content/assets/plugins/datatables/pdfmake.min.js",
                        "~/Content/assets/plugins/datatables/vfs_fonts.js",
                        "~/Content/assets/plugins/datatables/buttons.html5.min.js",
                        "~/Content/assets/plugins/datatables/buttons.print.min.js",
                        "~/Content/assets/plugins/datatables/dataTables.fixedHeader.min.js",
                        "~/Content/assets/plugins/datatables/dataTables.keyTable.min.js",
                        "~/Content/assets/plugins/datatables/dataTables.responsive.min.js",
                        "~/Content/assets/plugins/datatables/responsive.bootstrap.min.js",
                        "~/Content/assets/plugins/datatables/dataTables.scroller.min.js",
                        "~/Content/assets/plugins/datatables/dataTables.colVis.js",
                        "~/Content/assets/plugins/datatables/dataTables.fixedColumns.min.js",
                        "~/Content/assets/plugins/datatables/dataTables.fixedColumns.min.js"
                        ));
        }
    }
}

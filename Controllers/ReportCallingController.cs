using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;

namespace QCO.Controllers
{
    public class ReportCallingController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var rptPath = "QCO.Reports.rptHitRate";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                ViewBag.ReportName = report;
                return View("~/Views/Shared/_LayoutReport.cshtml");
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }


        //public IActionResult Viewer()
        //{
        //    return View();
        //}

        public IActionResult Viewer(string reportName = "rptHitRate")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public IActionResult Viewer1(string reportName = "rptYarnAging")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult Viewer2(string reportName = "rptWorkOrderFOllowup_Tex")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult Viewer3(string reportName = "rptSewingWIP")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult PieceRate(string reportName = "rptDailySewingProduction")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult DyeingProd(string reportName = "rptDyeingProduction")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult DyeingProd1(string reportName = "rptDyeing_Production_WC")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult DyeingKPI(string reportName = "rptDyeingKPI")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public IActionResult LineWiseWIP(string reportName = "rptLineWiseWIP")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult Test(string reportName = "rptGreyTransferFollowUp")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult DHU(string reportName = "rptFinalDHU")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult GP_OUT(string reportName = "rptGatePass_Out")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public IActionResult FIN_FAB_STOCK(string reportName = "rptFinishFabStock")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

        public IActionResult DyeingCost(string reportName = "rptDyeingCost")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
        public IActionResult YarnAllocation(string reportName = "rptYarnAllocation")
        {
            try
            {
                var rptPath = $"QCO.Reports.{reportName}";
                XtraReport report = (XtraReport)Activator.CreateInstance(Type.GetType(rptPath));
                return View(report);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDMVCLearn.App_Start
{
    //public class Myloadview
    //{
    //    public ActionResult LoadView(MenuTypes type = MenuTypes.Home, int iTypeId = 0, int iMenuId = 0, int[] arrActionId = null)
    //    {
    //        arrActionId = arrActionId ?? new int[0];
    //        string areaName = "", ControllerName = "", viewName = "";
    //        try
    //        {
    //            switch (type)
    //            {
    //                case MenuTypes.Company:
    //                    MenuHandler.CompanyMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.Calendar:
    //                    MenuHandler.CalendarMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.CoreTransactions:
    //                    MenuHandler.CoreTransactionMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.CreditManagement:
    //                    MenuHandler.CreditManagementMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.DataManagement:
    //                    MenuHandler.DataManagementMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.ExternalModule:
    //                    MenuHandler.ExternalMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.ExternalPosting:
    //                    MenuHandler.ExternalMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.ExtraMasters:
    //                    MenuHandler.CoreMastersMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.FixedAsset:
    //                    MenuHandler.FixedAssetsMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.Home:
    //                    MenuHandler.HomeAreaMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;
    //                case MenuTypes.Masters:
    //                    MenuHandler.MastersMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.MRP:
    //                    MenuHandler.MRPMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.Payroll:
    //                    MenuHandler.PayRollMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.POS:
    //                    //MenuHandler.POSMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.PrefVoucherWiz:
    //                    MenuHandler.TranSettingsMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.RDReports:
    //                    MenuHandler.RDMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.ReportDesigner:
    //                    MenuHandler.RDMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.Restaurant:
    //                    MenuHandler.RestaurantMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.Security:
    //                    MenuHandler.SecurityMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;
    //                case MenuTypes.Synchronization:
    //                    MenuHandler.SynchronizationMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.Transactions:
    //                    MenuHandler.TransactionsMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;

    //                case MenuTypes.VoucherPopups:
    //                    MenuHandler.TransactionsMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;
    //                case MenuTypes.MasterCustomization:
    //                    MenuHandler.MastersCustMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;
    //                case MenuTypes.WMS:
    //                    MenuHandler.WMSMenuHandler(iTypeId, type, ref viewName, ref ControllerName, ref areaName);
    //                    break;
    //            }

    //            UpdateUsageLog(iMenuId);

    //        }
    //        catch (Exception ex) { }
    //        ViewBag.ViewName = viewName;
    //        ViewBag.CotrollerName = ControllerName;
    //        ViewBag.areaName = areaName;
    //        if (viewName != "" && ControllerName != "")
    //        {
    //            //return RedirectToAction(viewName, ControllerName, new { area = areaName, HttpMethod=FormMethod.Post , typeId = iTypeId, actionIds = string.Join(",", arrActionId) });
    //            return RedirectToAction(viewName, ControllerName, new { area = areaName, HttpMethod = FormMethod.Post, iTypeId = iTypeId, iMenuId = iMenuId });
    //        }
    //        else
    //            return RedirectToAction("Error", "Home");
    //    }
    //}
}
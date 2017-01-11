using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace RDMVCLearn
{
    public class MyFilter:ActionFilterAttribute,IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            try
            {
                writeException(filterContext.Exception.Message);
            }
            catch (Exception)
            {
                writeException(filterContext.Exception.Message);
            }
        }
        void writeException(string expMessage = "")
        {
            FileStream objFileStream = new FileStream(@"E:\Exp.log", FileMode.Append, FileAccess.Write);
            StreamWriter strW = new StreamWriter(objFileStream);
            strW.WriteLine("\n");
            strW.WriteLine("--Exception--");

            strW.WriteLine("Date :" + DateTime.Now);
            strW.WriteLine("Error Message : " + expMessage);
            strW.Close();
            objFileStream.Close();
        }
    }
}
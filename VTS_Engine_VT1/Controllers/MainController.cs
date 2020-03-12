using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace VTS_Engine_VT1.Controllers
{
    public class MainController : Controller
    {
        public StringBuilder ReceiveRowData(string id)
        {
            var rowData = new StringBuilder(id);
            return rowData;
        }

        
    }
}
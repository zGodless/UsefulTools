using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsefulTools.Models;
using UsefulTools.Models.JsonCheck;

namespace UsefulTools.Controllers
{
    public class ToolsController : Controller
    {
        // GET: Tools
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        public ActionResult JsonCheck()
        {
            return View();
        }
        /// <summary>
        /// 判断JSON字符串是否合法
        /// </summary>
        /// <param name="jsonStr">传入的json串</param>
        /// <returns></returns>
        public string Check(string jsonStr)
        {
            if (JsonSplit.IsJson(jsonStr))
            {
                return JSONHelper.ObjectToJSON(jsonStr);
            }
            else
            {
                return JSONHelper.ConvertJsonString(jsonStr);
            }
        }



    }
}
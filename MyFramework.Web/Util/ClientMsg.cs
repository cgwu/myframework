using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace MyFramework.Web.Util
{
    public static class ClientMsg
    {
        /// <summary>
        /// 向页面写入提示信息，如：提示成功
        /// </summary>
        /// <param name="page">页面对象，一般为this</param>
        /// <param name="script">js脚本，如: alert('success');</param>
        /// <param name="key">js脚本key</param>
        public static void Write(Page page, string script, string key = "")
        {
            if (string.IsNullOrEmpty(key)) key = System.Guid.NewGuid().ToString();
            //在结束标签</form>标签之前添加脚本 ################
            page.ClientScript.RegisterStartupScript(page.GetType(), key, script, true);
        }
        /// <summary>
        /// 向使用ajax(UpdatePanel)的页面写入提示信息,如：提示成功
        /// </summary>
        /// <param name="page">页面对象，一般为this</param>
        /// <param name="script">js脚本，如: alert('success');</param>
        /// <param name="key">js脚本key</param>
        public static void WriteAjax(Page page, string script, string key = "")
        {
            if (string.IsNullOrEmpty(key)) key = System.Guid.NewGuid().ToString();
            ScriptManager.RegisterStartupScript(page, typeof(ScriptManager), key, script, true);
        }


        /// <summary>
        /// 向页面写入提示信息，如：成功
        /// </summary>
        /// <param name="page">页面对象，一般为this</param>
        /// <param name="script">js脚本，如: success</param>
        /// <param name="key">js脚本key</param>
        public static void Show(Page page, string message, string key = "")
        {
            message = string.Format("alert('{0}');", message);
            page.ClientScript.RegisterStartupScript(page.GetType(), key, message, true);
        }
        /// <summary>
        /// 向使用ajax(UpdatePanel)的页面写入提示信息,如：提示成功
        /// </summary>
        /// <param name="page">页面对象，一般为this</param>
        /// <param name="script">js脚本，如: success</param>
        /// <param name="key">js脚本key</param>
        public static void ShowAjax(Page page, string message, string key = "")
        {
            message = string.Format("alert('{0}');", message);
            ScriptManager.RegisterStartupScript(page, typeof(ScriptManager), key, message, true);
        }

    }
}
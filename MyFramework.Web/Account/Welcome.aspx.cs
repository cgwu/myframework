﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyFramework.Common.Message.Util;

namespace MyFramework.Web.Account
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Response.Write(DateUtil.ToStandardDateTime( DateTime.Now));   //工作正常
        }
    }
}
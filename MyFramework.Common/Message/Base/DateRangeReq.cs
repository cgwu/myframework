using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFramework.Common.Message.Base
{
    /// <summary>
    /// 有分页的请求对象
    /// </summary>
    public class DateRangeReq : PageReq
    {
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
    }
}

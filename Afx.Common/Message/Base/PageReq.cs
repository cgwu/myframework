using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Afx.Common.Message.Base
{
    /// <summary>
    /// 有分页的请求对象
    /// </summary>
    public class PageReq : Req
    {
        public Page Page { get; set; }
    }
}

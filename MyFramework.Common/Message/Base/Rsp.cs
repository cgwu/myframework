using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFramework.Common.Message.Base
{
    public class Rsp : Message
    {
        /// <summary>
        /// 代码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
    }
}

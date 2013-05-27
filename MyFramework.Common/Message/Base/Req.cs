using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFramework.Common.Message.Base
{
    public class Req : Message
    {
        /// <summary>
        /// SessionId
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// 当前操作用户级别
        /// </summary>
        public int CurrentUserLevel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Common.Constant;

namespace MyFramework.Common.Abstract
{
    public interface ISession
    {
        /// <summary>
        /// 会话ID
        /// </summary>
        string SessionId { get; set; }

        /// <summary>
        /// 用户自己的ID
        /// </summary>
        String UserId { get; set; }

        /// <summary>
        /// 用户代码
        /// </summary>
        String UserCode { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        String Name { get; set; }

        /// <summary>
        /// 用户级别
        /// </summary>
        UserLevel UserLevel { get; set; }

        /// <summary>
        /// 宿主ID
        /// </summary>
        String MasterId { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        string Language { get; set; }
    }
}

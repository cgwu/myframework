using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Afx.Common.Constant
{
    /// <summary>
    /// 业务Response返回数据常量定义
    /// </summary>
    public abstract class RspData
    {
        /// <summary>
        /// 成功
        /// </summary>
        public const int SUCCESS = 0;

        /// <summary>
        /// 需要登录
        /// </summary>
        public const int NEED_LOGIN = 10001;

        /// <summary>
        /// 非法请求
        /// </summary>
        public const int INVALID_REQUEST = 10002;

        /// <summary>
        /// 业务错误
        /// </summary>
        public const int BUSINESS_ERROR = 10003;


        /// <summary>
        /// 业务处理失败
        /// </summary>
        public const string BUSINESS_ERROR_MESSAGE = "BUSINESS_ERROR_MESSAGE";

        /// <summary>
        /// 成功信息
        /// </summary>
        public const string SUCCESS_MESSAGE = "success";
    }
}

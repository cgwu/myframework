using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Common.Constant;

namespace MyFramework.Common.Message.Base
{
    public class MessageUtil
    {

        /// <summary>
        /// 设置响应成功
        /// </summary>
        /// <param name="response"></param>
        public static T SetSuccess<T>(T response) where T : Rsp
        {
            response.Code = RspData.SUCCESS;
            response.Msg = RspData.SUCCESS_MESSAGE;
            return response;
        }

        /// <summary>
        /// 设置响应失败，采用系统错误管理
        /// </summary>
        /// <param name="response"></param>
        public static T SetFailure<T>(T response, int code) where T : Rsp
        {
            response.Code = code;
            return response;
        }

        /// <summary>
        /// 设置响应失败，采用自定义错误消息
        /// </summary>
        /// <param name="response"></param>
        public static T SetFailure<T>(T response, int code, string message) where T : Rsp
        {
            response.Code = code;
            response.Msg = message;
            return response;
        }

        /// <summary>
        /// 创建默认的成功响应
        /// </summary>
        /// <returns></returns>
        public static Rsp DefaultSuccessResponse()
        {
            Rsp response = new Rsp();
            return SetSuccess<Rsp>(response);
        }
    }
}

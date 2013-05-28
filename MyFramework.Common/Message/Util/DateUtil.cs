using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Common.Message.Base;

namespace MyFramework.Common.Message.Util
{
    public abstract class DateUtil
    {
        /// <summary>
        /// 将DataRangeReq中的BeginDate,EndDate字符串转化为日期时间格式
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public static DateTime[] DateRange(DataRangeReq req)
        {
            try
            {
                DateTime begin = DateTime.Parse(req.BeginDate);
                DateTime end = DateTime.Parse(req.EndDate + " 23:59:59.995");
                return new DateTime[] { begin, end };
            }
            catch (Exception)
            {
                DateTime dt = DateTime.Parse("1900-01-01");
                return new DateTime[] { dt, dt };
            }
        }
    }
}

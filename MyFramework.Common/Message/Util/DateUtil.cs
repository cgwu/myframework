using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Common.Message.Base;

namespace MyFramework.Common.Message.Util
{
    public static class DateUtil
    {
        /// <summary>
        /// 将DataRangeReq中的BeginDate,EndDate字符串转化为日期时间格式
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public static DateTime[] DateRange(DateRangeReq req)
        {
            try
            {
                DateTime begin = DateTime.Parse(req.BeginDate);
                DateTime end = DateTime.Parse(req.EndDate + " 23:59:59.997");
                return new DateTime[] { begin, end };
            }
            catch (Exception)
            {
                DateTime dt = DateTime.Parse("1900-01-01");
                return new DateTime[] { dt, dt };
            }
        }

        public const string StandardDateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        public const string StandardDateFormat = "yyyy-MM-dd";

        /// <summary>
        /// 标准日期时间格式[yyyy-MM-dd HH:mm:ss]
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToStandardDateTime(this DateTime dt)
        {
            return dt.ToString(StandardDateTimeFormat);
        }

        /// <summary>
        /// 标准日期时间格式[yyyy-MM-dd]
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ToStandardDate(this DateTime dt)
        {
            return dt.ToString(StandardDateFormat);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFramework.Common.Constant;
using MyFramework.Common.Abstract;

namespace MyFramework.Web.Base
{
    [Serializable]
    public class SessionWeb : ISession
    {
        private const string SESSION_KEY = "__SESSION_KEY__";

        public string SessionId { get; set; }

        public String UserId { get; set; }

        public String UserCode { get; set; }

        public String Name { get; set; }

        public UserLevel UserLevel { get; set; }

        public string MasterId { get; set; }

        public string Language { get; set; }

        public static ISession Current
        {
            get
            {
                return (SessionWeb)HttpContext.Current.Session[SESSION_KEY];
            }
            set
            {
                HttpContext.Current.Session[SESSION_KEY] = value;
            }
        }
    }
}

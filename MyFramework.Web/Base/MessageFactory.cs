using System;
using MyFramework.Common.Message.Base;
using MyFramework.Common.Abstract;

namespace MyFramework.Web.Base
{
    /// <summary>
    /// Web层生成Request的工厂
    /// </summary>
    public abstract class MessageFactory
    {
        public static T CreateRequest<T>(MessageRequestType type) where T : Req, new()
        {
            T request = new T();
            ISession session = SessionWeb.Current;
            request.SessionId = SessionWeb.Current.SessionId;
            request.CurrentUserLevel = (int)session.UserLevel;
            //request.MessageLanguage = BasePage.CurrentUserLanguage;
            return request;
        }
    }

    public static class MessageRequestStatus
    {
        public static readonly int User = 0;
        public static readonly int Guest = 0;
    }

    public enum MessageRequestType
    {
        None,
        Ajax,
        Transfer,
        ScriptLogin,
        ScriptBack,
        ScriptAlert,
        OutputBlank
    }

}
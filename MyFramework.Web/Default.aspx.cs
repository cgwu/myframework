using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyFramework.Service.Ioc;
using MyFramework.Service.Abstract.Account;
using MyFramework.Common.NHibernate.Domain;
using MyFramework.Web.Util;
using log4net;
using NHibernate;
using MyFramework.Service.Util;

namespace MyFramework.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        private static ILog log = LogManager.GetLogger("MAIL");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            var sf = Ioc.Container.Resolve<ISessionFactory>("SfCompanyMain");
            log.InfoFormat("连接串为:{0}",sf.OpenSession().Connection.ConnectionString);
            */
            for (int i = 0; i < 10; i++)
            {
                var sess= Ioc.Container.Resolve<INHSessionManager>();
                log.Info(sess.GetHashCode());
            }
            var productRepo = Ioc.Container.Resolve<IProductRepository>("productRepository");
            var product = new Product { Category = this.txtCategory.Text.Trim(), Name = this.txtName.Text.Trim() };
            productRepo.Add(product);

            /*
            for (int i = 0; i < 5; i++)
            {
                log.Info("添加了一个分类info:" + this.txtCategory.Text);
                log.Warn("添加了一个分类warn:" + this.txtCategory.Text);
                log.Error("添加了一个分类error:" + this.txtCategory.Text);
                log.FatalFormat("添加了一个分类error:{0},Name:{1}", this.txtCategory.Text, this.txtName.Text);
            }
            */
            //ClientMsg.WriteAjax(this, "alert('成功')");

            //ClientMsg.Write(this, "alert('成功')");
            //ClientMsg.Show(this, "成功啦，恭喜！");
            ClientMsg.ShowAjax(this, "ajax成功啦，恭喜！");

            //ClientScript.RegisterClientScriptBlock(this.GetType(), "abc", "alert('成功');", true);  //在开始标签<form>标签之前添加脚本
            //ClientScript.RegisterStartupScript(this.GetType(), "abc", "alert('成功');", true);      //在结束标签</form>标签之前添加脚本 ################

            //ClientScript.RegisterStartupScript(typeof(Page), "abc", "alert('成功');", true);      //在结束标签</form>标签之前添加脚本 ################

            //ScriptManager.RegisterClientScriptBlock(this, this.ScriptManager1.GetType(), "abc", "alert('成功');", true);
            //ScriptManager.RegisterStartupScript(this, typeof(ScriptManager), "abc", "alert('成功2');", true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyFramework.Service.Ioc;
using MyFramework.Service.Abstract.Account;
using MyFramework.Common.NHibernate.Domain;

namespace MyFramework.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var productRepo = Ioc.Container.Resolve<IProductRepository>("productRepository");
            var product = new Product { Category = this.txtCategory.Text.Trim(), Name = this.txtName.Text.Trim() };
            productRepo.Add(product);
            this.lblMsg.Text = "成功";
        }
    }
}

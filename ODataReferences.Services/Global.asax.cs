using System;
using System.Data.Entity;
using System.Web;
using ODataReferences.Contracts;

namespace ODataReferences.Services
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<BlogDbContext>());

            var ctx = new BlogDbContext();
            ctx.Posts.Add(new BlogPost { Id = 1, Title = "WCF Data Services" });
            ctx.SaveChanges();
        }
    }
}
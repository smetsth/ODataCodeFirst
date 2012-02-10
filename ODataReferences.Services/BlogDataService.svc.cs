using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;

namespace ODataReferences.Services
{
    public class BlogDataService : DataService<ObjectContext>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }

        protected override ObjectContext CreateDataSource()
        {
            var blogDbContext = new BlogDbContext();

            // Configure DbContext before we provide it to the  
            // data services runtime. 
            blogDbContext.Configuration.ValidateOnSaveEnabled = false;

            // Get the underlying ObjectContext for the DbContext. 
            var context = ((IObjectContextAdapter)blogDbContext).ObjectContext;

            // Return the underlying context. 
            return context;
        }
    }
}
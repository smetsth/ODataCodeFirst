

using System;
using System.Data.Services.Client;
using System.Linq;
using ODataReferences.Contracts;

namespace ODataReferences.Web.Proxies
{
    public class BlogDataProxy : DataServiceContext, IBlogDataResources
    {
        private DataServiceQuery<BlogPost> _posts;

        public BlogDataProxy()
            : base(new Uri("http://fiddler.ipv4:58722/BlogDataService.svc"))
        {
        }

        public IQueryable<BlogPost> Posts
        {
            get
            {
                if ((_posts == null))
                {
                    _posts = base.CreateQuery<BlogPost>("Posts");
                }
                return _posts;
            }
        }
    }
}
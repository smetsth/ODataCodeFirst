using System.Linq;

namespace ODataReferences.Contracts
{
    public interface IBlogDataResources
    {
        IQueryable<BlogPost> Posts { get; }
    }
}
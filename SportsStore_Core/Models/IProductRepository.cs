using System.Linq;

namespace SportsStore_Core.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }    
}

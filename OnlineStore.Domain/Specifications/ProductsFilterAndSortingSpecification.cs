using OnlineStore.Domain.Entities;

namespace OnlineStore.Domain.Specifications
{
    public class ProductsFilterAndSortingSpecification : BaseSpecification<Product>
    {
        public ProductsFilterAndSortingSpecification(ProductSpecParams productParams)
            : base(x =>
            (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search)) &&
            (!productParams.Category.HasValue || x.CategoryId == productParams.Category)
            )
        {
            AddInclude(x => x.Category);
            AddInclude(x => x.Creator);

            ApplyPaging(productParams.PageSize * (productParams.PageIndex - 1), productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch(productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.UnitPrice); // Sort price low to high
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.UnitPrice); // Sort price high to low
                        break;
                    case "nameAsc":
                        AddOrderBy(n => n.Name); // Sort name a to z
                        break;
                    case "nameDesc":
                        AddOrderByDescending(n => n.Name); // Sort name z to a
                        break;
                    case "dateAsc":
                        AddOrderBy(p => p.CreatedAt); // Sort by date oldest first
                        break;
                    case "dateDesc":
                        AddOrderByDescending(p => p.CreatedAt); // Sort by date newest first
                        break;
                    default:
                        AddOrderByDescending(p => p.CreatedAt); // Default order: newest first
                        break;
                }
            }
        }

        public ProductsFilterAndSortingSpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.Category);
            AddInclude(x => x.Creator);
            AddOrderBy(x => x.Name);
            AddOrderBy(x => x.UnitPrice);
        }
    }
}

using AspNetShop.ProductAPI.Data.ValueObjects;

namespace AspNetShop.ProductAPI.Repository;

public interface IProductRepository
{
    Task<IEnumerable<ProductVO>> FindAll();
    Task<ProductVO> FindById(long id);
    Task<ProductVO> Create(ProductVO valueObject);
    Task<ProductVO> Update(ProductVO valueObject);
    Task<bool> Delete(long id);


}
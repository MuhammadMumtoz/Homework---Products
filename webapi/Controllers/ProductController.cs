using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductController
{
    private ProductService _productService;
    public ProductController()
    {
        _productService = new ProductService();
    }

    [HttpGet]
    public List<Product> GetProducts()
    {
        return _productService.GetProducts();
    }
    [HttpPost]
    public int InsertProduct(Product product)
    {
        return _productService.InsertProduct(product);
    }
    [HttpPut]
    public int UpdateProduct(Product product)
    {
        return _productService.UpdateProduct(product);
    }
    [HttpDelete]
    public int DeleteProduct(int id)
    {
        return _productService.DeleteProduct(id);
    }
}

namespace PNI.EShop.Core.Services
{
    public interface IProductCatalogService : IHandlesEvent<ProductCreated>
    {
        void CreateProduct(string name, string description, ModelTypeDefinition type, ColorDefinition color, decimal price);
    }
}
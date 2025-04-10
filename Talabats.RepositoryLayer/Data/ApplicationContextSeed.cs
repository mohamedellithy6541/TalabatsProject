using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabats.RepositoryLayer.Entities;

namespace Talabats.RepositoryLayer.Data
{
    public class ApplicationContextSeed
    {
        public static async Task SeedDataAsync(ApplicationContext context) 
        {
			try
			{
				if (! context.productBrands.Any())
				{
                    var Data = File.ReadAllText("../Talabats.RepositoryLayer/DataSeed/brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(Data);
                    foreach (var brand in brands)
                        context.productBrands.Add(brand);
                    await context.SaveChangesAsync();
                }
                if (!context.productTypes.Any())
				{
                    var Data = File.ReadAllText("../Talabats.RepositoryLayer/DataSeed/types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(Data);
                    foreach (var type in types)
                        context.productTypes.Add(type);
                    await context.SaveChangesAsync();
                }
                if (!context.products.Any())
				{
                    var Data = File.ReadAllText("../Talabats.RepositoryLayer/DataSeed/products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(Data);
                    foreach (var product in products)
                        context.products.Add(product);
                    await context.SaveChangesAsync();
                }


			}
			catch (Exception ex) 
			{

			  throw ex;
			}

        }
    }
}

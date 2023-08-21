using System.ComponentModel.DataAnnotations;
using exam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;

namespace exam.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string InventoryNumber { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public ICollection<ProductName> ProductNames { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<Image> Images { get; set; }


    }


    //public static class ProductEndpoints
    //{
    //	public static void MapProductEndpoints (this IEndpointRouteBuilder routes)
    //    {
    //        var group = routes.MapGroup("/api/Product").WithTags(nameof(Product));

    //        group.MapGet("/", async (ApplicationDbContext db) =>
    //        {
    //            return await db.Products.ToListAsync();
    //        })
    //        .WithName("GetAllProducts")
    //        .WithOpenApi();

    //        group.MapGet("/{id}", async Task<Results<Ok<Product>, NotFound>> (int id, ApplicationDbContext db) =>
    //        {
    //            return await db.Products.AsNoTracking()
    //                .FirstOrDefaultAsync(model => model.Id == id)
    //                is Product model
    //                    ? TypedResults.Ok(model)
    //                    : TypedResults.NotFound();
    //        })
    //        .WithName("GetProductById")
    //        .WithOpenApi();

    //        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Product product, ApplicationDbContext db) =>
    //        {
    //            var affected = await db.Products
    //                .Where(model => model.Id == id)
    //                .ExecuteUpdateAsync(setters => setters
    //                  .SetProperty(m => m.Id, product.Id)
    //                  .SetProperty(m => m.Name, product.Name)
    //                  .SetProperty(m => m.Description, product.Description)
    //                  .SetProperty(m => m.InventoryNumber, product.InventoryNumber)
    //                  .SetProperty(m => m.Price, product.Price)
    //                  .SetProperty(m => m.Cost, product.Cost)
    //                );

    //            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
    //        })
    //        .WithName("UpdateProduct")
    //        .WithOpenApi();

    //        group.MapPost("/", async (Product product, ApplicationDbContext db) =>
    //        {
    //            db.Products.Add(product);
    //            await db.SaveChangesAsync();
    //            return TypedResults.Created($"/api/Product/{product.Id}",product);
    //        })
    //        .WithName("CreateProduct")
    //        .WithOpenApi();

    //        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ApplicationDbContext db) =>
    //        {
    //            var affected = await db.Products
    //                .Where(model => model.Id == id)
    //                .ExecuteDeleteAsync();

    //            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
    //        })
    //        .WithName("DeleteProduct")
    //        .WithOpenApi();
    //    }
    //}}
}

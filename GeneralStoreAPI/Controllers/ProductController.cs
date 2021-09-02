using GeneralStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GeneralStoreAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly GeneralStoreDbContext _context = new GeneralStoreDbContext();

        // C
        [HttpPost]
        public async Task<IHttpActionResult> PostProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                // This adds the product to the C# representation of the database, not the actual database
                _context.Products.Add(product);
                // This translates our changes to SQL and then executes them
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState);
        }
        // R
        [HttpGet]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        // U
        [HttpPut]
        [Route("api/Product/{id}/Update")]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] int id, [FromBody] ProductUpdate newProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            Product oldProduct = await _context.Products.FindAsync(id);
            
            if (oldProduct == null)
            {
                return NotFound(); // 404
            }

            oldProduct.Name = newProduct.Name;
            oldProduct.Price = newProduct.Price;
            // oldProduct.Quantity = newProduct.Quantity;
            oldProduct.UPC = newProduct.UPC;

            await _context.SaveChangesAsync();

            return Ok(); // 200
        }

        [HttpPut]
        [Route("api/Product/{id}/Restock")]

        // Define the pattern in App_Start/RouteConfig.cs

        //        route      action
        // ../api/Product/1/Restock
        // OR
        // ../api/Product/Restock/1

        // ../api/Product/1/SomethingElse

        public async Task<IHttpActionResult> RestockProduct([FromUri] int id, [FromBody] Restock restock)
        {
            Product product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            product.Quantity += restock.Amount;

            await _context.SaveChangesAsync();
            return Ok();
        }
        // D
    }
}

using Microsoft.AspNetCore.Mvc;
using MyProductAPI.Models;
using System.Collections.Generic;

namespace MyProductAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/Products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region -- initialize Products --
        private static readonly List<Product> Products = new List<Product>
        {
            new Product{Id=1,Name="Black Jeans",Price=529.75m},
            new Product{Id=2,Name="White Polo Shirt",Price=255.50m},
            new Product{Id=3,Name="Air Jordan Shoes",Price=152.25m}
        };
        #endregion

        #region -- GET: api/products --
        // GET: api/products
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return await Task.FromResult(Ok(Products));
        }
        #endregion

        #region --  GET: api/products/{id} --
        // GET: api/products/{id}
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProductByID(int id)
        {
            //var product = Products.FirstOrDefault(p => p.Id == id);
             var productwithID = Products.Find(product => product.Id == id);

            if (productwithID == null)
            {
                return await Task.FromResult(NotFound(new { Message = $"Product with ID {id} not found!" }));

            }
            return await Task.FromResult(Ok(productwithID));
        }
        #endregion

        #region -- POST: api/products --
        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<Product>> AddNewProduct([FromBody] Product newProduct)
        {
            if (newProduct == null)
            {
                return await Task.FromResult(BadRequest(new { Message = "Invalid Product data" }));
                //return BadRequest();
            }

            // Generate a new ID by finding the max ID and adding 1
            var newId = Products.Any() ? Products.Max(p => p.Id) + 1 : 1;
            newProduct.Id = newId;

            Products.Add(newProduct);

            return await Task.FromResult(CreatedAtAction(nameof(GetProductByID), new { id = newProduct.Id }, newProduct));
        }
        #endregion
    }
}

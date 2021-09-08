﻿using Armazem.API;
using Armazem.Controllers;
using Armazem.Models;
using Armazem.Services;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArmazemTest
{
    public class ProductControllerTest
    {
        int ProductQuantity = 10;
        List<Product> fakeProducts;
        public ProductControllerTest()
        {
            fakeProducts = new List<Product>();
            for (var i = 1; i <= ProductQuantity; i++)
                fakeProducts.Add(new Product { Id = i, Name = $"Prod {i}" });
        }

        [Fact] 
        public void GetProducts_Returns_The_Correct_Products()
        {
            var productService = A.Fake<IProductService>();
            A.CallTo(() => productService.All()).Returns(fakeProducts); 
            var controller = new ProductController(productService);

            OkObjectResult result = controller.Index() as OkObjectResult; 

            var values = result.Value as APIResponse<List<Product>>;
            Assert.True(
                    values.Results == fakeProducts &&
                    values.Message == "" &&
                    values.Succeed
                    );
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(0, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(1250, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(-328, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(null, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(13, "Não foi encontrado o produto solicitado.", false)]
        public void GetProduct_Return_Product_By_Id(int? id, string message = "", bool succeed = true)
        {
            var productService = A.Fake<IProductService>();
            A.CallTo(() => productService.Get(id)).Returns(fakeProducts.Find(p => p.Id == id));

            var controller = new ProductController(productService);

            ObjectResult result = controller.Index(id) as ObjectResult;

            var exists = fakeProducts.Find(p => p.Id == id) != null;

            if (exists)
            {
                var values = result.Value as APIResponse<Product>;
                Assert.True(
                    values.Succeed == succeed &&
                    values.Message == message &&
                    values.Results == fakeProducts.Find(p => p.Id == id)
                );
            }
            else
            {
                var values = result.Value as APIResponse<string>;
                Assert.True(
                    values.Succeed == succeed &&
                    values.Message == message &&
                    values.Results == null
                );
            }
        }
    }
}

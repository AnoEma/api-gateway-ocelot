﻿using Microsoft.AspNetCore.Mvc;

namespace OrderProcessing.Product.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAllCustomers()
    {
        return await _productRepository.GetAllProducts();
    }
}
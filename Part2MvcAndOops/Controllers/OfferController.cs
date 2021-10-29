using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Part2MvcAndOops.Models;
using Part2MvcAndOops.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2MvcAndOops.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }


        [HttpGet]
        [Route("getOffers")]
        public async Task<List<Offer>> GetOffers()
        {
            var result = await _offerService.GetTodaysOffers();
            return result;
        }


        [HttpGet]
        [Route("getproducts")]

        public async Task<List<Product>> GetAllProducts()
        {
            var result = await _offerService.GetAllProducts();
            return result;
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _offerService.AddProduct(product);
            return Ok();
        }
    
}
}

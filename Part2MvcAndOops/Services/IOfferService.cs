using Part2MvcAndOops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2MvcAndOops.Services
{
     public interface IOfferService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Offer>> GetTodaysOffers();
        void AddProduct(Product product);
    }
}

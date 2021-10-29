using Part2MvcAndOops.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Part2MvcAndOops.Models
{
    public class OfferService: IOfferService
    {
        private List<Product> _inventory;
        
        private void  SetInventory()
        {
            _inventory = new List<Product>
            {
                new Product("P1", 1000, "P1 desc"),
                new Product("P2", 200, "P2 desc"),
                new Product("P3", 400, "P3 desc"),
                new Product("P4", 700, "P4 desc"),
                new Product("P5", 600, "P5 desc"),
                new Product("P6", 800, "P6 desc")
            };
        }

        public  OfferService()
        {
            SetInventory();
        }

        public Task<List<Product>> GetAllProducts()
        {
            var task = Task.Run(() =>
            {
                return _inventory;
            });

            return task;
        }


        public async Task<List<Offer>> GetTodaysOffers()
        {
            var random = new Random();

            var offers = new List<Offer>();

            await Task.Run(() =>
            {
                for (int i = 1; i < 5; i++)
                {
                    var products = new List<Product>();
                    products.Add(_inventory[random.Next(0, 5)]);
                    products.Add(_inventory[random.Next(0, 5)]);
                    products.Add(_inventory[random.Next(0, 5)]);

                    var offer = new Offer($"ComboPackage{i}", products);

                    offers.Add(offer);
                }
            });

            return offers;
        }

        public void AddProduct(Product product)
        {
            _inventory.Add(product);
        }
    }
}

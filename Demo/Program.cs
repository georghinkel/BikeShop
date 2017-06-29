using BikeShop.BicycleChallenge;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var challengera2xl = new ProRaceBike
            {
                RaceFrame = new ProRaceFrame
                {
                    Name = "Rocket-A1-XL",
                    Weight = 920.0
                },
                SalesPrice = 4999.0,
                Name = "Challenger A2-XL"
            };

            var stock = new ObservableList<IBikeInStock>
            {
                new BikeInStock { Model = challengera2xl },
                new BikeInStock { Model = challengera2xl },
                new BikeInStock { Model = challengera2xl },
                new BikeInStock { Model = challengera2xl },
                new BikeInStock { Model = challengera2xl },
                new BikeInStock { Model = challengera2xl, DiscountedPrice = 3999.0 }
            };

            // This query gets the average sales price of all bikes in the stock
            var averagePrice = (from bike in stock
                                where bike.Model is IRaceBike
                                select bike.DiscountedPrice.HasValue ? bike.DiscountedPrice.Value : bike.Model.SalesPrice).Average();

            var averagePriceInc = Observable.Expression(() => (from bike in stock
                                                               where bike.Model is IRaceBike
                                                               select bike.DiscountedPrice.HasValue ? bike.DiscountedPrice.Value : bike.Model.SalesPrice)
                                                               .Average());

            // As you can see, the average prices match
            Console.WriteLine($"Average price: {averagePrice} or {averagePriceInc.Value}");

            // Now, we make some changes to the model
            stock[0].DiscountedPrice = 2999.0;

            // This is immediately reflected in the incremental average sales price
            Console.WriteLine($"After the first bike was discounted: {averagePriceInc.Value}");

            // The system also reacts to changes of the default price of bikes
            challengera2xl.SalesPrice -= 500.0;
            Console.WriteLine($"After a general discount, the average sales price is {averagePriceInc.Value}");
        }
    }
}

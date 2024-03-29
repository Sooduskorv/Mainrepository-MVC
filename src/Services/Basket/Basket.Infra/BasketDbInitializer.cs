﻿using Basket.Data.BasketOfProducts;
using Basket.Data.Baskets;
using System;
using System.Collections.Generic;
using System.Linq;
using Sooduskorv_MVC.Aids.Random;

namespace Basket.Infra
{
    public class BasketDbInitializer
    {
        internal static DateTime validFromMinimum = new DateTime(2019, 3, 1, 7, 0, 0);
        internal static DateTime validFromMaximum = DateTime.Now;

        internal static DateTime validToMinimum = DateTime.Now;
        internal static DateTime validToMaximum = new DateTime(2021, 3, 1, 7, 0, 0);

        internal static int randomDataGenerationAmount = 10;

        internal static List<BasketOfProductData> basketOfProducts = new List<BasketOfProductData> { };
        internal static void generateBasketOfProducts()
        {
            for (int i = 0; i < baskets.Count(); i++)
            {
                for (int k = 0; k < randomDataGenerationAmount; k++)
                {
                    basketOfProducts.Add(new BasketOfProductData
                    {
                        Id = Guid.NewGuid().ToString(),
                        ValidFrom = GetRandom.DateTime(validFromMinimum, validFromMaximum),
                        ValidTo = GetRandom.DateTime(validToMinimum, validToMaximum),
                        BasketId = i.ToString(),
                        ProductOfPartyId = k.ToString()
                    });
                }
            }
        }

        internal static List<BasketData> baskets = new List<BasketData> { };
        internal static void generateBaskets()
        {
            for (int i = 0; i < randomDataGenerationAmount; i++)
            {
                baskets.Add(new BasketData
                {
                    BuyerId = GetRandom.Int32(0, randomDataGenerationAmount).ToString(),
                    Id = i.ToString(),
                    Name = GetRandom.String(),
                    ValidFrom = GetRandom.DateTime(validFromMinimum, validFromMaximum),
                    ValidTo = GetRandom.DateTime(validToMinimum, validToMaximum)
                });
            }
        }

        internal static bool initializeBasketOfProducts(BasketDbContext db)
        {
            if (db.BasketOfProducts.Count() != 0) return false;
            generateBasketOfProducts();
            db.BasketOfProducts.AddRange(basketOfProducts);
            db.SaveChanges();
            return true;
        }

        internal static bool initializeBaskets(BasketDbContext db)
        {
            if (db.Baskets.Count() != 0) return false;
            generateBaskets();
            db.Baskets.AddRange(baskets);
            db.SaveChanges();
            return true;
        }

        public static bool Initialize(BasketDbContext db)
        {
            initializeBaskets(db);
            initializeBasketOfProducts(db);
            return true;
        }
    }
}

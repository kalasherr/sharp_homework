using System;
using System.Collections.Generic;

namespace dz_2910
{
    internal class Program
    {
        class Merchant
        {
            public string merchant_name;
            public int merchant_id;
            public int merchant_age;
            public string shop_name;
            public string shop_type;
            public string shop_id;
            public Dictionary<string, int> shop_products;
            public string merchant_type;
            public List<Buyer> merchant_buyers;
            public bool merchant_anger;

            public void Avalibility()
            {
                bool product_avalibility = false;
                Console.WriteLine("Напишите продукт, наличие которого хотите проверить");
                string merchant_product = Console.ReadLine();
                foreach (string product in shop_products.Keys)
                {
                    if (product == merchant_product)
                    {
                        product_avalibility = true;
                    }
                }
                if (product_avalibility)
                {
                    Console.WriteLine("Данный товар присутствует на полках");
                }
                else
                {
                    Console.WriteLine("Данный товар отсутствует");
                }
            }
            public void OtherShops(List<Shop> shop_list)
            {
                Console.WriteLine("Введите товар, который хотите найти в других магазинах");
                string shop_product = Console.ReadLine();
                List<string> checked_shops = new List<string>();
                bool availability = false;
                foreach (var shop_to_check in shop_list)
                {
                    foreach (var product_to_check in shop_products.Keys)
                    {
                        if (product_to_check == shop_product)
                        {
                            availability = true;
                            checked_shops.Add(shop_to_check.shop_name);
                        }
                    }
                }
                if (availability)
                {
                    Console.Write("Товар есть в магазинах: ");
                    foreach (var shop_to_print in checked_shops)
                    {
                        Console.WriteLine(shop_to_print + ", ");
                    }
                }
                else
                {
                    Console.WriteLine("Товара нигде нет :(");
                }
            }
            public void Sell()
            {
                bool availability = false;
                Console.WriteLine("Введите товар который хотите продать и его количество");
                string product_to_sell = Console.ReadLine();
                foreach (var sell_product in shop_products)
                {
                    if (sell_product.Key == product_to_sell)
                    {
                        availability = true;
                    }
                }
                if (availability)
                {
                    Console.WriteLine("Продукт есть на полках. Сколько его единиц вы хотите продать?");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Вы успешно продали {amount} единиц продукта и заработали {amount * Convert.ToDouble(product_to_sell)}");
                }
                else
                {
                    Console.WriteLine("Такого продукта нет на ваших полках");
                }
            }
            public void Talk()
            {
                Console.WriteLine("Выберите с каким покупателем вы хотите поговорить:");
                foreach (var buyer_list_talk in merchant_buyers)
                {
                    Console.WriteLine(buyer_list_talk.buyer_name);
                }
                string buyer_talk = Console.ReadLine();
                foreach (var buyer_list in merchant_buyers)
                {
                    if ((buyer_list.buyer_name == buyer_talk) && (buyer_list.buyer_anger == false))
                    {
                        Console.WriteLine("Вы успешно поговорили с покупателем");
                    }
                    else if ((buyer_list.buyer_name == buyer_talk) && (buyer_list.buyer_anger == true))
                    {
                        Console.WriteLine("Покупатель что то пробурчал под нос и у вас не удалось наладить с ним контакт");

                    }
                }
            }
            public void Fight()
            {
                Console.WriteLine("Напишите имя покупателя, которого хотите выпроводить из магазина");
                foreach (var buyer_list_fight in merchant_buyers)
                {
                    Console.WriteLine(buyer_list_fight);
                }
                string buyer_fight = Console.ReadLine();
                foreach (var buyer_list in merchant_buyers)
                {
                    if ((buyer_list.buyer_name == buyer_fight) && (buyer_list.buyer_anger == false))
                    {
                        Console.WriteLine("Вам удалось без конфликта выпроводить из магазина покупателя по имени " + buyer_list.buyer_name);
                    }
                    else if ((buyer_list.buyer_name == buyer_fight) && (buyer_list.buyer_anger == true))
                    {
                        Console.WriteLine("Покупатель был агрессивно к вам настроен и вам пришлось вступить с ним в драку. Хорошо, что остальные покупатели вас поддержиали");

                    }
                }

            }

        }
        class Shop
        {
            public int shop_id;
            public string shop_name;
            public string shop_type;
            public Dictionary<string, double> shop_products;
            public int shop_age;
            public bool shop_delivery;
            public bool shop_ruined;

            public void Shop_check(List<Shop> shop_list)
            {

                Console.WriteLine("Введите магазин, ассортимент которого хотите проверить");
                string shop_name_to_check = Console.ReadLine();
                foreach (var shop_to_check in shop_list)
                {
                    if (shop_name_to_check == shop_to_check.shop_name)
                    {
                        foreach (var products_to_check in shop_products)
                        {
                            Console.WriteLine(products_to_check+" в наличии");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Такого магазина не существует");
                    }
                }
            }
            public void Shop_destroy(List<Shop> shop_list, List<Shop> ruined_shop_list)
            {
                Console.WriteLine("Введите магазин который хотите уничтожить");
                string shop_to_destroy = Console.ReadLine();
                bool ruined = false;
                foreach (var check_shop_to_destroy in shop_list)
                {
                    if ((check_shop_to_destroy.shop_name == shop_to_destroy)&&(shop_ruined == false))
                    {
                        shop_products.Clear();
                        int shop_age = 0;
                        bool shop_delivery = false;
                        ruined_shop_list.Add(check_shop_to_destroy);
                        shop_list.Remove(check_shop_to_destroy);
                        Console.WriteLine("Магазин был успешно разрушен");
                        shop_ruined = true;
                        ruined = true;
                    }
                    
                }
                if (ruined == false)
                {
                    Console.WriteLine("Такого магазина не существует или он уже разрушен. Жаль не удалось устроить взрыв(");
                }
                
            }
            public void Shop_reanimate(List<Shop> shop_list, List<Shop> ruined_shop_list)
            {
                Console.WriteLine("Введите магазин который хотите восстановить");
                string shop_to_reanimate = Console.ReadLine();
                bool reanimated = false;
                foreach (var check_shop_to_reanimate in ruined_shop_list)
                {
                    if ((check_shop_to_reanimate.shop_name == shop_to_reanimate)&&(shop_ruined == true))
                    {
                        ruined_shop_list.Add(check_shop_to_reanimate);
                        shop_list.Remove(check_shop_to_reanimate);
                        Console.WriteLine("Магазин был успешно восстановлен");
                        check_shop_to_reanimate.shop_ruined = false;
                        reanimated = true;
                    }

                }
                if (reanimated == false)
                {
                    Console.WriteLine("Такого магазина не существует или он не разрушен. Вы не можете его восстановить");
                }
            }

        }
        //class Ruined_shop:Shop
        //{
        //    public int shop_id;
        //    public string shop_name;
        //    public string shop_type;

        //}
        class Product
        {
            public int product_id;
            public string product_type;
            public string product_name;
            public bool product_available;
            public double product_price;
        }
        class Buyer
        {
            public string buyer_name;
            public int buyer_id;
            public int buyer_age;
            public bool buyer_anger;
            public string product_name;
            public double buyer_amount;
            public double buyer_money;
            public bool buyer_delivery;
        }
        static void Main(string[] args)
        {
            List<Shop> shop_list = new List<Shop>();
            List<Shop> ruined_shop_list = new List<Shop>();
        }
    }
}

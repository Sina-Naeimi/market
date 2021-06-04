using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using market.Context.Models;
using MoqTest.Context.Models;

namespace MoqTest.Context
{
    public class MyContext
    {
        public MyContext()
        {
            InitUser();
            InitProduct();
        }

        public List<User> Users = new List<User>();
        public List<Products> Product = new List<Products>();

        public void InitUser()
        {
            Users.Add(new User() { UserName = "sina", Password = "sina1234", Role = "Manager" , Address="wallstreet",PhoneNumber="09126508241"});
            Users.Add(new User() { UserName = "saeed", Password = "saeed1234", Role = "Accountant", Address = "wallstreet", PhoneNumber = "09126508241" });
            Users.Add(new User() { UserName = "amir", Password = "amir1234", Role = "Seller", Address = "wallstreet", PhoneNumber = "09126508241" });
            Users.Add(new User() { UserName = "sohrab", Password = "sohrab1234", Role = "Supplier", Address = "wallstreet", PhoneNumber = "09126508241" });
            Users.Add(new User() { UserName = "aryan", Password = "aryan1234", Role = "PriceController", Address = "wallstreet", PhoneNumber = "09126508241" });
            Users.Add(new User() { UserName = "mahdi", Password = "mahdi1234", Role = "QualityController", Address = "wallstreet", PhoneNumber = "09126508241" });
            Users.Add(new User() { UserName = "mahan", Password = "mahan1234", Role = "Customer", Address = "wallstreet", PhoneNumber = "09126508241" });
        }
        public void InitProduct()
        {
            Product.Add(new Products() { ID = "1", Name = "شامپو کلیر", Price = 100000,Stock=20,Group="شامپو",SubGroup="آرایشی بهداشتی",Date="may 2022",QualityStatus="نامعلوم",PriceStatus= "تایید نشد",PurchaseStatus="",PurchaseCount="", });
            Product.Add(new Products() { ID = "2", Name = "چیپس مزمز", Price = 32000, Stock = 30, Group = "چیپس", SubGroup = "تنقلات",Date="march 2021", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus="", PurchaseCount = "", });
            Product.Add(new Products() { ID = "3", Name = "شامپو صحت", Price = 12000, Stock = 40, Group = "شامپو", SubGroup = "آرایشی بهداشتی",Date="june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
            Product.Add(new Products() { ID = "4", Name = "چیپس چیتوز", Price = 92000, Stock = 25, Group = "چیپس", SubGroup = "تنقلات", Date = "june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
            Product.Add(new Products() { ID = "5", Name = "مسواک سیگنال", Price = 62000, Stock = 45, Group = "مسواک", SubGroup = "آرایشی بهداشتی", Date = "june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
            Product.Add(new Products() { ID = "6", Name = "خمیردندان سیگنال", Price = 32000, Stock = 100, Group = "خمیردندان", SubGroup = "آرایشی بهداشتی", Date = "june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
            Product.Add(new Products() { ID = "7", Name = "پفک نمکی", Price = 1200, Stock = 5, Group = "پفک", SubGroup = "تنقلات", Date = "june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
            Product.Add(new Products() { ID = "8", Name = "سس هزار جزیره", Price = 52000, Stock = 200, Group = "سس", SubGroup = "ادویجات", Date = "june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
            Product.Add(new Products() { ID = "9", Name = "سس کچاپ", Price = 15000, Stock = 60, Group = "سس", SubGroup = "ادویجات", Date = "june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
            Product.Add(new Products() { ID = "10", Name = "شیر دامداران", Price = 25000, Stock = 20, Group = "شیر", SubGroup = "لبنیات", Date = "june 2023", QualityStatus = "نامعلوم", PriceStatus = "نامعلوم", PurchaseStatus = "", PurchaseCount = "", });
        }
    }
}

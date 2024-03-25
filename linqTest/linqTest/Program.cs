// using System.Linq;




Console.WriteLine("Hello, World!");
IEnumerable<int> numbers = Enumerable.Range(1, 10);
List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

List<int> fromList = evenNumbers.Where(n => n > 5).ToList();
IEnumerable<int> fromList2 = evenNumbers.Where(n => n > 5);

IEnumerable<int> myQty = [1, 2, 4, 4, 5, 6, 7, 6, 6, 10];

List<int> myQty2 = myQty.Where(q => q == 6).ToList();
int  myQty3 = myQty.FirstOrDefault(q => q == -1,99);
int  myQty4 = myQty.FirstOrDefault(q => q == 6,99);


IEnumerable<int> myQty5 = myQty.Where(q => q == -1).DefaultIfEmpty(99).Take(1);




// List<Product> products = new List<Product>
// {
//     new Product { Name = "apple", Qty = 10 },
//     new Product { Name = "banana", Qty = 20 },
//     new Product { Name = "cherry", Qty = 30 },
//     new Product { Name = "date", Qty = 40 },
//     new Product { Name = "elderberry", Qty = 40 },
//     new Product { Name = "fig", Qty = 60 },
//     new Product { Name = "grape", Qty = 70 },
//     new Product { Name = "honeydew", Qty = 80 },
//     new Product { Name = "kiwi", Qty = 90 },
//     new Product { Name = "lemon", Qty = 100 }
// };  


List<Product> products =
[
    new Product { Name = "apple", Qty = 10 },
    new Product { Name = "banana", Qty = 20 },
    new Product { Name = "cherry", Qty = 30 },
    new Product { Name = "date", Qty = 40 },
    new Product { Name = "elderberry", Qty = 40 },
    new Product { Name = "fig", Qty = 60 },
    new Product { Name = "grape", Qty = 70 },
    new Product { Name = "honeydew", Qty = 80 },
    new Product { Name = "kiwi", Qty = 90 },
    new Product { Name = "lemon", Qty = 100 }
];  


List<Product> myProd1 = products.Where(q => q.Qty == 40).ToList();

Product? myProd2 = products.OrderByDescending(p => p.Name).FirstOrDefault(q => q.Qty == 40);
Product? myProd3 = products.LastOrDefault(q => q.Qty == 40);





int dog=0;
dog++;


public class Product
    {
        public string? Name { get; set; }
        public int Qty { get; set; }  


    }





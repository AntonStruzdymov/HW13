using HW13Library;

Product[] products = new Product[5];
products[0] = new Product("Сахар","Простор");
products[1] = new Product("Молоко","Грин");
products[2] = new Product("Хлеб", "Простор");
products[3] = new Product("Рис","Евроопт");
products[4] = new Product("Колбаса", "Грин");

for (int i = 0; i < products.Length; i++)
{
    for (int j = 0; j < products.Length - 1; j++)
    {
        if (products[j].shopName.needToReOrder( products[j + 1].shopName))
        {
            var s = products[j];
            products[j] = products[j + 1];
            products[j + 1] = s;
        }
    }
}

string? inquiry = Console.ReadLine();
int count = 0;
foreach (var item in products)
{
    
    if (inquiry == item.shopName) 
    {
        string temp = inquiry;
        Console.WriteLine($"В магазине с названием {temp} есть следующие продукты:");
        foreach (var item1 in products)
        {
            if (temp == item1.shopName)
            {
                Console.WriteLine(item1.name);
            }
        }
        count++;
        break;
    }
    

}
if (count == 0)
{
    throw new UserException($"магазина с названием {inquiry} не существует");
}
int numChickenMenu = int.Parse(Console.ReadLine());
int numFishMenu = int.Parse(Console.ReadLine());
int numVegetarMenu = int.Parse(Console.ReadLine());

double priceChickenMenuBgn = 10.35;
double priceFishMenuBgn = 12.40;
double priceVegetarMenuBgn = 8.15;
double priceDeliveryBgn = 2.50;

double priceAllOrderedMenu = (numChickenMenu * priceChickenMenuBgn) + (numFishMenu * priceFishMenuBgn) + (numVegetarMenu * priceVegetarMenuBgn);
double priceDessertBgn = priceAllOrderedMenu * 0.20;
double finalBill = priceAllOrderedMenu + priceDessertBgn + priceDeliveryBgn;

Console.WriteLine($"{finalBill}");




int amountNylonSqM = int.Parse(Console.ReadLine());
int amountPaintL = int.Parse(Console.ReadLine());
int quantityThinnerL = int.Parse(Console.ReadLine());
int hoursWork = int.Parse(Console.ReadLine());


double priceNylonBgn = 1.50;
double pricePaintBgn = 14.50;
double pricePaintThinnerBgn = 5.00;
double priceBagsBgn = 0.40;

double totalCostNylonBgn = (amountNylonSqM + 2) * priceNylonBgn;
double totalCostPaintBgn = (amountPaintL + amountPaintL * 0.10) * pricePaintBgn;
double totalCostThinnerBgn = quantityThinnerL * pricePaintThinnerBgn;

double totalPriceMaterials = totalCostNylonBgn + totalCostPaintBgn + totalCostThinnerBgn + priceBagsBgn;
double craftsmanWages = (totalPriceMaterials * 0.30) * hoursWork;

double sumOfAllCosts = totalPriceMaterials + craftsmanWages;

Console.WriteLine($"{sumOfAllCosts}");

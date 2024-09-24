int annualBasketballTrainFee = int.Parse(Console.ReadLine());

double priceSneakers = annualBasketballTrainFee - (annualBasketballTrainFee * 0.40);
double priceUniform = priceSneakers - (priceSneakers * 0.20);
double priceBall = priceUniform / 4;
double priceAccessories = priceBall / 5;

double totalExpences = annualBasketballTrainFee + priceSneakers + priceUniform + priceBall + priceAccessories;

Console.WriteLine(totalExpences);

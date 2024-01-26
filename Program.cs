// Mis 3033 HW1
// task 1
//Camille Duryea
//113529005

const double cogPriceDbl = 79.99;
const double gearPriceDbl = 250.00;
const double normalMarkupDbl = 0.15;
const double discountMarkupDbl = 0.125;
const double salesTaxRateDbl = 0.089;

int numOfCogsInt;
int numOfGearsInt;

double normalSubtotalDbl;

double actualSubtotalDbl;
double discountAmountDbl;
double salesTaxAmountDbl;
double grandTotalDbl;

double actualMarkupDbl;

string outMesStr = "Please input the number of cogs: ";
Console.Write(outMesStr);
string inputStr = Console.ReadLine();
numOfCogsInt = Convert.ToInt32(inputStr);


outMesStr = "Please input the number of gears: ";
Console.Write(outMesStr);
inputStr = Console.ReadLine();
numOfGearsInt = Convert.ToInt32(inputStr);

if (numOfCogsInt > 10 || numOfGearsInt > 10 || numOfCogsInt + numOfGearsInt > 16)
{
    actualMarkupDbl = 0.125;

}
else
{
    actualMarkupDbl = 0.15;
}
normalSubtotalDbl = (numOfCogsInt * cogPriceDbl + numOfGearsInt * gearPriceDbl) * (1 + normalMarkupDbl);
actualSubtotalDbl = (numOfCogsInt * cogPriceDbl + numOfGearsInt * gearPriceDbl) * (1 + actualMarkupDbl);

discountAmountDbl = normalSubtotalDbl - actualSubtotalDbl;
salesTaxAmountDbl = actualSubtotalDbl * salesTaxRateDbl;
grandTotalDbl = actualSubtotalDbl + salesTaxAmountDbl;

outMesStr = "Receipt:";
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Num. Of Cogs: {numOfCogsInt}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Num. Of Cogs: {numOfGearsInt}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Subtotal: {actualSubtotalDbl:C2}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Discount: {discountAmountDbl:C2}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Sales tax: {salesTaxAmountDbl:C2}");
Console.WriteLine(outMesStr);
outMesStr = String.Format($"Grand total: {grandTotalDbl:C2}");
Console.WriteLine(outMesStr);






Console.ReadLine();




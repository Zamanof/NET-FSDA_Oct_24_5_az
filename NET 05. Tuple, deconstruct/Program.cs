// tuple - new in C# 7
//(int, double) myTuple = (5, 15.5);
//Console.WriteLine(myTuple.Item1);
//Console.WriteLine(myTuple.Item2);

//(int summ, double price, string name) myTuple2 = (2569, 25.6, "Nadir");
//Console.WriteLine(myTuple2.summ);
//Console.WriteLine(myTuple2.price);
//Console.WriteLine(myTuple2.name);

//var result = CalculateSumAndAverage(5, 2);
//int some;
//(int summ, float aver, some) = CalculateSumAndAverage(5, 2);

//Console.WriteLine(result.Item1);
//Console.WriteLine(result.Item2);
//Console.WriteLine(result.Item3);

//Console.WriteLine(summ);
//Console.WriteLine(aver);
//Console.WriteLine(some);

//(_, float aver1, _) = CalculateSumAndAverage(5, 2);
//Console.WriteLine(aver1);

Car car = new("Prius", "Toyota", 2025);
Car car1 = new("e6", "BYD", 2036);
//Console.WriteLine(car);
//var model = car.Model;
//var maufacturer = car.Manufacturer;
//var year = car.Year;

(string model, string manufacturer, int year) = car;
(_, var manuf, _) = car;
//Console.WriteLine(model);
//Console.WriteLine(manufacturer);
//Console.WriteLine(year);
Console.WriteLine(manuf);

(int, float, int) CalculateSumAndAverage(int numb1, int numb2)
{
    int sum = numb1 + numb2;
    float average = sum / 2.0f;
    return (sum, average, 786);
}

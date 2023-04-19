#region 1
//int m, n;
//char ch1 , ch2 ;
//double d1 , d2 ;
//float pl = 3.14f;
#endregion

#region 2
//long x; // 10 bytes 
//double d; // 10 bytes
//char ch; // 1 byte
//float f1 , f2; // 4 bytes
#endregion

#region 3
// x = 5 , y = 4
// m = x + (y*2) / 6 + y / 8;

//int x = 5;
//int y = 4;
//int m = x + (y * 2) / 6 + y / 8;
//m = 5 + 8 / 6 + y / 8;
//m = 5 + 1 + 4 / 8;
//m = 5 + 1 + 0;
//Console.WriteLine(m);  // m = 6;
#endregion

#region 4
// x = 4 , y = 3
// m = x > y ? * 3 : y * 3;
//int x = 4;
//int y = 3;
//int m = 4 > 3 ? 4 * 3 : 3 * 3;
//m = 4 * 3;
//Console.WriteLine(m);
#endregion

#region 5
//int x;
//x = sizeof(double);
//Console.WriteLine(x); // 8
#endregion

#region 6
//int x = 2;
//int y = 0;

// // y = 255 * x - 18 * x + 15;

// //calculate y without *
//int y1;
//int y2;
//int y3;

//y1 = x << 8;
//Console.WriteLine(y1);

#endregion

#region 7

//int y;
//int x;
//int m;
////int m = (y = 0, x = ++y, m = y, y + 2);

//y = 0;
//x = ++y; // x , y = 1
//m = y; // m = 1;
//y += 2; // y = 3

//m = 1; // answer
#endregion

#region 8
//double m = 3.0e-23;
//int l = 950; // 950 g

//int w = 0;
//w = int.Parse(Console.ReadLine());

//l = l * w;

//var resuls = l / m;
//Console.WriteLine(resuls);

#endregion

#region 9
// Calculate your age in second 
//double seconds = 3.156 * Math.Pow(10, 7); // 1 year in second
//int year = 0;

//Console.WriteLine("Please Enter Your Age : ");
//year = int.Parse(Console.ReadLine());

//double result = year * seconds;
//Console.WriteLine(result);
#endregion

#region 10
// your salary
//Console.WriteLine("Pleade enter your salary : ");
//double salary = double.Parse(Console.ReadLine());
//double insurance = (salary * 7) / 100;
//Console.WriteLine($"Pleade enter your insurance : {insurance}");
//double tax = (salary * 10) / 100;
//Console.WriteLine($"Pleade enter your tax : {tax}");

//Console.WriteLine("------------------------------------------------");
//Console.WriteLine($"your salary : {salary - (tax + insurance)}");

#endregion

#region 11
// swelling = (now - last) / last;
// next = last + now * tavarom;
//Console.WriteLine("Please enter current price : ");
//int currentPrice = int.Parse(Console.ReadLine());

//Console.WriteLine("Please enter last year price : ");
//int lastYearPrice = int.Parse(Console.ReadLine());

//int swelling = (currentPrice - lastYearPrice) / lastYearPrice;
//Console.WriteLine($"swelling is : {swelling}");

//int nextYearPrice = lastYearPrice + currentPrice * swelling;
//Console.WriteLine($"next year price : {nextYearPrice}");

#endregion
Console.ReadKey();
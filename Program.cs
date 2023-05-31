
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число:");
// int num=Convert.ToInt32  ( Console.ReadLine());
// // int num1=num/10000;
// if ((num>=10000)&&(num<100000))
// {
//     int num1=num/1000;
//     int num2=num%10;
//     int num3=num%100;
//     int num4=num3/10;
//     int num5=num2*10;
//     int num6=num5+num4;
//     if (num1==num6)
//     {
//          Console.WriteLine("да");
//     }
// else 
// {
//     Console.WriteLine("нет");
// }    
// }
   
//_________________________________________________________________________________

// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите число:");
// int x1=Convert.ToInt32  ( Console.ReadLine());
// Console.WriteLine("Введите число:");
// int y1=Convert.ToInt32  ( Console.ReadLine());
// Console.WriteLine("Введите число:");
// int z1=Convert.ToInt32  ( Console.ReadLine());
// Console.WriteLine("Введите число:");
// int x2=Convert.ToInt32  ( Console.ReadLine());
// Console.WriteLine("Введите число:");
// int y2=Convert.ToInt32  ( Console.ReadLine());
// Console.WriteLine("Введите число:");
// int z2=Convert.ToInt32  ( Console.ReadLine());
// double d=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y2),2)+Math.Pow((z2-z1),2));
// Console.WriteLine(d);

//___________________________________________________________________________________

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int num=Convert.ToInt32  ( Console.ReadLine());
int count=1;
while (num>=count)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}

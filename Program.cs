// задача 19
Console.WriteLine("Введите пятизначное число");
int A = Convert.ToInt32(Console.ReadLine());
string poli = Convert.ToString(A);
if (poli.Length == 5) { 
    if (poli[0].ToString() + poli[1].ToString() == poli[4].ToString() + poli[3].ToString()){
    Console.WriteLine("Да");
} else {Console.WriteLine("Нет");}
} else {Console.WriteLine("Строго пятизначное число");}
//Задача 21
Double x1, x2, y1, y2, z1, z2, distance;
Console.WriteLine("Введите координаты");
Console.WriteLine("точка A");
Console.WriteLine("X");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z");
z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты");
Console.WriteLine("точка B");
Console.WriteLine("X");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z");
z2 = Convert.ToDouble(Console.ReadLine());
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
Console.WriteLine(distance);

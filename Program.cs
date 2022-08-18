// задача 19
Console.WriteLine("Введите пятизначное число");
int A = Convert.ToInt32(Console.ReadLine());
string poli = Convert.ToString(A);
if (poli.Length == 5) { 
    if (poli[0].ToString() + poli[1].ToString() == poli[4].ToString() + poli[3].ToString()){
    Console.WriteLine("Да");
} else {Console.WriteLine("Нет");}
} else {Console.WriteLine("Строго пятизначное число");}
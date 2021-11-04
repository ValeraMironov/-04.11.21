double a;
double b;
Console.Write("Введите число a:");
string s = Console.ReadLine();
a=Convert.ToInt32(s);

Console.Write("Введите число b:");
s = Console.ReadLine();
b=Convert.ToInt32(s);
if(a == b*b){
Console.WriteLine("Являеться");
}
else{
Console.WriteLine("Не являеться");
}
int Max(int a1, int a2, int a3)
{
    int resulte = a1;
if(a2 > resulte) resulte = a2;
if(a3 > resulte) resulte = a3;
return resulte;
}
int a1 = new Random().Next(0,10);
Console.WriteLine(a1);
int a2 = new Random().Next(0,10);
Console.WriteLine(a2);
int a3 = new Random().Next(0,10);
Console.WriteLine(a3);
Console.WriteLine(Max);
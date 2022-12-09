// Вид 1
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

// Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// Вид 2_1
// void Method2_1(string msg, int count)
// {
//    int i = 0;
//    while(i < count)
//    {
//     Console.WriteLine(msg);
//     i++;
//    }
// }
// Method2_1(msg:"Текст сообщения",4); // можно ввести и в обратном порядке Method2_1(4, msg:"Текст сообщения");

// Вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int Year = Method3();
// Console.WriteLine(Year);

// Вид 4
// string Method4(int count,string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, " z");
// Console.WriteLine(res);

// Вид 4_1 FOR
// string Method4_1(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4_1(10, "z ");
// Console.WriteLine(res);


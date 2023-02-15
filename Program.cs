/*Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.
78 -> третьей цифры нет
3267900 -> 6
ДОП: цифра третья может быть как с левой стороны, так и с правой*/

Console.Write("Введите семизначное число: ");
    int namber = Convert.ToInt32(Console.ReadLine());
Console.Write($"Откуда будем считать? Если слева, то нажмите Le Если справа, то нажмите right :   "); 
string side = Console.ReadLine();
int result = (namber / 10000) % 10 ;
int result2 = (namber / 100) % 10 ;

if (namber >= 1000000 && namber < 10000000  )   
{
    if (side == "Le")
    {
     Console.WriteLine("да, это семизначное число, все правильно ");   
     Console.WriteLine($"третья СЛЕВА цифра этого числа  {result}  ");  
    }  
    else if (side == "right")
    //if (side == "Ri")
     Console.WriteLine("да, это семизначное число, все правильно ");   
     Console.WriteLine($"третья СПРАВА цифра этого числа  {result2}  ");  
}
else
{
     Console.Write($"Нет, число {namber} не семизначное. Перезапустите программу и Повторите попытку "); 
        
}


 
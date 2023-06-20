using System;

void Function()
{
    Console.WriteLine("Hello World");
}

void Function2(int num)
{
    int sum = num * 10;
    Console.WriteLine($"{num} * 10 = {sum}");
}

Function();

for (int i = 0; i < 5; i++)
{
    Function2(i+1);
}


    
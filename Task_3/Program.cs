// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Numer (int n)
{
    int i = 1;
    double cub = 0;

    while (n >= i){
       cub = Math.Pow(i,3);
       Console.WriteLine(cub);
       i +=1;
    }

}
Numer(6);

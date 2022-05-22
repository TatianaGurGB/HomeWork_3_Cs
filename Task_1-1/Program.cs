// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом. Решение по образцу.

void Palindrom (int n)
{
    int i = 0;
    string num = n.ToString ();
    int size = num.Length - 1;
    string flag = "yes";

    while (i < size / 2) {
        if (num[i] != num[size - i])
        {
            flag = "no";
            break;
        }
        i +=1;
    }
    Console.WriteLine($"{n}->{flag}");
}
Palindrom (13456);
Palindrom (12341);
Palindrom (12321);
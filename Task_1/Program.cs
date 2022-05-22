// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// Пыталась сделать по-своему, чтобы не повторяться, работает только в "вакууме":(


void Palindrom(int n)
{
    string n_str = n.ToString();
    int i = 0;
    int size = n_str.Length;
    string flag = "yes";
    while (i < 2)
    {
        if (n_str[i] == n_str[size - 1])
        {
        i += 1;
        size -= 1;
        }    
        else  {
            flag = "no";
            break;
        }
    }
   Console.WriteLine($"{n} -> {flag}"); 
}

Palindrom(34567);
Palindrom(12321);

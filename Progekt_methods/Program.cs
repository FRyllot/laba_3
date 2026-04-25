using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(SafeDivide(10, 2));  
        Console.WriteLine(SafeDivide(10, 0));  

        Console.WriteLine(RegisterUser("Иван", 25, "ivan@mail.ru"));  
        Console.WriteLine(RegisterUser("", 20, "test@mail.ru"));      
        Console.WriteLine(RegisterUser("Петр", 16, "petr@mail.ru"));  
        Console.WriteLine(RegisterUser("Анна", 30, "anna.ru"));       
    }

    static double? SafeDivide(int a, int b)
    {
        if (b == 0)
            return null;
        return (double)a / b;
    }

    static bool RegisterUser(string name, int age, string email)
    {
        if (string.IsNullOrEmpty(name))
            return false;
        if (age < 18)
            return false;
        if (!email.Contains('@'))
            return false;

        Console.WriteLine($"Пользователь {name} зарегистрирован");
        return true;
    }
}

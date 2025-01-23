
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;
using System;
using enum_Task_1;


//Пример задачи 1: Управление пользователями
//Описание:
//Создайте класс UserManager, который работает с массивом пользователей.
//Каждый пользователь имеет имя и статус из enum (ACTIVE, INACTIVE).Реализуйте:

//Поиск пользователя по имени.
//Подсчёт пользователей со статусом INACTIVE.
//Выброс исключения, если пользователь не найден.
//Классы:

//User – класс пользователя с полями: name(String) и status(enum).
//UserManager – класс-менеджер для работы с массивом пользователей.
//UserStatus – enum для статусов пользователя(ACTIVE, INACTIVE).
//Методы:

//UserManager.findUserByName(String name) – поиск пользователя по имени.
//UserManager.countInactiveUsers() – подсчёт пользователей со статусом INACTIVE.
//Пример ввода:
//Пользователи:
//[User("Alice", ACTIVE), User("Bob", INACTIVE), User("Charlie", INACTIVE)]

//Вывод:
//Найден пользователь: Alice
//Количество пользователей со статусом INACTIVE: 2

public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество пользователей: ");
        int? usersAmount = int.Parse(Console.ReadLine());

        var users = new List<User>();

        for(int i = 0; i < usersAmount; i++)
        {
            Console.WriteLine("Введите имя пользователя: ");
            string? userName = Console.ReadLine();
            Console.WriteLine("Введите статус пользователя: ACTIVE или INACTIVE");
            string? userStatus = Console.ReadLine();
            users.Add(new User(userName, userStatus));
        }
        Console.WriteLine("Введите имя пользователя, которого хотите найти: ");
        string? userSearchFoundResult = Console.ReadLine();
        UserManager.FindUserByName(users, userSearchFoundResult);
        UserManager.countInactiveUsers(users);
    }
}
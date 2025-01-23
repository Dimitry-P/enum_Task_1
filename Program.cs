
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;
using System;
using enum_Task_1;


//������ ������ 1: ���������� ��������������
//��������:
//�������� ����� UserManager, ������� �������� � �������� �������������.
//������ ������������ ����� ��� � ������ �� enum (ACTIVE, INACTIVE).����������:

//����� ������������ �� �����.
//������� ������������� �� �������� INACTIVE.
//������ ����������, ���� ������������ �� ������.
//������:

//User � ����� ������������ � ������: name(String) � status(enum).
//UserManager � �����-�������� ��� ������ � �������� �������������.
//UserStatus � enum ��� �������� ������������(ACTIVE, INACTIVE).
//������:

//UserManager.findUserByName(String name) � ����� ������������ �� �����.
//UserManager.countInactiveUsers() � ������� ������������� �� �������� INACTIVE.
//������ �����:
//������������:
//[User("Alice", ACTIVE), User("Bob", INACTIVE), User("Charlie", INACTIVE)]

//�����:
//������ ������������: Alice
//���������� ������������� �� �������� INACTIVE: 2

public class Program
{
    static void Main()
    {
        Console.WriteLine("������� ���������� �������������: ");
        int? usersAmount = int.Parse(Console.ReadLine());

        var users = new List<User>();

        for(int i = 0; i < usersAmount; i++)
        {
            Console.WriteLine("������� ��� ������������: ");
            string? userName = Console.ReadLine();
            Console.WriteLine("������� ������ ������������: ACTIVE ��� INACTIVE");
            string? userStatus = Console.ReadLine();
            users.Add(new User(userName, userStatus));
        }
        Console.WriteLine("������� ��� ������������, �������� ������ �����: ");
        string? userSearchFoundResult = Console.ReadLine();
        UserManager.FindUserByName(users, userSearchFoundResult);
        UserManager.countInactiveUsers(users);
    }
}
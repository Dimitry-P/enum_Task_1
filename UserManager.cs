using System.Collections.Generic;
using System.Xml.Linq;

namespace enum_Task_1
{
    public class UserManager()
    {
        //UserManager.findUserByName(String name) – поиск пользователя по имени.
        //UserManager.countInactiveUsers() – подсчёт пользователей со статусом INACTIVE.

        public static void FindUserByName(List<User>users, string insertedName)
        {
            foreach (User user in users)
            {
                if (string.Equals(user.Name, insertedName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Найден пользователь: {insertedName}");
                }
                else
                {
                    Console.WriteLine("Ничего не найдено!");
                }
            }
        }
        public static void countInactiveUsers(List<User>users)
        {
            int totalCountOfInactiveUsers = 0;
            for (int i = 0; i < users.Count; i++)
            {
                //if (== "inactive555")
                //{
                //    totalCountOfInactiveUsers++;
                //}
            }
            Console.WriteLine($"Количество пользователей со статусом INACTIVE: {users[0].StatusString}"); 
        }
    }
}

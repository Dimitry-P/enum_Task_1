using System;
using static enum_Task_1.UserStatus;

namespace enum_Task_1
{
    public class User
    {
        public string Name
        {
            get;
            
        }




        string status = " ";
        public string StatusString
        {
            get
            {
                return status;
            }
            set
            {
                if (StatusString == userStatus.ACTIVE.ToString())
                {
                    status = "active";
                }

                if (StatusString == userStatus.INACTIVE.ToString())
                {
                    status = "inactive555";
                }
            }
        }

        public User(string userName, string userStatus)
        {
            Name = userName;
            StatusString = userStatus;
        }
    }
}

//name(String) и status(enum)

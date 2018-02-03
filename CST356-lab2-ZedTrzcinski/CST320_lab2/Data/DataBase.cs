using CST320_lab2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CST320_lab2.Data
{
    public static class DataBase
    {
        public static List<User> users = new List<User>();

        public static int Id = 0;

        public static int NextId()
        {
            return ++Id; 
        }

    }
}
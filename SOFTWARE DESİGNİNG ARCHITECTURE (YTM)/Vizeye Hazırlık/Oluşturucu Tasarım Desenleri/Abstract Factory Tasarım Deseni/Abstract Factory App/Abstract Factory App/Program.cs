using System;
using Abstract_Factory_App.DataBase;

namespace Abstract_Factory_App
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db = DataBase.GetDB();
        }
    }
}

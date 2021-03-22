using System;

namespace HandsOn_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConn instance1 = DBConn.GetInstance;
            instance1.CallerMethod();

            DBConn instance2 = DBConn.GetInstance;
            instance2.CallerMethod();
        }
    }
}

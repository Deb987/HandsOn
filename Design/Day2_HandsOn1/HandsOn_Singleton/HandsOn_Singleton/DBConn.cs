using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Singleton
{
    public class DBConn
    {
        private static DBConn instance = null;
        private static int count = 0;
        private static readonly object obj = new object();
        private DBConn()
        {
            count++;
            Console.WriteLine("Constructer called. Counter is at " + count);
        }
        public static DBConn GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new DBConn();
                            return instance;
                        }
                    }
                }
                return instance;
            }
        }
        
        private static DBConn getInstance()
        {
            return GetInstance;
        }
        public void CallerMethod()
        {
            getInstance();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP13
{
    class SingleTon
    {
        private static SingleTon instance;

        private SingleTon()
        { }

        public static SingleTon getInstance()
        {
            if (instance == null)
            {
                instance = new SingleTon();
                MessageBox.Show("Singleton создан");
            }
            return instance;
        }
    }
}

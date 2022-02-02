using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nведите строку, содержащую скобки трёх видов: круглые (), квадратные [] и фигурные {} и любые другие символы:");
            
            string str = Console.ReadLine();
            Console.WriteLine(StrCheck(str) ? "В введенной строке - скобки расставлены корректно" : "В введенной строке - скобки расставлены некорректно");
            Console.ReadKey();
        }
        static bool StrCheck(string str)
        {
            Stack<char> st = new Stack<char>();
            foreach (var s in str)
            {
                if (s == '[')
                    st.Push(']');
                if (s == '(')
                    st.Push(')');
                if (s == '{')
                    st.Push('}');
                if (st.Count != 0 && s == st.Peek())
                    st.Pop();
            }
            if (st.Count != 0)
                return false;
            return true;
        }
    }

}


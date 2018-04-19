using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{

    [Serializable]
    public class Point
    {
        public char X;
        public char Y;
        public char Z;
        public int A;
        public short B;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 'A';
            p.Y = 'A';
            p.Z = 'A';
            p.A = 3;
            p.B = 3;

            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, p);
            var length =  ms.Position;
            var t1 = ms.ToArray();






            int i = 3;
            object o = i;
            testfunc(o);
            Console.ReadLine();
        }

        static void testfunc(object o)
        {
            object b = o;
            return;
        }
    }
}

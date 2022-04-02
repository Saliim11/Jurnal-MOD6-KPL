using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //panji
            DataMahasiswa1302200089.ReadJSON();

            //mamangjimjim1
            DataMahasiswa_1302204092 obj1 = new DataMahasiswa_1302204092();
            obj1.ReadJSON();

            //Aliim
            DataMahasiswa1302200119.ReadJson();

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modul4KPL_1302201135
{
    public class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<double> data = new Penjumlahan<double>();
            data.JumlahTigaAngka(13, 02, 20);

            SimpleDataBase<double> dataBaru = new SimpleDataBase<double>();
            dataBaru.SimpleDatabase();
            dataBaru.AddNewData(13);
            dataBaru.AddNewData(02);
            dataBaru.AddNewData(20);
            dataBaru.PrintAllData();


        }
    }
}
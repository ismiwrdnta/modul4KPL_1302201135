using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modul4KPL_1302201135
{
	public class Penjumlahan<T>
	{
		private T a;
		private T b;
		private T c;

		public void JumlahTigaAngka(T a, T b, T c)
        {
			dynamic v1 = a;
			dynamic v2 = b;
			dynamic v3 = c;
			dynamic d;
			d = v1 + v2 + v3;
			
			Console.WriteLine("Jumlah dari penjumlahan 3 angka adalah " + d);
        }
	}

}


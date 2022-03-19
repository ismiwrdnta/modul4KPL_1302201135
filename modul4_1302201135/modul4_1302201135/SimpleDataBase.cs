using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modul4KPL_1302201135
{
	public class SimpleDataBase<T>
	{
		List<T> storedData;
		List<DateTime> inputDates;
		public void SimpleDatabase ()
		{
			storedData = new List<T> ();
			inputDates = new List<DateTime>();
		}
		public void AddNewData(T data)
        {
			storedData.Add(data);
			inputDates.Add(DateTime.Now);
        }

		public void PrintAllData()
		{
			int i = 0;
			for (i = 0; i < storedData.Count; i++)
			{
				Console.WriteLine("Data " + (i+1) +" berisi : " + storedData[i] + ", yang disimpan pada waktu " + inputDates[i]);
			}
		}

	}
}


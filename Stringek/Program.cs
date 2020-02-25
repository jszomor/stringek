using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
	class Program
	{
		static void Main(string[] args)
		{
			string szovegresz;
			string osszszoveg = "";
			while(true)
			{
				Console.WriteLine("Kérem a következő szövegrészt:");

				szovegresz = Console.ReadLine();
				if(szovegresz == "")
				{
					break;
				}
				osszszoveg += szovegresz;
				osszszoveg += " ";
			}
			//Console.WriteLine(osszszoveg);
			char[] elvalaszto = new char[] { ' ' , '\t'};
			string[] words = osszszoveg.Split(elvalaszto, StringSplitOptions.RemoveEmptyEntries);
			int szamlalo = 0;
			bool megvan = false;
			//string[] q = words.Distinct().ToArray();
			string[] egyedi = new string[words.Length];
			for (int i = 0; i < words.Length; i++)
			{
				megvan = false;
				for (int j = 0; j < szamlalo; j++)
				{
					if (words[i] == egyedi[j])
					{
						megvan = true;
						break;
					}
				}
				if(megvan == false)
				{
					egyedi[szamlalo] = words[i];
					szamlalo++;
				}
			}
			for (int i = 0; i < szamlalo; i++)
			{
				Console.WriteLine(egyedi[i]);
			}
			int counter = 0;
			int flag = 0;
			char[] oszChar = osszszoveg.ToCharArray();
			for (int i = 0; i < oszChar.Length; i++)
			{
				if (oszChar[i] == 'L')
					flag++;
				else if (oszChar[i] == 'Y')
				{
					counter += flag;
					if(flag == 1)
					{
						oszChar[i] = '?';
						oszChar[i-1] = '?';
					}
					if(flag > 1)
					{
						oszChar[i] = '?';
						oszChar[i - 1] = '?';
						oszChar[i - 2] = '?';
					}
				}
				else
					flag = 0;
			}

			osszszoveg = new string(oszChar);
			
			//Console.WriteLine(osszszoveg);
			Console.ReadKey();
		}
	}
}

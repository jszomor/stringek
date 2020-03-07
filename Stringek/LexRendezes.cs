using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
	public class LexRendezes
	{
		public static void RendezesLex(string[] words)
		{
			//List<string> rendezettSzavak = new List<string>();
			Array.Sort(words);
			foreach(var word in words)
			{
				Console.WriteLine(word);
			}
			#region
			//string word;
			//for (int i = 0; i < words.Length; i++)
			//{
			//	for (int j = 0; j < words.Length; j++)
			//	{
			//		char[] wordCharI = words[i].ToCharArray();
			//		char[] wordCharJ = words[j].ToCharArray();

			//		if(wordCharI[i] > wordCharJ[j])
			//		{
			//			rendezettSzavak.Add(words[i].ToString());
			//		}
			//		else if(wordCharI[i] < wordCharJ[j])
			//			rendezettSzavak.Add(words[j].ToString());
			//	}
			//}
			#endregion
		}
	}
}

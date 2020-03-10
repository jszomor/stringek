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
			for (int i = 0; i < words.Length - 1; ++i)
			{
				for (int j = words.Length - 1; j > i; --j)
				{
					if (string.Compare(words[j-1], words[j], true) > 0)
					{
						string tmp = words[j];
						words[j] = words[j - 1];
						words[j - 1] = tmp;
					}
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
	public static class BuborekRendezes
	{
		public static char[] Bubble (char[] oszChar)
		{

			for (int i = 0; i < oszChar.Length - 1; ++i)
			{
				for (int j = oszChar.Length - 1; j > i; --j)
				{
					if (oszChar[j - 1] > oszChar[j])
					{
						char tmp = oszChar[j];
						oszChar[j] = oszChar[j - 1];
						oszChar[j - 1] = tmp;
					}
				}
			}
			return oszChar;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
	class KerdojelLYHelyett
	{
		public static char[] LYHelyettKerdojel(char[] oszChar)
		{
			int counter = 0;
			int flag = 0;
			for (int i = 0; i < oszChar.Length; i++)
			{
				if (oszChar[i] == 'L')
					flag++;
				else if (oszChar[i] == 'Y')
				{
					counter += flag;
					if (flag == 1)
					{
						oszChar[i] = '?';
						oszChar[i - 1] = '?';
					}
					if (flag > 1)
					{
						oszChar[i] = '?';
						oszChar[i - 1] = '?';
						oszChar[i - 2] = '?';
					}
				}
				else
					flag = 0;
			}
			return oszChar;
		}
	}
}

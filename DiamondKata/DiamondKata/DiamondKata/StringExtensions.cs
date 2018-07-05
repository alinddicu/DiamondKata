using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata
{
	public static class StringExtensions
	{
		public static string PadLeft(this string toPad , char paddingChar, int number)
		{
			var pads = "";
			for (int i = 0; i < number; i++)
			{
				pads += paddingChar;
			}
			return pads + toPad;
		}

		public static string PadRight(this string toPad, char paddingChar, int number)
		{
			var pads = "";
			for (int i = 0; i < number; i++)
			{
				pads += paddingChar;
			}

			return toPad + pads;
		}
	}
}

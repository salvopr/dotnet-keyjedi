﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace JediModel
{
	public static class KeyExtensions
	{
		private static readonly Dictionary<Keys, string> displayNames =
			new Dictionary<Keys, string>
				{
					{Keys.D0, "0"},
					{Keys.D1, "1"},
					{Keys.D2, "2"},
					{Keys.D3, "3"},
					{Keys.D4, "4"},
					{Keys.D5, "5"},
					{Keys.D6, "6"},
					{Keys.D7, "7"},
					{Keys.D8, "8"},
					{Keys.D9, "9"},
					{Keys.LWin, "Winkey"},
					{Keys.RWin, "Winkey"},
					{Keys.NumPad0, "Num0"},
					{Keys.NumPad1, "Num1"},
					{Keys.NumPad2, "Num2"},
					{Keys.NumPad3, "Num3"},
					{Keys.NumPad4, "Num4"},
					{Keys.NumPad5, "Num5"},
					{Keys.NumPad6, "Num6"},
					{Keys.NumPad7, "Num7"},
					{Keys.NumPad8, "Num8"},
					{Keys.NumPad9, "Num9"},
					{Keys.OemSemicolon, ";"},
					{Keys.Oemplus, "+"},
					{Keys.Oemcomma, ","},
					{Keys.OemMinus, "-"},
					{Keys.OemPeriod, "."},
					{Keys.OemQuestion, "?"},
					{Keys.Oemtilde, "'"},
					{Keys.OemOpenBrackets, "["},
					{Keys.OemPipe, "/"},
					{Keys.OemCloseBrackets, "]"},
					{Keys.OemQuotes, "'"},
					{Keys.OemBackslash, @"\"},
					{Keys.Control, "Ctrl"}
				};

		public static string DisplayName(this Keys keys)
		{
			if (displayNames.ContainsKey(keys))
			{
				return displayNames[keys];
			}
			return keys.ToString();
		}
	}
}
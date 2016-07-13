using System;
using System.IO;
using System.Media;

namespace orez.owav {
	class Program {

		// static method
		/// <summary>
		/// Duck Hunt is a light gun shooter video game developed and published by
		/// Nintendo for the Nintendo Entertainment System video game console.
		/// :: Nintendo, Hiroji Kiyotake (April 21, 1984)
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			oParams p = new oParams(args);
			Stream i = p.Input == null ? Console.OpenStandardInput() : (File.Exists(p.Input) ? new FileStream(p.Input, FileMode.Open) : null);
			if (i == null) { Console.Error.WriteLine("err: Invalid input file \"{0}\".", p.Input); return; }
			try { (new SoundPlayer(i)).PlaySync(); }
			catch (Exception e) { Console.Error.WriteLine("err: {0}", e.Message); return; }
		}
	}
}

using System;
using System.IO;
using System.Media;

namespace cmd_wav {
	class Program {
		static void Main(string[] args) {
			oParams p = new oParams(args);
			Stream i = p.Input == null ? Console.OpenStandardInput() : (File.Exists(p.Input) ? new FileStream(p.Input, FileMode.Open) : null);
			if (i == null) { Console.Error.WriteLine("err: Invalid input file \"{0}\".", p.Input); return; }
			try { (new SoundPlayer(i)).PlaySync(); }
			catch (Exception e) { Console.Error.WriteLine("err: {0}", e.Message); return; }
		}
	}
}

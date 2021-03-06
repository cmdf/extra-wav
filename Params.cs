﻿namespace App {
	class Params {

		// data
		/// <summary>
		/// Defines input .wav file path.
		/// </summary>
		public string Input;


		// constructor
		/// <summary>
		/// Get parameters from input arguments.
		/// </summary>
		/// <param name="args">Input arguments.</param>
		public Params(string[] args) {
			for (int i = 0, I = args.Length; i < I; i++) {
				string av = args[i];
				if (av == "-i" || av == "--input") { Input = ++i < I ? args[i] : ""; }
			}
		}
	}
}

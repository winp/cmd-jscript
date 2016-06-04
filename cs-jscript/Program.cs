﻿using System;
using System.IO;

namespace orez.jscript {
	class Program {
		static void Main(string[] args) {
			// prepare
			var jpth = evar("systemroot")+"\\microsoft.net\\framework\\";
			var jtmp = evar("temp") + "\\0rez\\cs-jscript";
			var jptn = "*jsc.exe";
			// search jscript.net compiler
			var JSC_PATH = Environment.GetEnvironmentVariable("JSC_PATH");
			if(JSC_PATH == null) {
				foreach(var a in Directory.GetFiles(jpth, jptn, SearchOption.AllDirectories)) {
					JSC_PATH = a;
				}
			}
		}

		// shortcut for get environment variable
		private static string evar(string name) {
			return Environment.GetEnvironmentVariable(name);
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Utils
{
	class NavigateArgs
	{
		public NavigateArgs()
		{

		}

		public NavigateArgs( string url )
		{
			Url = url;
		}

		public string Url { get; set; }
	}
}

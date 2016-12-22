using System;
using System.Collections.Generic;
using System.Linq;

namespace AvalonShell.UI
{
	partial class Window
	{
		public Window()
		{
			var host = new PowerShellHost();

			this.InitializeComponent();
			this.Console.PowerShellHost = host;

			host.Open();
		}
	}
}

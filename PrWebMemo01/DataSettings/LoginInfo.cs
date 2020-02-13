using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrWebMemo01.DataSettings
{
	public class LoginInfomation
	{
		public string serverName { get; set; }
		public string userName { get; set; }
		public string password { get; set; }

		public void save()
		{
			Properties.Settings.Default.lastServerName = serverName;
			Properties.Settings.Default.lastUserName= userName;

			Properties.Settings.Default.Save();
		}

		public void load()
		{
			serverName = Properties.Settings.Default.lastServerName;
			userName = Properties.Settings.Default.lastUserName;
			password = "";
		}
	}
}

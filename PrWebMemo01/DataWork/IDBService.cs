using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrWebMemo01.DataSettings;
using PrWebMemo01.DataWork;

namespace PrWebMemo01
{
	interface IDBService
	{
		bool insert(LoginInfomation loginInfo, string key, PubMemo item);

        bool update(LoginInfomation loginInfo, string key, PubMemo item);

        bool delete(LoginInfomation loginInfo, PubMemo item);

        List<PubMemo> getAll(LoginInfomation loginInfo, string key);

        List<PubMemo> search(LoginInfomation LoginInfo, string password, Dictionary<DBIndex.PubMemo, string> keyword);

	}
}

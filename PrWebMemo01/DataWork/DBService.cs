using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrWebMemo01.DataSettings;
using PrWebMemo01.DataWork;

namespace PrWebMemo01
{
	class DBService : IDBService
	{
		private string getConnectionString(LoginInfomation loginInfo)
		{
			return string.Format(Properties.Settings.Default.WebMemoConnectionString,
				loginInfo.serverName, loginInfo.userName, loginInfo.password);
		}

		public bool insert(LoginInfomation loginInfo, string key, PubMemo item)
		{
			try
			{
                using (var conn = new WebMemoDBDataContext(getConnectionString(loginInfo)))
				{
					conn.PubMemo.InsertOnSubmit(item);
					conn.SubmitChanges();
					return true;
				}
			}
			catch (SqlException ex)
			{
				ex.ToString();
				return false;
			}
		}

		public bool update(LoginInfomation loginInfo, string key, PubMemo item)
		{
			try
			{
                using (var conn = new WebMemoDBDataContext(getConnectionString(loginInfo)))
				{
					PubMemo src = (from s in conn.PubMemo
							   where s.id == item.id
							   select s).FirstOrDefault();

                    src.title = item.title;
                    src.category1 = item.category1;
                    src.category2 = item.category2;
                    src.category3 = item.category3;
                    src.memo = item.memo;

					conn.SubmitChanges();
					return true;
				}
			}
			catch (SqlException ex)
			{
				ex.ToString();
				return false;
			}
		}

		public bool delete(LoginInfomation loginInfo, PubMemo item)
		{
			try
			{
                using (var conn = new WebMemoDBDataContext(getConnectionString(loginInfo)))
				{
					PubMemo src = (from s in conn.PubMemo
							   where s.id == item.id
							   select s).FirstOrDefault();
					conn.PubMemo.DeleteOnSubmit(src);
					conn.SubmitChanges();
					return true;
				}

			}
			catch (SqlException ex)
			{
				ex.ToString();
				return false;
			}
		}

		public List<PubMemo> getAll(LoginInfomation loginInfo, string key)
		{
			try
			{
                using (var conn = new WebMemoDBDataContext(getConnectionString(loginInfo)))
				{
					List<PubMemo> result = (from s in conn.PubMemo
										select s).ToList();

					return result;
				}
			}
			catch (SqlException ex)
			{
				ex.ToString();
				return null;
			}
		}

        // DB 의 여러 필드에 대해 각각의 Keyword 로 OR 검색하는거
		public List<PubMemo> search(LoginInfomation loginInfo, string key, Dictionary<DBIndex.PubMemo, string> keyword)
		{
            try
            {
                using(var conn = new WebMemoDBDataContext(getConnectionString(loginInfo)))
                {
                    // where 절 or 문으로 여러개 붙이는거
                    var pred = PredicateBuilder.False<PubMemo>();
                    if(keyword.ContainsKey(DBIndex.PubMemo.title)) {
                        pred = pred.Or(p => p.title.Contains(keyword[DBIndex.PubMemo.title]));
                    }
                    if(keyword.ContainsKey(DBIndex.PubMemo.category1)) {
                        pred = pred.Or(p => p.category1.Contains(keyword[DBIndex.PubMemo.category1]));
                    }
                    if(keyword.ContainsKey(DBIndex.PubMemo.category2)) {
                        pred = pred.Or(p => p.category2.Contains(keyword[DBIndex.PubMemo.category2]));
                    }
                    if(keyword.ContainsKey(DBIndex.PubMemo.category3)) {
                        pred = pred.Or(p => p.category3.Contains(keyword[DBIndex.PubMemo.category3]));
                    }
                    if(keyword.ContainsKey(DBIndex.PubMemo.memo)) {
                        pred = pred.Or(p => p.memo.Contains(keyword[DBIndex.PubMemo.memo]));
                    }
                    // 작성한 where 문을 이용해 sql 문을 작성
                    // IQueryable 형식이 sql 문이라고 봐도 무방할듯..
                    // 물론 sql 뿐만 아니고, 거기에 데이타베이스 연결작업에 필요한 모든 정보를 가지고 있는거 같음..
                    IQueryable<PubMemo> bb = from p in conn.PubMemo.Where(pred) select p;
                    // 그리고 IQueryable 에서 ToList() 를 할때, 실제 DB 에 접근해 sql 문을 보내고 결과를 받아온다.
                    List<PubMemo> result = bb.ToList();

                    return result;
                }
            }
            catch (SqlException ex)
            {
                ex.ToString();
                return null;
            }
        }
	}
}

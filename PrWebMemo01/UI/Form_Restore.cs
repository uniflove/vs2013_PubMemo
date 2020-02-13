using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrWebMemo01
{
	/// <summary>
	/// 폼의 현재 위치랑 크기를 저장해서 폼이 다시 뜰때 위치랑 크기를 복원함
	/// 현재 최소,최대화 는 처리히자 않음.
	/// 
	/// Project 속성에 설정 변수에 string 타입의 FormPosSize 를 추가할것.
	/// 
	/// 이걸 쓸 Form 은 formName 상수 문자열을 지정하고,
	/// 생성자에서 Form_Load, Form_Closed 에 람다 형식으로 아래처럼 추가.
	/// 
	/// private const string FORM_NAME = "FormLogin";
	/// 
	/// public FormLogin()
	/// {
	///		...
	///		this.Load += (s, e) => Form_Restore.LoadPosSize(this, FORM_NAME);
	///		this.FormClosed += (s, e) => Form_Restore.SavePosSize(this, FORM_NAME);
	/// }
	/// </summary>
	public static class Form_Restore
	{
		public static void SavePosSize(Form form, string formName)
		{
			string[] items = Properties.Settings.Default.FormPosSize.Split(':');
			string newValue = string.Format("{0},{1},{2},{3},{4}", formName, form.Left, form.Top, form.Width, form.Height);
			string newItems = "";

			bool hasLastValues = false;
			foreach (string value in items)
			{
				if (value.Length > 0)
				{
					if (value.Contains(formName))
					{
						hasLastValues = true;
						newItems += newValue+ ":";
					}
					else
					{
						newItems += value + ":";
					}
				}
			}
			if (!hasLastValues)
			{
				newItems += newValue + ":";
			}

			Properties.Settings.Default.FormPosSize = newItems;
			Properties.Settings.Default.Save();
		}

		public static void LoadPosSize(Form form, string formName)
		{
			string[] items = Properties.Settings.Default.FormPosSize.Split(':');
			foreach (string item in items)
			{
				if (item.Contains(formName))
				{
					string[] lastPosSize = item.Split(',');
					form.Left = Convert.ToInt32(lastPosSize[1]);
					form.Top = Convert.ToInt32(lastPosSize[2]);
					form.Width = Convert.ToInt32(lastPosSize[3]);
					form.Height = Convert.ToInt32(lastPosSize[4]);
					break;
				}
			}
		}
	}
}

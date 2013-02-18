using C1.Win.C1FlexGrid;

namespace Kenwin.PPP.Cliente.Comun.Controles
{
	public class PPPC1FlexGrid: C1FlexGrid
	{
		public PPPC1FlexGrid()
		{
			this.Rows.Count = 1;
			this.Cols.Count = 1;
			this.Cols[0].Width = 30;
		}

		public void SetCellError(int row, int col, string errorMessage)
		{
			SetUserData(row, col, new ErrorMessage(errorMessage));
			this.Refresh();
		}

		public void SetCellError(int row, string colName, string errorMessage)
		{
			SetUserData(row, colName, new ErrorMessage(errorMessage));
			this.Refresh();
		}

		public void ClearCellError(int row, int col)
		{
			SetUserData(row, col, null);
			this.Refresh();
		}

		public void ClearCellError(int row, string colName)
		{
			SetUserData(row, colName, null);
			this.Refresh();
		}

		protected override void OnGetCellErrorInfo(GetErrorInfoEventArgs e)
		{
			var errorMessage = GetUserData(e.Row, e.Col) as ErrorMessage;
			if (errorMessage != null)
			{
				e.ErrorText = errorMessage.Message;
				return;
			}
			base.OnGetCellErrorInfo(e);
		}

		private sealed class ErrorMessage
		{
			public ErrorMessage(string message)
			{
				Message = message;
			}

			public string Message { get; private set; }

			public override string ToString()
			{
				return Message;
			}
		}
	}
}

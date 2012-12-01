using System;
using System.Windows.Forms;
using Vemn.Fwk.Windows.Tools;

namespace Kenwin.PPP.Cliente.Comun.Formularios
{
	/// <summary>
	/// Ventana para ingresar una descripcion
	/// Usado para el alta de nuevos items en algunos FKBoxes
	/// </summary>
	public partial class NuevoItemForm : PPPFormBase
	{
		public string Descripcion
		{
			get
			{
				return descripcionTextBox.Text;
			}
		}

		public NuevoItemForm(string tituloVentana, string textoExplicativo, int longitudMaxima)
		{
			InitializeComponent();

			if (string.IsNullOrWhiteSpace(tituloVentana))
			{
				throw new ArgumentNullException("tituloVentana");
			}

			if (string.IsNullOrWhiteSpace(textoExplicativo))
			{
				throw new ArgumentNullException("textoExplicativo");
			}

			if (longitudMaxima < 1 || longitudMaxima > 32768)
			{
				throw new ArgumentOutOfRangeException("longitudMaxima", "entre 1 y 32768");
			}

			this.Text = tituloVentana;
			this.descripcionLabel.Text = textoExplicativo;
			descripcionTextBox.MaxLength = longitudMaxima;
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			//Validar que el usuario escriba algo
			if (string.IsNullOrWhiteSpace(descripcionTextBox.Text))
			{
				MessageHelper.MostrarMensajeAlerta("El campo no puede ser vacío.");
				return;
			}

			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}

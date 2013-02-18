using Vemn.Fwk.Windows.Controls;

namespace Vemn.Fwk.ClientServer.Windows.Controls.Buttons
{
    public partial class PrintButton : VemnButton
    {
		public PrintButton()
        {
            this.ButtonType = VemnButton.ButtonTypeEnum.Custom;
            //this.Image = global::Mastellone.ABA.Cliente.Comun.Properties.Resources.Print_16;
            this.Text = "&Imprimir";
        }
    }
}

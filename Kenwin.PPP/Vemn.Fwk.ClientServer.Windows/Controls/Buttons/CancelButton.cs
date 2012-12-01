using Vemn.Fwk.Windows.Controls;

namespace Vemn.Fwk.ClientServer.Windows.Controls.Buttons
{
    public class CancelButton : VemnButton
    {
        public CancelButton()
        {
            this.ButtonType = ButtonTypeEnum.Cancel;
            this.Text = "&Cancelar";
        }
    }
}

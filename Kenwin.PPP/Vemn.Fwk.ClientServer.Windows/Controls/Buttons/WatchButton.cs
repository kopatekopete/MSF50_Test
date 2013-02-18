using Vemn.Fwk.Windows.Controls;

namespace Vemn.Fwk.ClientServer.Windows.Controls.Buttons
{
    public class WatchButton : VemnButton
    {
        public WatchButton()
        {
            this.ButtonType = ButtonTypeEnum.Custom;
            //this.Image = global::Mastellone.ABA.Cliente.Comun.Properties.Resources.lupa;
            this.Text = "&Ver";
        }
    }
}

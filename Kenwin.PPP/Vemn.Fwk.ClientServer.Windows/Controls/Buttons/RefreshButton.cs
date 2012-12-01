using Vemn.Fwk.Windows.Controls;

namespace Vemn.Fwk.ClientServer.Windows.Controls.Buttons
{
    public partial class RefreshButton : VemnButton
    {
        public RefreshButton()
        {
            this.ButtonType = ButtonTypeEnum.Custom;
            //this.Image = global::Mastellone.ABA.Cliente.Comun.Properties.Resources.refreshGreen_16;
            this.Text = "&Refrescar";
        }
    }
}

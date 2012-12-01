using System.ComponentModel;
using Vemn.Fwk.Windows.Controls;

namespace Vemn.Fwk.ClientServer.Windows.Controls.Buttons
{
    public partial class ClearButton : VemnButton
    {
        public ClearButton()
        {
            this.ButtonType = ButtonTypeEnum.Custom;
            this.Text = "&Limpiar";

            var resources = new ComponentResourceManager(typeof(ClearButton));
            this.Image = ((System.Drawing.Image)(resources.GetObject("Clear")));
        }
    }
}

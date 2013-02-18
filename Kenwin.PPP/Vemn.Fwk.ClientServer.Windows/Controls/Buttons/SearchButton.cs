using System.ComponentModel;
using Vemn.Fwk.Windows.Controls;

namespace Vemn.Fwk.ClientServer.Windows.Controls.Buttons
{
    public partial class SearchButton : VemnButton
    {
        public SearchButton()
        {
            this.ButtonType = ButtonTypeEnum.Custom;
            this.Text = "&Buscar";

            var resources = new ComponentResourceManager(typeof(SearchButton));
            this.Image = ((System.Drawing.Image)(resources.GetObject("Search")));
        }
    }
}

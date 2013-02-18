using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Kenwin.PPP.Cliente.Comun.Controles
{
	/// <summary>
	/// GroupBox control that provides functionality to 
	/// allow it to be collapsed.
	/// </summary>
	[ToolboxBitmap(typeof(CollapsableGroupBox))]
	public partial class CollapsableGroupBox : GroupBox
	{
		#region Fields

		private Rectangle _mToggleRect = new Rectangle(8, 2, 11, 11);
		private Boolean _isCollapsed = false;
		private Boolean _mBResizingFromCollapse = false;

		private Size _fullSize = Size.Empty;

		#endregion

	    private Image _minusImage;
        private Image _plusImage;

		#region Events & Delegates

        /// <summary>Fired when the Collapse Toggle button is pressed</summary>
		public event EventHandler CollapseBoxClickedEvent;

		#endregion

		#region Constructor

		public CollapsableGroupBox()
		{
			InitializeComponent();
		}

		#endregion

		#region Public Properties

		public new Size Size
		{
			get { return base.Size; }
			set
			{
				_fullSize = value;
				base.Size = value;
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int FullHeight
		{
			get { return _fullSize.Height; }
		}

		[DefaultValue(false), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool IsCollapsed
		{
			get { return _isCollapsed; }
			set
			{
				if (value != _isCollapsed)
				{
					_isCollapsed = value;

					if (!value)
						// Expand
						this.Size = _fullSize;
					else
					{
						// Collapse
						_mBResizingFromCollapse = true;
						this.Height = CollapsedHeight;
						_mBResizingFromCollapse = false;
					}

					foreach (Control c in Controls)
						c.Visible = !value;

					Invalidate();
				}
			}
		}

		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int CollapsedHeight
		{
			get { return 20; }
		}

	    public Image MinusImage
	    {
	        get
	        {
                if (_minusImage == null)
                {
                    var resources = new ComponentResourceManager(typeof(CollapsableGroupBox));
                    _minusImage = (Image) resources.GetObject("minus");
                }
                return _minusImage;
	        }
	    }

	    public Image PlusImage
	    {
            get
            {
                if (_plusImage == null)
                {
                    var resources = new ComponentResourceManager(typeof(CollapsableGroupBox));
                    _plusImage = (Image)resources.GetObject("plus");
                }
                return _plusImage;
            }
	    }

	    #endregion

		#region Overrides

		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (_mToggleRect.Contains(e.Location))
			{
				ToggleCollapsed();
			}
			else
			{
				base.OnMouseUp(e);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			HandleResize();
			DrawGroupBox(e.Graphics);
			DrawToggleButton(e.Graphics);
		}

		#endregion

		#region Implimentation

		void DrawGroupBox(Graphics g)
		{
			// Get windows to draw the GroupBox
			Rectangle bounds = new Rectangle(ClientRectangle.X, ClientRectangle.Y + 6, ClientRectangle.Width, ClientRectangle.Height - 6);
			GroupBoxRenderer.DrawGroupBox(g, bounds, Enabled ? GroupBoxState.Normal : GroupBoxState.Disabled);

			// Text Formating positioning & Size
			StringFormat sf = new StringFormat();
			int i_textPos = (bounds.X + 8) + _mToggleRect.Width + 2;
			int i_textSize = (int)g.MeasureString(Text, this.Font).Width;
			i_textSize = i_textSize < 1 ? 1 : i_textSize;
			int i_endPos = i_textPos + i_textSize + 1;

			// Draw a line to cover the GroupBox border where the text will sit
			g.DrawLine(SystemPens.Control, i_textPos, bounds.Y, i_endPos, bounds.Y);

			// Draw the GroupBox text
			using (SolidBrush drawBrush = new SolidBrush(Color.Black))
			{
				g.DrawString(Text, this.Font, drawBrush, i_textPos, 0);
			}
		}

		void DrawToggleButton(Graphics g)
		{
			if(IsCollapsed)
			{
				g.DrawImage(PlusImage, _mToggleRect);
			}
			else
			{
				g.DrawImage(MinusImage, _mToggleRect);
			}
		}

		void ToggleCollapsed()
		{
			IsCollapsed = !IsCollapsed;

			if (CollapseBoxClickedEvent != null)
			{
				CollapseBoxClickedEvent(this, EventArgs.Empty);
			}
		}

		void HandleResize()
		{
			if (!_mBResizingFromCollapse && !_isCollapsed)
			{
				_fullSize = this.Size;
			}
		}

		#endregion


       
	}
}
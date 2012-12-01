namespace Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.Base
{
	public partial class DescripcionFKBox<T>
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.descripcionLabel = new System.Windows.Forms.Label();
			this.abrirSelectorButton = new System.Windows.Forms.Button();
			this.descripcionToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.bs = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.descripcionLabel, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.abrirSelectorButton, 1, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(150, 24);
			this.tableLayoutPanel.TabIndex = 6;
			// 
			// descripcionLabel
			// 
			this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.descripcionLabel.AutoEllipsis = true;
			this.descripcionLabel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.descripcionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.descripcionLabel.Location = new System.Drawing.Point(1, 1);
			this.descripcionLabel.Margin = new System.Windows.Forms.Padding(1);
			this.descripcionLabel.Name = "descripcionLabel";
			this.descripcionLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.descripcionLabel.Size = new System.Drawing.Size(128, 21);
			this.descripcionLabel.TabIndex = 5;
			// 
			// abrirSelectorButton
			// 
			this.abrirSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.abrirSelectorButton.Image = global::Kenwin.PPP.Cliente.Properties.Resources.Zoom2_16;
			this.abrirSelectorButton.Location = new System.Drawing.Point(131, 1);
			this.abrirSelectorButton.Margin = new System.Windows.Forms.Padding(1);
			this.abrirSelectorButton.Name = "abrirSelectorButton";
			this.abrirSelectorButton.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.abrirSelectorButton.Size = new System.Drawing.Size(18, 21);
			this.abrirSelectorButton.TabIndex = 6;
			this.abrirSelectorButton.UseVisualStyleBackColor = true;
			this.abrirSelectorButton.Click += new System.EventHandler(this.BotonAbrirSelector_Click);
			// 
			// descripcionToolTip
			// 
			this.descripcionToolTip.AutomaticDelay = 300;
			// 
			// DescripcionFKBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel);
			this.MaximumSize = new System.Drawing.Size(500, 24);
			this.MinimumSize = new System.Drawing.Size(50, 24);
			this.Name = "DescripcionFKBox";
			this.Size = new System.Drawing.Size(150, 24);
			this.tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		protected System.Windows.Forms.ToolTip descripcionToolTip;
		protected System.Windows.Forms.Label descripcionLabel;
		protected System.Windows.Forms.BindingSource bs;
		protected System.Windows.Forms.Button abrirSelectorButton;

	}
}

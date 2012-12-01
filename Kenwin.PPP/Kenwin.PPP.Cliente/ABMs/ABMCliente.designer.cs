namespace Kenwin.PPP.Cliente.ABMs
{
    partial class ABMCliente
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
		
		#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.razonSocialLbl = new System.Windows.Forms.Label();
			this.RazonSocial = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this._bs)).BeginInit();
			this.groupDetail.SuspendLayout();
			this.CrudTab.SuspendLayout();
			this.TableTab.SuspendLayout();
			this.DetailTab.SuspendLayout();
			this.panelContainerDetail.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgVemn)).BeginInit();
			this.panelContainerButton.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelContainerDetail
			// 
			this.panelContainerDetail.Controls.Add(this.tableLayoutPanel);
			// 
			// title
			// 
			this.title.SubTitle = "Altas Bajas y Modificaciones de Cliente";
			this.title.Title = "Cliente";
			// 
			// dgVemn
			// 
			this.dgVemn.AutoGenerateColumns = false;
			this.dgVemn.Rows.Count = 1;
			this.dgVemn.Rows.DefaultSize = 17;
			// 
			// razonSocialLbl
			// 
			this.razonSocialLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.razonSocialLbl.AutoSize = true;
			this.razonSocialLbl.CausesValidation = false;
			this.razonSocialLbl.Location = new System.Drawing.Point(3, 9);
			this.razonSocialLbl.Name = "razonSocialLbl";
			this.razonSocialLbl.Size = new System.Drawing.Size(70, 13);
			this.razonSocialLbl.TabIndex = 1;
			this.razonSocialLbl.Text = "Razón Social";
			this.razonSocialLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// RazonSocial
			// 
			this.RazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.RazonSocial.Location = new System.Drawing.Point(79, 5);
			this.RazonSocial.MaxLength = 50;
			this.RazonSocial.Name = "RazonSocial";
			this.RazonSocial.Size = new System.Drawing.Size(457, 20);
			this.RazonSocial.TabIndex = 1;
			this.RazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.RazonSocial_Validating);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.razonSocialLbl, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.RazonSocial, 1, 0);
			this.tableLayoutPanel.Location = new System.Drawing.Point(32, 13);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(564, 31);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// ABMCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 358);
			this.ControlBox = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.GetDataPageAfterInsert = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "ABMCliente";
			this.Text = "Cliente";
			this.Load += new System.EventHandler(this.ABMCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this._bs)).EndInit();
			this.groupDetail.ResumeLayout(false);
			this.CrudTab.ResumeLayout(false);
			this.TableTab.ResumeLayout(false);
			this.TableTab.PerformLayout();
			this.DetailTab.ResumeLayout(false);
			this.panelContainerDetail.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgVemn)).EndInit();
			this.panelContainerButton.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion Windows Form Designer generated code		

		private System.Windows.Forms.Label razonSocialLbl;
		private System.Windows.Forms.TextBox RazonSocial;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
	}
}


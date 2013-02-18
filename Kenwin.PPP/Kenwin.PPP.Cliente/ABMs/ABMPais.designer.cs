namespace Kenwin.PPP.Cliente.ABMs
{
    partial class ABMPais
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
			this.descripcionLbl = new System.Windows.Forms.Label();
			this.DescripcionTB = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.siglaTB = new System.Windows.Forms.TextBox();
			this.idiomaLbl = new System.Windows.Forms.Label();
			this.siglaLbl = new System.Windows.Forms.Label();
			this.fKBoxIdioma = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.IdiomaFKBox();
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
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelContainerDetail
			// 
			this.panelContainerDetail.Controls.Add(this.tableLayoutPanel1);
			// 
			// title
			// 
			this.title.SubTitle = "Altas Bajas y Modificaciones de Paises";
			this.title.Title = "País";
			// 
			// dgVemn
			// 
			this.dgVemn.AutoGenerateColumns = false;
			this.dgVemn.Rows.Count = 1;
			this.dgVemn.Rows.DefaultSize = 17;
			// 
			// descripcionLbl
			// 
			this.descripcionLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.descripcionLbl.AutoSize = true;
			this.descripcionLbl.CausesValidation = false;
			this.descripcionLbl.Location = new System.Drawing.Point(3, 6);
			this.descripcionLbl.Name = "descripcionLbl";
			this.descripcionLbl.Size = new System.Drawing.Size(63, 13);
			this.descripcionLbl.TabIndex = 1;
			this.descripcionLbl.Text = "Descripción";
			this.descripcionLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// DescripcionTB
			// 
			this.DescripcionTB.Location = new System.Drawing.Point(72, 3);
			this.DescripcionTB.MaxLength = 50;
			this.DescripcionTB.Name = "DescripcionTB";
			this.DescripcionTB.Size = new System.Drawing.Size(457, 20);
			this.DescripcionTB.TabIndex = 0;
			this.DescripcionTB.Validating += new System.ComponentModel.CancelEventHandler(this.Descripcion_Validating);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.siglaTB, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.idiomaLbl, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.siglaLbl, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.DescripcionTB, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.descripcionLbl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.fKBoxIdioma, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 13);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 86);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// siglaTB
			// 
			this.siglaTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.siglaTB.Location = new System.Drawing.Point(72, 59);
			this.siglaTB.MaxLength = 3;
			this.siglaTB.Name = "siglaTB";
			this.siglaTB.Size = new System.Drawing.Size(40, 20);
			this.siglaTB.TabIndex = 2;
			this.siglaTB.Validating += new System.ComponentModel.CancelEventHandler(this.SiglaTB_Validating);
			// 
			// idiomaLbl
			// 
			this.idiomaLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.idiomaLbl.AutoSize = true;
			this.idiomaLbl.CausesValidation = false;
			this.idiomaLbl.Location = new System.Drawing.Point(28, 34);
			this.idiomaLbl.Name = "idiomaLbl";
			this.idiomaLbl.Size = new System.Drawing.Size(38, 13);
			this.idiomaLbl.TabIndex = 3;
			this.idiomaLbl.Text = "Idioma";
			this.idiomaLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// siglaLbl
			// 
			this.siglaLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.siglaLbl.AutoSize = true;
			this.siglaLbl.CausesValidation = false;
			this.siglaLbl.Location = new System.Drawing.Point(36, 62);
			this.siglaLbl.Name = "siglaLbl";
			this.siglaLbl.Size = new System.Drawing.Size(30, 13);
			this.siglaLbl.TabIndex = 4;
			this.siglaLbl.Text = "Sigla";
			this.siglaLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// fKBoxIdioma
			// 
			this.fKBoxIdioma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fKBoxIdioma.Location = new System.Drawing.Point(72, 29);
			this.fKBoxIdioma.MaximumSize = new System.Drawing.Size(500, 24);
			this.fKBoxIdioma.MinimumSize = new System.Drawing.Size(50, 24);
			this.fKBoxIdioma.Name = "fKBoxIdioma";
			this.fKBoxIdioma.Size = new System.Drawing.Size(150, 24);
			this.fKBoxIdioma.TabIndex = 1;
			this.fKBoxIdioma.Validating += new System.ComponentModel.CancelEventHandler(this.FKBoxIdioma_Validating);
			// 
			// ABMPais
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 358);
			this.ControlBox = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.GetDataPageAfterInsert = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "ABMPais";
			this.Text = "País";
			this.Load += new System.EventHandler(this.ABMPais_Load);
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion Windows Form Designer generated code		

		private System.Windows.Forms.Label descripcionLbl;
		private System.Windows.Forms.TextBox DescripcionTB;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label idiomaLbl;
		private Comun.Controles.FKBoxes.IdiomaFKBox fKBoxIdioma;
		private System.Windows.Forms.TextBox siglaTB;
		private System.Windows.Forms.Label siglaLbl;
	}
}


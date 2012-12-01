namespace Kenwin.PPP.Cliente.ABMs
{
	partial class ABMPersona
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
			this.nombreLbl = new System.Windows.Forms.Label();
			this.nombreTB = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.emailTB = new System.Windows.Forms.TextBox();
			this.emailLbl = new System.Windows.Forms.Label();
			this.paisLbl = new System.Windows.Forms.Label();
			this.activoLbl = new System.Windows.Forms.Label();
			this.aliasTB = new System.Windows.Forms.TextBox();
			this.apellidoTB = new System.Windows.Forms.TextBox();
			this.apellidoLbl = new System.Windows.Forms.Label();
			this.aliasLbl = new System.Windows.Forms.Label();
			this.activoCB = new System.Windows.Forms.CheckBox();
			this.fKBoxPais = new Kenwin.PPP.Cliente.Comun.Controles.FKBoxes.PaisFKBox();
			this.idiomasCLB = new System.Windows.Forms.CheckedListBox();
			this.idiomaLbl = new System.Windows.Forms.Label();
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
			// _bs
			// 
			this._bs.PositionChanged += new System.EventHandler(this.Bs_PositionChanged);
			// 
			// groupDetail
			// 
			this.groupDetail.Size = new System.Drawing.Size(794, 547);
			// 
			// CrudTab
			// 
			this.CrudTab.Size = new System.Drawing.Size(808, 579);
			this.CrudTab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.CrudTab_Selecting);
			// 
			// TableTab
			// 
			this.TableTab.Size = new System.Drawing.Size(800, 553);
			// 
			// DetailTab
			// 
			this.DetailTab.Size = new System.Drawing.Size(800, 553);
			// 
			// panelContainerDetail
			// 
			this.panelContainerDetail.Controls.Add(this.tableLayoutPanel);
			this.panelContainerDetail.Size = new System.Drawing.Size(788, 488);
			// 
			// title
			// 
			this.title.SubTitle = "Altas Bajas y Modificaciones de Personas";
			this.title.Title = "Persona";
			// 
			// dgVemn
			// 
			this.dgVemn.AutoGenerateColumns = false;
			this.dgVemn.Rows.Count = 1;
			this.dgVemn.Rows.DefaultSize = 17;
			this.dgVemn.Size = new System.Drawing.Size(794, 522);
			// 
			// panelContainerButton
			// 
			this.panelContainerButton.Location = new System.Drawing.Point(3, 504);
			// 
			// nombreLbl
			// 
			this.nombreLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.nombreLbl.AutoSize = true;
			this.nombreLbl.CausesValidation = false;
			this.nombreLbl.Location = new System.Drawing.Point(3, 6);
			this.nombreLbl.Name = "nombreLbl";
			this.nombreLbl.Size = new System.Drawing.Size(44, 13);
			this.nombreLbl.TabIndex = 1;
			this.nombreLbl.Text = "Nombre";
			this.nombreLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// nombreTB
			// 
			this.nombreTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.nombreTB.Location = new System.Drawing.Point(53, 3);
			this.nombreTB.MaxLength = 50;
			this.nombreTB.Name = "nombreTB";
			this.nombreTB.Size = new System.Drawing.Size(457, 20);
			this.nombreTB.TabIndex = 0;
			this.nombreTB.Validating += new System.ComponentModel.CancelEventHandler(this.NombreTB_Validating);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.emailTB, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.emailLbl, 0, 5);
			this.tableLayoutPanel.Controls.Add(this.paisLbl, 0, 4);
			this.tableLayoutPanel.Controls.Add(this.activoLbl, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.aliasTB, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.apellidoTB, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.nombreLbl, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.nombreTB, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.apellidoLbl, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.aliasLbl, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.activoCB, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.fKBoxPais, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.idiomasCLB, 1, 6);
			this.tableLayoutPanel.Controls.Add(this.idiomaLbl, 0, 6);
			this.tableLayoutPanel.Location = new System.Drawing.Point(32, 13);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 8;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(739, 459);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// emailTB
			// 
			this.emailTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.emailTB.Location = new System.Drawing.Point(53, 131);
			this.emailTB.MaxLength = 60;
			this.emailTB.Name = "emailTB";
			this.emailTB.Size = new System.Drawing.Size(667, 20);
			this.emailTB.TabIndex = 5;
			this.emailTB.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTB_Validating);
			// 
			// emailLbl
			// 
			this.emailLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.emailLbl.AutoSize = true;
			this.emailLbl.Location = new System.Drawing.Point(15, 134);
			this.emailLbl.Name = "emailLbl";
			this.emailLbl.Size = new System.Drawing.Size(32, 13);
			this.emailLbl.TabIndex = 5;
			this.emailLbl.Text = "Email";
			// 
			// paisLbl
			// 
			this.paisLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.paisLbl.AutoSize = true;
			this.paisLbl.Location = new System.Drawing.Point(18, 106);
			this.paisLbl.Name = "paisLbl";
			this.paisLbl.Size = new System.Drawing.Size(29, 13);
			this.paisLbl.TabIndex = 5;
			this.paisLbl.Text = "País";
			// 
			// activoLbl
			// 
			this.activoLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.activoLbl.AutoSize = true;
			this.activoLbl.Location = new System.Drawing.Point(10, 81);
			this.activoLbl.Name = "activoLbl";
			this.activoLbl.Size = new System.Drawing.Size(37, 13);
			this.activoLbl.TabIndex = 4;
			this.activoLbl.Text = "Activo";
			// 
			// aliasTB
			// 
			this.aliasTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.aliasTB.Location = new System.Drawing.Point(53, 55);
			this.aliasTB.MaxLength = 6;
			this.aliasTB.Name = "aliasTB";
			this.aliasTB.Size = new System.Drawing.Size(73, 20);
			this.aliasTB.TabIndex = 2;
			this.aliasTB.Validating += new System.ComponentModel.CancelEventHandler(this.AliasTB_Validating);
			// 
			// apellidoTB
			// 
			this.apellidoTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.apellidoTB.Location = new System.Drawing.Point(53, 29);
			this.apellidoTB.MaxLength = 50;
			this.apellidoTB.Name = "apellidoTB";
			this.apellidoTB.Size = new System.Drawing.Size(457, 20);
			this.apellidoTB.TabIndex = 1;
			this.apellidoTB.Validating += new System.ComponentModel.CancelEventHandler(this.ApellidoTB_Validating);
			// 
			// apellidoLbl
			// 
			this.apellidoLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.apellidoLbl.AutoSize = true;
			this.apellidoLbl.Location = new System.Drawing.Point(3, 32);
			this.apellidoLbl.Name = "apellidoLbl";
			this.apellidoLbl.Size = new System.Drawing.Size(44, 13);
			this.apellidoLbl.TabIndex = 2;
			this.apellidoLbl.Text = "Apellido";
			// 
			// aliasLbl
			// 
			this.aliasLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.aliasLbl.AutoSize = true;
			this.aliasLbl.Location = new System.Drawing.Point(18, 58);
			this.aliasLbl.Name = "aliasLbl";
			this.aliasLbl.Size = new System.Drawing.Size(29, 13);
			this.aliasLbl.TabIndex = 3;
			this.aliasLbl.Text = "Alias";
			// 
			// activoCB
			// 
			this.activoCB.AutoSize = true;
			this.activoCB.Location = new System.Drawing.Point(53, 81);
			this.activoCB.Name = "activoCB";
			this.activoCB.Size = new System.Drawing.Size(15, 14);
			this.activoCB.TabIndex = 3;
			this.activoCB.UseVisualStyleBackColor = true;
			// 
			// fKBoxPais
			// 
			this.fKBoxPais.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fKBoxPais.Location = new System.Drawing.Point(53, 101);
			this.fKBoxPais.MaximumSize = new System.Drawing.Size(500, 24);
			this.fKBoxPais.MinimumSize = new System.Drawing.Size(50, 24);
			this.fKBoxPais.Name = "fKBoxPais";
			this.fKBoxPais.Size = new System.Drawing.Size(150, 24);
			this.fKBoxPais.TabIndex = 4;
			this.fKBoxPais.Validating += new System.ComponentModel.CancelEventHandler(this.FKBoxpais_Validating);
			// 
			// idiomasCLB
			// 
			this.idiomasCLB.FormattingEnabled = true;
			this.idiomasCLB.Location = new System.Drawing.Point(53, 157);
			this.idiomasCLB.Name = "idiomasCLB";
			this.idiomasCLB.Size = new System.Drawing.Size(257, 259);
			this.idiomasCLB.TabIndex = 6;
			// 
			// idiomaLbl
			// 
			this.idiomaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.idiomaLbl.AutoSize = true;
			this.idiomaLbl.Location = new System.Drawing.Point(9, 154);
			this.idiomaLbl.Name = "idiomaLbl";
			this.idiomaLbl.Size = new System.Drawing.Size(38, 13);
			this.idiomaLbl.TabIndex = 7;
			this.idiomaLbl.Text = "Idioma";
			// 
			// ABMPersona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 628);
			this.ControlBox = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.GetDataPageAfterInsert = false;
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "ABMPersona";
			this.Text = "Persona ";
			this.Load += new System.EventHandler(this.ABMPersona_Load);
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

		private System.Windows.Forms.Label nombreLbl;
		private System.Windows.Forms.TextBox nombreTB;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label emailLbl;
		private System.Windows.Forms.Label paisLbl;
		private System.Windows.Forms.Label activoLbl;
		private System.Windows.Forms.TextBox aliasTB;
		private System.Windows.Forms.TextBox apellidoTB;
		private System.Windows.Forms.Label apellidoLbl;
		private System.Windows.Forms.Label aliasLbl;
		private System.Windows.Forms.TextBox emailTB;
		private System.Windows.Forms.CheckBox activoCB;
		private Comun.Controles.FKBoxes.PaisFKBox fKBoxPais;
		private System.Windows.Forms.CheckedListBox idiomasCLB;
		private System.Windows.Forms.Label idiomaLbl;
	}
}


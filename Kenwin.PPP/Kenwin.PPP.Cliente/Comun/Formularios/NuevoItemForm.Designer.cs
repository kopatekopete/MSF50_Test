namespace Kenwin.PPP.Cliente.Comun.Formularios
{
	partial class NuevoItemForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoItemForm));
			this.cancelButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton();
			this.okButton = new Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.descripcionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.ButtonType = Vemn.Fwk.Windows.Controls.VemnButton.ButtonTypeEnum.Cancel;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
			this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cancelButton.Location = new System.Drawing.Point(224, 100);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(70, 30);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "&Cancelar";
			this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
			this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.okButton.Location = new System.Drawing.Point(148, 100);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(70, 30);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "&Aceptar";
			this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.okButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.Location = new System.Drawing.Point(12, 57);
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(282, 20);
			this.descripcionTextBox.TabIndex = 0;
			// 
			// descripcionLabel
			// 
			this.descripcionLabel.AutoSize = true;
			this.descripcionLabel.Location = new System.Drawing.Point(12, 28);
			this.descripcionLabel.Name = "descripcionLabel";
			this.descripcionLabel.Size = new System.Drawing.Size(203, 13);
			this.descripcionLabel.TabIndex = 3;
			this.descripcionLabel.Text = "Ingrese la Descripción del Item a agregar:";
			// 
			// NuevoItemForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(306, 142);
			this.ControlBox = false;
			this.Controls.Add(this.descripcionLabel);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NuevoItemForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar nuevo Item";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.CancelButton cancelButton;
		private Vemn.Fwk.ClientServer.Windows.Controls.Buttons.OkButton okButton;
		private System.Windows.Forms.TextBox descripcionTextBox;
		private System.Windows.Forms.Label descripcionLabel;
	}
}
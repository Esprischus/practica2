/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 26/10/2026
 * Time: 07:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica_cero_dos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnMenos = new System.Windows.Forms.Button();
			this.btnMas = new System.Windows.Forms.Button();
			this.btnEntre = new System.Windows.Forms.Button();
			this.btnPor = new System.Windows.Forms.Button();
			this.lblR = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.formulaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblresiduo = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero 1:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(121, 24);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 1;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(121, 47);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero 2:";
			// 
			// btnMenos
			// 
			this.btnMenos.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenos.Location = new System.Drawing.Point(14, 186);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(56, 42);
			this.btnMenos.TabIndex = 4;
			this.btnMenos.Text = "-";
			this.btnMenos.UseVisualStyleBackColor = true;
			this.btnMenos.Click += new System.EventHandler(this.BtnMenosClick);
			// 
			// btnMas
			// 
			this.btnMas.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMas.Location = new System.Drawing.Point(77, 138);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(56, 42);
			this.btnMas.TabIndex = 5;
			this.btnMas.Text = "+";
			this.btnMas.UseVisualStyleBackColor = true;
			this.btnMas.Click += new System.EventHandler(this.BtnMasClick);
			// 
			// btnEntre
			// 
			this.btnEntre.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntre.Location = new System.Drawing.Point(15, 138);
			this.btnEntre.Name = "btnEntre";
			this.btnEntre.Size = new System.Drawing.Size(56, 42);
			this.btnEntre.TabIndex = 6;
			this.btnEntre.Text = "/";
			this.btnEntre.UseVisualStyleBackColor = true;
			this.btnEntre.Click += new System.EventHandler(this.BtnEntreClick);
			// 
			// btnPor
			// 
			this.btnPor.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPor.Location = new System.Drawing.Point(77, 186);
			this.btnPor.Name = "btnPor";
			this.btnPor.Size = new System.Drawing.Size(56, 42);
			this.btnPor.TabIndex = 7;
			this.btnPor.Text = "X";
			this.btnPor.UseVisualStyleBackColor = true;
			this.btnPor.Click += new System.EventHandler(this.BtnPorClick);
			// 
			// lblR
			// 
			this.lblR.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblR.Location = new System.Drawing.Point(15, 71);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(118, 51);
			this.lblR.TabIndex = 8;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.formulaGeneralToolStripMenuItem,
									this.cerrarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(317, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// formulaGeneralToolStripMenuItem
			// 
			this.formulaGeneralToolStripMenuItem.Name = "formulaGeneralToolStripMenuItem";
			this.formulaGeneralToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.formulaGeneralToolStripMenuItem.Text = "Formula General";
			this.formulaGeneralToolStripMenuItem.Click += new System.EventHandler(this.FormulaGeneralToolStripMenuItemClick);
			// 
			// cerrarToolStripMenuItem
			// 
			this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
			this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.cerrarToolStripMenuItem.Text = "Cerrar";
			this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItemClick);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(249, 181);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(56, 42);
			this.btnClear.TabIndex = 10;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// lblresiduo
			// 
			this.lblresiduo.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresiduo.Location = new System.Drawing.Point(152, 70);
			this.lblresiduo.Name = "lblresiduo";
			this.lblresiduo.Size = new System.Drawing.Size(118, 51);
			this.lblresiduo.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 235);
			this.Controls.Add(this.lblresiduo);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lblR);
			this.Controls.Add(this.btnPor);
			this.Controls.Add(this.btnEntre);
			this.Controls.Add(this.btnMas);
			this.Controls.Add(this.btnMenos);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "practica cero dos";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblresiduo;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formulaGeneralToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label lblR;
		private System.Windows.Forms.Button btnPor;
		private System.Windows.Forms.Button btnEntre;
		private System.Windows.Forms.Button btnMas;
		private System.Windows.Forms.Button btnMenos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label1;
	}
}

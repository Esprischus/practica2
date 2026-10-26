/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 26/10/2026
 * Time: 07:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica_cero_dos
{
	partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnborrar = new System.Windows.Forms.Button();
			this.btncalcular = new System.Windows.Forms.Button();
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.txtNum3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.regresarToolStripMenuItem,
									this.cerrarToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(231, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// regresarToolStripMenuItem
			// 
			this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
			this.regresarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.regresarToolStripMenuItem.Text = "Regresar";
			this.regresarToolStripMenuItem.Click += new System.EventHandler(this.RegresarToolStripMenuItemClick);
			// 
			// cerrarToolStripMenuItem
			// 
			this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
			this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.cerrarToolStripMenuItem.Text = "Cerrar";
			this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItemClick);
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(118, 46);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Numero 2:";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(118, 23);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Numero 1:";
			// 
			// btnborrar
			// 
			this.btnborrar.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnborrar.Location = new System.Drawing.Point(68, 207);
			this.btnborrar.Name = "btnborrar";
			this.btnborrar.Size = new System.Drawing.Size(56, 42);
			this.btnborrar.TabIndex = 9;
			this.btnborrar.Text = "X";
			this.btnborrar.UseVisualStyleBackColor = true;
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.Location = new System.Drawing.Point(5, 207);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(56, 42);
			this.btncalcular.TabIndex = 8;
			this.btncalcular.Text = "-";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// lblX1
			// 
			this.lblX1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX1.Location = new System.Drawing.Point(12, 142);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(206, 23);
			this.lblX1.TabIndex = 10;
			// 
			// lblX2
			// 
			this.lblX2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX2.Location = new System.Drawing.Point(12, 119);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(206, 23);
			this.lblX2.TabIndex = 11;
			// 
			// txtNum3
			// 
			this.txtNum3.Location = new System.Drawing.Point(118, 73);
			this.txtNum3.Name = "txtNum3";
			this.txtNum3.Size = new System.Drawing.Size(100, 20);
			this.txtNum3.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Numero 3:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(231, 261);
			this.Controls.Add(this.txtNum3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblX2);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.btnborrar);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNum3;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Button btnborrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}

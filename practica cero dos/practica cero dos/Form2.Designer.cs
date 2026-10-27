/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 27/10/2026
 * Time: 07:40 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica_cero_dos
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pbIzuna = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbIzuna)).BeginInit();
			this.SuspendLayout();
			// 
			// pbIzuna
			// 
			this.pbIzuna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIzuna.BackgroundImage")));
			this.pbIzuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbIzuna.Location = new System.Drawing.Point(4, 12);
			this.pbIzuna.Name = "pbIzuna";
			this.pbIzuna.Size = new System.Drawing.Size(275, 236);
			this.pbIzuna.TabIndex = 0;
			this.pbIzuna.TabStop = false;
			this.pbIzuna.Click += new System.EventHandler(this.PbIzunaClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.pbIzuna);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pbIzuna)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pbIzuna;
	}
}

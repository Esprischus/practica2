/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 26/10/2026
 * Time: 07:35 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica_cero_dos
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CerrarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void RegresarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm xd= new MainForm();
			xd.Show();
			this.Close();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			double a, b, c, f, z;
			a=Convert.ToDouble(txtNum1.Text);
			b=Convert.ToDouble(txtNum2.Text);
			c=Convert.ToDouble(txtNum3.Text);
			z = Math.Pow(b, 2) - (4 * a * c);
			double x1 = (-b + Math.Sqrt(z)) / (2 * a);
            double x2 = (-b - Math.Sqrt(z)) / (2 * a);
            lblX2.Text="X1= : "+ Convert.ToString(x1);
            lblX1.Text="X2= : "+ Convert.ToString(x2);
		}
		
		void BtnborrarClick(object sender, EventArgs e)
		{
			txtNum1.Text="";
			txtNum2.Text="";
			txtNum3.Text="";
			lblX2.Text="";
			lblX1.Text="";
		}
	}
}

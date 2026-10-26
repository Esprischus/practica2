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
			double x, d, c, f, z;
			x=Convert.ToDouble(txtNum1.Text);
			d=Convert.ToDouble(txtNum2.Text);
			c=Convert.ToDouble(txtNum3.Text);
			f= (d*d)- (4*x*c);
			z=Math.Sqrt(f);
			f=-d-z;
			f=f/(2*x);
			lblX1.Text="X1: " + Convert.ToString(f);
		}
	}
}

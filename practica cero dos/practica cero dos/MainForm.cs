/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 26/10/2026
 * Time: 07:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica_cero_dos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnEntreClick(object sender, EventArgs e)
		{
			double x,c,d;
			x=Convert.ToDouble(txtNum1.Text);
			c=Convert.ToDouble(txtNum2.Text);
			d=x/c;
			lblR.Text=Convert.ToString(d);
		}
		
		void BtnPorClick(object sender, EventArgs e)
		{
			double x,c,d;
			x=Convert.ToDouble(txtNum1.Text);
			c=Convert.ToDouble(txtNum2.Text);
			d=x*c;
			lblR.Text=Convert.ToString(d);
		}
		
		void BtnMenosClick(object sender, EventArgs e)
		{
			double x,c,d;
			x=Convert.ToDouble(txtNum1.Text);
			c=Convert.ToDouble(txtNum2.Text);
			d=x-c;
			lblR.Text=Convert.ToString(d);
		}
		
		void BtnMasClick(object sender, EventArgs e)
		{
			double x,c,d;
			x=Convert.ToDouble(txtNum1.Text);
			c=Convert.ToDouble(txtNum2.Text);
			d=x+c;
			lblR.Text=Convert.ToString(d);
		}
	}
}

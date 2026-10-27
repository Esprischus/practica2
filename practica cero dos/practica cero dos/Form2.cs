/*
 * Created by SharpDevelop.
 * User: CC2_PC25
 * Date: 27/10/2026
 * Time: 07:40 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace practica_cero_dos
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PbIzunaClick(object sender, EventArgs e)
		{
			MessageBox.Show("NIN NIN");
			this.Close();
		}
	}
}

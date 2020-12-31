using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsonify
{
	public partial class Form1 : Form
	{
		String jsonToParse = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void Format_Click(object sender, EventArgs e)
		{
			jsonToParse = Userin.Text;
			outP.Text = src.parse.parser(jsonToParse);
		}

		private void ClearO_Click(object sender, EventArgs e)
		{
			outP.Text = null;
		}
	}
}

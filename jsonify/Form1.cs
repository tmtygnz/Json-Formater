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

		private void darkTheme_CheckedChanged(object sender, EventArgs e)
		{
			if(darkTheme.Checked == true)
			{
				this.BackColor = Color.FromArgb(45, 48, 50);
				GB1.ForeColor = Color.FromName("White");
				Format.BackColor = Color.FromArgb(45, 48, 50);
				Format.ForeColor = Color.FromName("White");
				ClearO.BackColor = Color.FromArgb(45, 48, 50);
				ClearO.ForeColor = Color.FromName("White");
				darkTheme.ForeColor = Color.FromName("White");
				OutputB.ForeColor = Color.FromName("White");
			}
			if (darkTheme.Checked == false)
			{
				this.BackColor = Color.FromArgb(230, 230, 230);
				GB1.ForeColor = Color.FromName("Black");
				Format.BackColor = Color.FromArgb(230, 230, 230);
				Format.ForeColor = Color.FromName("Black");
				ClearO.BackColor = Color.FromArgb(230, 230, 230);
				ClearO.ForeColor = Color.FromName("Black");
				darkTheme.ForeColor = Color.FromName("Black");
				OutputB.ForeColor = Color.FromName("Black");
			}
		}
	}
}

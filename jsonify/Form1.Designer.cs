
namespace jsonify
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.GB1 = new System.Windows.Forms.GroupBox();
			this.Userin = new System.Windows.Forms.RichTextBox();
			this.Format = new System.Windows.Forms.Button();
			this.ClearO = new System.Windows.Forms.Button();
			this.outP = new System.Windows.Forms.RichTextBox();
			this.OutputB = new System.Windows.Forms.GroupBox();
			this.darkTheme = new System.Windows.Forms.CheckBox();
			this.GB1.SuspendLayout();
			this.OutputB.SuspendLayout();
			this.SuspendLayout();
			// 
			// GB1
			// 
			this.GB1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GB1.Controls.Add(this.Userin);
			this.GB1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.GB1.Location = new System.Drawing.Point(12, 12);
			this.GB1.Name = "GB1";
			this.GB1.Size = new System.Drawing.Size(1090, 262);
			this.GB1.TabIndex = 0;
			this.GB1.TabStop = false;
			this.GB1.Text = "Input";
			// 
			// Userin
			// 
			this.Userin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Userin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Userin.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Userin.Location = new System.Drawing.Point(6, 21);
			this.Userin.Name = "Userin";
			this.Userin.Size = new System.Drawing.Size(1078, 235);
			this.Userin.TabIndex = 0;
			this.Userin.Text = "";
			// 
			// Format
			// 
			this.Format.Location = new System.Drawing.Point(18, 280);
			this.Format.Name = "Format";
			this.Format.Size = new System.Drawing.Size(82, 38);
			this.Format.TabIndex = 1;
			this.Format.Text = "Format";
			this.Format.UseVisualStyleBackColor = true;
			this.Format.Click += new System.EventHandler(this.Format_Click);
			// 
			// ClearO
			// 
			this.ClearO.Location = new System.Drawing.Point(106, 280);
			this.ClearO.Name = "ClearO";
			this.ClearO.Size = new System.Drawing.Size(82, 38);
			this.ClearO.TabIndex = 2;
			this.ClearO.Text = "Clear Output";
			this.ClearO.UseVisualStyleBackColor = true;
			this.ClearO.Click += new System.EventHandler(this.ClearO_Click);
			// 
			// outP
			// 
			this.outP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.outP.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outP.Location = new System.Drawing.Point(6, 21);
			this.outP.Name = "outP";
			this.outP.Size = new System.Drawing.Size(1078, 235);
			this.outP.TabIndex = 0;
			this.outP.Text = "";
			// 
			// OutputB
			// 
			this.OutputB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputB.Controls.Add(this.outP);
			this.OutputB.Location = new System.Drawing.Point(12, 324);
			this.OutputB.Name = "OutputB";
			this.OutputB.Size = new System.Drawing.Size(1090, 262);
			this.OutputB.TabIndex = 1;
			this.OutputB.TabStop = false;
			this.OutputB.Text = "Formated JSON";
			// 
			// darkTheme
			// 
			this.darkTheme.AutoSize = true;
			this.darkTheme.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.darkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.darkTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkTheme.Location = new System.Drawing.Point(194, 292);
			this.darkTheme.Name = "darkTheme";
			this.darkTheme.Size = new System.Drawing.Size(86, 19);
			this.darkTheme.TabIndex = 3;
			this.darkTheme.Text = "Dark Theme";
			this.darkTheme.UseVisualStyleBackColor = true;
			this.darkTheme.CheckedChanged += new System.EventHandler(this.darkTheme_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.ClientSize = new System.Drawing.Size(1104, 595);
			this.Controls.Add(this.darkTheme);
			this.Controls.Add(this.OutputB);
			this.Controls.Add(this.ClearO);
			this.Controls.Add(this.Format);
			this.Controls.Add(this.GB1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Json Formater";
			this.GB1.ResumeLayout(false);
			this.OutputB.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox GB1;
		private System.Windows.Forms.Button Format;
		private System.Windows.Forms.Button ClearO;
		private System.Windows.Forms.RichTextBox Userin;
		private System.Windows.Forms.RichTextBox outP;
		private System.Windows.Forms.GroupBox OutputB;
		private System.Windows.Forms.CheckBox darkTheme;
	}
}


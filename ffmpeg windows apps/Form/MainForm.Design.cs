using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

partial class MainForm : Form {
	void InitializeComponent() {
		this.testButton = new Button();
		
		this.testButton.Text = "test";
		this.testButton.Size = new Size(175, 25);
		this.testButton.Location = new Point(0, 0);
		this.testButton.Click += new EventHandler(testButtonClick);

		this.Controls.Add(this.testButton);
	}
}
using System;
using System.Windows.Forms;

partial class MainForm : Form {
	Button testButton;
	public MainForm() {
		StartForm startForm = new StartForm();
		startForm.ShowDialog();
		InitializeComponent();
	}
	void testButtonClick(object sender, EventArgs e) {
	}
}
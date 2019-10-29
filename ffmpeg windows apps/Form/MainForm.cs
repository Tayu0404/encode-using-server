using System;
using System.Windows.Forms;

partial class MainForm : Form {
	public MainForm() {
		StartForm startForm = new StartForm();
		startForm.ShowDialog();
	}
}

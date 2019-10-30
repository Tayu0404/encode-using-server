using System;
using System.Windows.Forms;

partial class StartForm : Form {
	Label sshHostNameLabel, sshPortLabel, sshUserNameLabel;
	TextBox sshHostName, sshPort, sshUserName, sshPassword, sshPriveteKey;
	Button sshPriveteKeySelect, acceptButton;
	ComboBox sshPassOrKeySwitch;

	public StartForm() {
		InitializeComponent();
	}

	void sshPassOrKeySwitchChenged(object sender, EventArgs e) { 
		if (this.sshPassOrKeySwitch.Text == "Password") {
			this.sshPriveteKey.Visible = false;
			this.sshPriveteKeySelect.Visible = false;
			this.sshPassword.Visible = true;
		}
		if (this.sshPassOrKeySwitch.Text == "Privete Key") {
			this.sshPassword.Visible = false;
			this.sshPriveteKey.Visible = true;
			this.sshPriveteKeySelect.Visible = true;
		}
	}
	
	void sshPriveteKeyClick(object sender, EventArgs e) {
		// string filePath = string.Empty;
		OpenFileDialog selectPriveteKey = new OpenFileDialog() {
			Multiselect = false
		};

		DialogResult result = selectPriveteKey.ShowDialog();
		if (result == DialogResult.OK) {
			this.sshPriveteKey.Text = selectPriveteKey.FileName;
		}
	}
}
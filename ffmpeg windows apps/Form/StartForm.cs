using System;
using System.Windows.Forms;

partial class StartForm : Form {
	Label sshHostNameLabel, sshPortLabel, sshUserNameLabel;
	TextBox sshHostName, sshPort, sshUserName, sshPassword, sshPrivateKey;
	Button sshPrivateKeySelect, acceptButton;
	ComboBox sshPassOrKeySwitch;

	public StartForm() {
		InitializeComponent();
	}

	void sshPassOrKeySwitchChenged(object sender, EventArgs e) { 
		if (this.sshPassOrKeySwitch.Text == "Password") {
			this.sshPrivateKey.Visible = false;
			this.sshPrivateKeySelect.Visible = false;
			this.sshPassword.Visible = true;
		}
		if (this.sshPassOrKeySwitch.Text == "Privete Key") {
			this.sshPassword.Visible = false;
			this.sshPrivateKey.Visible = true;
			this.sshPrivateKeySelect.Visible = true;
		}
	}
	
	void sshPriveteKeyClick(object sender, EventArgs e) {
		// string filePath = string.Empty;
		OpenFileDialog selectPriveteKey = new OpenFileDialog() {
			Multiselect = false
		};

		DialogResult result = selectPriveteKey.ShowDialog();
		if (result == DialogResult.OK) {
			this.sshPrivateKey.Text = selectPriveteKey.FileName;
		}
	}
}
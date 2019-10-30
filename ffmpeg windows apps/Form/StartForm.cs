using System;
using System.Windows.Forms;

partial class StartForm : Form {
	Label sshHostNameLabel, sshPortLabel, sshUserNameLabel, sshPasswordLabel, sshPriveteKeyLabel;
	TextBox sshHostName, sshPort, sshUserName, sshPassword, sshPriveteKey;
	Button sshPriveteKeySelect, acceptButton;
	RadioButton[] sshPassOrKeySwitch;

	public StartForm(){
		InitializeComponent();
	}

	void sshPassOrKeySwitchChenged(object sender, EventArgs e) {
		RadioButton PassOrkeySwitch = sender as RadioButton;
		if (PassOrkeySwitch.Text == "Password") {
			this.sshPriveteKeyLabel.Visible  = false;
			this.sshPriveteKey.Visible       = false;
			this.sshPriveteKeySelect.Visible = false;
			this.sshPasswordLabel.Visible    = true;
			this.sshPassword.Visible         = true;
		}
		if (PassOrkeySwitch.Text == "Privete Key") {
			this.sshPasswordLabel.Visible    = false;
			this.sshPassword.Visible         = false;
			this.sshPriveteKeyLabel.Visible  = true;
			this.sshPriveteKey.Visible       = true;
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
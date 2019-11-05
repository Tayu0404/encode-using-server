using System;
using System.Windows.Forms;

partial class SshSetForm : Form {
	private Label sshHostNameLabel, sshPortLabel, sshUserNameLabel;
	private TextBox sshHostName, sshPort, sshUserName, sshPassword, sshPrivateKey;
	private Button sshPrivateKeySelect, acceptButton;
	private ComboBox sshPassOrKeySwitch;

	public string SshHostName {
		get { return sshHostName.Text; }
	}

	public int SshPort {
		get { return int.Parse(sshPort.Text); }
	}

	public string SshUserName {
		get { return sshUserName.Text; }
	}

	public string SshPassword {
		get { return sshPassword.Text; }
	}

	public string SshPrivateKey {
		get { return sshPrivateKey.Text; }
	}

	public string SshPassOrKey {
		get { return sshPassOrKeySwitch.Text; }
	}

	public SshSetForm() {
		InitializeComponent();
	}

	void sshPassOrKeySwitchChenged(object sender, EventArgs e) { 
		if (this.sshPassOrKeySwitch.Text == "Password") {
			this.sshPrivateKey.Visible = false;
			this.sshPrivateKeySelect.Visible = false;
			this.sshPassword.Visible = true;
		}
		if (this.sshPassOrKeySwitch.Text == "Private Key") {
			this.sshPassword.Visible = false;
			this.sshPrivateKey.Visible = true;
			this.sshPrivateKeySelect.Visible = true;
		}
	}

	void sshPortKeyPress(object sender, KeyPressEventArgs e) {
		if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b') {
			e.Handled = true;
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
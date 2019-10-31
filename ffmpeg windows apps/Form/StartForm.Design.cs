using System;
using System.Drawing;
using System.Windows.Forms;

partial class StartForm : Form {
	void InitializeComponent() {
		const int margen = 15;
		int curW = 0, curH = 0;

		string[] sshPassOrKeySwitchText = {
			"Password", "Privete Key"
		};
	
		this.sshHostNameLabel    = new Label();
		this.sshHostName         = new TextBox();
		this.sshPortLabel        = new Label();
		this.sshPort             = new TextBox();
		this.sshUserNameLabel    = new Label();
		this.sshUserName         = new TextBox();
		this.sshPassOrKeySwitch  = new ComboBox();
		this.sshPassword         = new TextBox();
		this.sshPrivateKey       = new TextBox();
		this.sshPrivateKeySelect = new Button();
		this.acceptButton        = new Button();

		curW = curH = margen;

		this.sshHostNameLabel.Text = "HostName";
		this.sshHostNameLabel.Size = new Size(175, 25);
		this.sshHostNameLabel.Location = new Point(curW, curH);

		curH += sshHostNameLabel.Size.Height;

		this.sshHostName.Size = new Size(175, 25);
		this.sshHostName.Location = new Point(curW, curH);

		curH += sshHostName.Size.Height;

		this.sshPortLabel.Text = "Port";
		this.sshPortLabel.Size = new Size(175, 25);
		this.sshPortLabel.Location = new Point(curW, curH);

		curH += sshPortLabel.Size.Height;

		this.sshPort.Size = new Size(175, 25);
		this.sshPort.Location = new Point(curW, curH);

		curH += sshPort.Size.Height;

		this.sshUserNameLabel.Text = "User";
		this.sshUserNameLabel.Size = new Size(175, 25);
		this.sshUserNameLabel.Location = new Point(curW, curH);

		curH += sshUserNameLabel.Size.Height;

		this.sshUserName.Size = new Size(175, 25);
		this.sshUserName.Location = new Point(curW, curH);

		curH += sshUserName.Size.Height;

		this.sshPassOrKeySwitch.Items.AddRange(new object[]{
			"Password",
			"Privete Key",
		});
		this.sshPassOrKeySwitch.SelectedIndex = 0;
		this.sshPassOrKeySwitch.Size = new Size(175, 25);
		this.sshPassOrKeySwitch.Location = new Point(curW, curH);
		this.sshPassOrKeySwitch.DropDownStyle = ComboBoxStyle.DropDownList;
		this.sshPassOrKeySwitch.SelectedIndexChanged += new EventHandler(sshPassOrKeySwitchChenged);

		curH += sshPassOrKeySwitch.Size.Height;

		this.sshPassword.Size = new Size(175, 25);
		this.sshPassword.Location = new Point(curW, curH);

		this.sshPrivateKey.Size = new Size(125, 25);
		this.sshPrivateKey.Location = new Point(curW, curH);
		this.sshPrivateKey.Visible = false;

		this.sshPrivateKeySelect.Text = "Select";
		this.sshPrivateKeySelect.Size = new Size(50, 25);
		this.sshPrivateKeySelect.Location = new Point(curW + this.sshPrivateKey.Size.Width, curH);
		this.sshPrivateKeySelect.Visible = false;
		this.sshPrivateKeySelect.Click += new EventHandler(sshPriveteKeyClick);

		curH += sshPrivateKey.Size.Height;

		this.acceptButton.Text = "Accept";
		this.acceptButton.DialogResult = DialogResult.OK;
		this.acceptButton.Size = new Size(175, 25);
		this.acceptButton.Location = new Point(curW, curH);

		curH += acceptButton.Size.Height;

		this.Text = "SSH setting";
		this.ClientSize = new Size(175 + (margen * 2), curH);

		this.Controls.Add(this.sshHostNameLabel);
		this.Controls.Add(this.sshHostName);
		this.Controls.Add(this.sshPortLabel);
		this.Controls.Add(this.sshPort);
		this.Controls.Add(this.sshUserNameLabel);
		this.Controls.Add(this.sshUserName);
		this.Controls.Add(this.sshPassOrKeySwitch);
		this.Controls.Add(this.sshPassword);
		this.Controls.Add(this.sshPrivateKey);
		this.Controls.Add(this.sshPrivateKeySelect);
		this.Controls.Add(this.acceptButton);

		this.AcceptButton = this.acceptButton;
	}
}
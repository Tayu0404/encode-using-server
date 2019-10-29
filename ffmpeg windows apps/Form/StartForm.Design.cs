using System;
using System.Drawing;
using System.Windows.Forms;

partial class StartForm : Form {
	public StartForm() {
		const int margen = 15;
		int curW = 0, curH = 0;

		string[] sshPassOrKeySwitchText = {
			"Password", "Privete Key"
		};
	
		this.sshHostNameLabel   = new Label();
		this.sshHostName        = new TextBox();
		this.sshPortLabel       = new Label();
		this.sshPort            = new TextBox();
		this.sshUserNameLabel   = new Label();
		this.sshUserName        = new TextBox();
		this.sshPassOrKeySwitch = new RadioButton[2];
		this.sshPasswordLabel   = new Label();
		this.sshPassword        = new TextBox();
		this.sshPriveteKeyLabel = new Label();
		this.sshPriveteKey      = new Button();
		this.acceptButton       = new Button();

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

		for (int i = 0; i < this.sshPassOrKeySwitch.Length; i++) {
			this.sshPassOrKeySwitch[i] = new RadioButton {
				Text = sshPassOrKeySwitchText[i],
				Size = new Size(175, 25),
				Location = new Point(curW, curH),
			};
			this.sshPassOrKeySwitch[i].CheckedChanged += new EventHandler(sshPassOrKeySwitchChenged);

			curH += sshPort.Size.Height;
		}
		this.sshPassOrKeySwitch[0].Checked = true;

		this.sshPasswordLabel.Text = "Password";
		this.sshPasswordLabel.Size = new Size(175, 25);
		this.sshPasswordLabel.Location = new Point(curW, curH);

		this.sshPriveteKeyLabel.Text = "Privete Key";
		this.sshPriveteKeyLabel.Size = new Size(175, 25);
		this.sshPriveteKeyLabel.Location = new Point(curW, curH);
		this.sshPriveteKeyLabel.Visible = false;

		curH += sshPriveteKeyLabel.Size.Height;

		this.sshPassword.Size = new Size(175, 25);
		this.sshPassword.Location = new Point(curW, curH);

		this.sshPriveteKey.Text = "Select File";
		this.sshPriveteKey.Size = new Size(175, 25);
		this.sshPriveteKey.Location = new Point(curW, curH);
		this.sshPriveteKey.Visible = false;
		this.sshPriveteKey.Click += new EventHandler(sshPriveteKeyClick);

		curH += sshPriveteKey.Size.Height;

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
		this.Controls.AddRange(this.sshPassOrKeySwitch);
		this.Controls.Add(this.sshPasswordLabel);
		this.Controls.Add(this.sshPassword);
		this.Controls.Add(this.sshPriveteKeyLabel);
		this.Controls.Add(this.sshPriveteKey);
		this.Controls.Add(this.acceptButton);

		this.AcceptButton = this.acceptButton;
	}
}
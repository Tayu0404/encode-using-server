using System;
using System.Windows.Forms;
using Renci.SshNet;

partial class MainForm : Form {
	Button testButton;
	public MainForm() {
		InitializeComponent();
	}
	void testButtonClick(object sender, EventArgs e) {
		Ssh ssh = new Ssh();
		SshSetForm startForm = new SshSetForm();
		DialogResult result = startForm.ShowDialog();
		if (result == DialogResult.OK) {
			
		}
		
		using (var sshClient = new SshClient(ssh.ConnectionInfo)){
			sshClient.Connect();
			if (sshClient.IsConnected) {
				using (var cmd = sshClient.CreateCommand("ls")) {
					Console.WriteLine(cmd.Execute());
					Console.WriteLine(cmd.Error);
					Console.WriteLine(cmd.Result);
					Console.WriteLine(cmd.ExitStatus);
				}
			} else {
				Console.WriteLine("Connection Error");
				return;
			}
			sshClient.Disconnect();
		}
	}
}
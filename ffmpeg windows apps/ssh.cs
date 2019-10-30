using System;
using System.Collections.Generic;
using System.Text;
using Renci.SshNet;

public class ssh {
	public ConnectionInfo cnctInfo { private set; get; }
	public void constructSSH(string hostName, int port, string userName, string password, string priveteKey) {
		var passAuth = new PasswordAuthenticationMethod(userName, password);
		var keyAuth = new PrivateKeyAuthenticationMethod(userName, new PrivateKeyFile[]{
			new PrivateKeyFile(priveteKey)
		});
		cnctInfo = new ConnectionInfo(hostName, port, userName, new AuthenticationMethod[]{
			passAuth,
			keyAuth
		});
	}

	public void ConnectSSH(string hostName, int port, string userName, string password, string priveteKey) {
		constructSSH(hostName, port, userName, password, priveteKey);
		using (var ssh = new SshClient(cnctInfo)) {
			ssh.Connect();
			if (ssh.IsConnected) {
				using (var cmd = ssh.CreateCommand("ls")) {
					Console.WriteLine(cmd.Execute());
					Console.WriteLine(cmd.Error);
					Console.WriteLine(cmd.Result);
					Console.WriteLine(cmd.ExitStatus);
				}
			} else {
				Console.WriteLine("Connection Error");
				return;
			}
		}
	}
}
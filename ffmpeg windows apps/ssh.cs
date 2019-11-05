using System;
using System.Collections.Generic;
using System.Text;
using Renci.SshNet;

public class Ssh {
	private ConnectionInfo connectionInfo;
	private string hostName;
	private int port;
	private string userName;
	private string password;
	private string privateKey;
	private string authPassOrKey;
	
	public ConnectionInfo ConnectionInfo {
		get {
			if (authPassOrKey == "Password") {
				var Auth = new PasswordAuthenticationMethod(this.userName, this.password);
				connectionInfo = new ConnectionInfo(hostName, port, userName, new AuthenticationMethod[]{
					Auth
				});
			}
			if (authPassOrKey == "Private Key") {
				var Auth = new PrivateKeyAuthenticationMethod(this.userName, new PrivateKeyFile[]{
					new PrivateKeyFile(this.privateKey,"")
				}) ;
				connectionInfo = new ConnectionInfo(hostName, port, userName, new AuthenticationMethod[]{
					Auth
				});
			}
			return connectionInfo;
		}
	}
	public String HostName {
		set { hostName = value; }
		get { return hostName; }
	}
	public int Port {
		set { port = value; }
		get { return port; }
	}
	public string UserName {
		set { userName = value; }
		get { return userName; }
	}
	public string Password {
		set { password = value; }
		get { return password; }
	}
	
	public string PrivateKey {
		set { privateKey = value; }
		get { return privateKey; }
	}

	public string AuthPassOrKey {
		set { authPassOrKey = value; }
		get { return authPassOrKey; }
	}
}
using MySqlConnector;

namespace MintOs.Banco
{
	public class Conexao
	{
		private const string ConnectionString =
			"Server=mysql-pdv-mintos.l.aivencloud.com;" +
			"Port=12273;" +
			"User ID=avnadmin;" +
            "Password=SUA_SENHA_AQUI;" +
			"Database=defaultdb;" +
			"SslMode=VerifyCA;" +
			"SslCa=C:\\Users\\barro\\Downloads\\ca1.pem;";

		public static MySqlConnection Criar()
		{
			return new MySqlConnection(ConnectionString);
		}
	}
}
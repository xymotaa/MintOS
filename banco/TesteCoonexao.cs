using System;
using MySqlConnector;

namespace MintOs.Banco
{
    public class TesteConexao
    {
        public static void Testar()
        {
            using (var conexao = Conexao.Criar())
            {
                conexao.Open();

                Console.WriteLine("Conexão com o MySQL realizada com sucesso!");
                Console.WriteLine($"Banco: {conexao.Database}");
            }
        }
    }
}
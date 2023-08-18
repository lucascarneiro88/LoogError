using System;

namespace ExemploLogError
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Simulando um erro de conexão ao banco de dados
                throw new Exception("Erro ao conectar ao banco de dados");
            }
            catch (Exception ex)
            {
                // Registro do erro no log (no caso, exibição no console)
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asteriscos = "*";
            EscritorSingleton s1 = EscritorSingleton.Instancia;
            EscritorSingleton s2 = EscritorSingleton.Instancia;
            EscritorSingleton s3 = EscritorSingleton.Instancia;

            s1.EscribirMensaje("Usando el S1, hola mundo ");
            s2.EscribirMensaje("Usando el S2, hola mundo ");
            s3.EscribirMensaje("Usando el S3, hola mundo ");


            for (int i = 0; i <= 10; i++)
            {
                asteriscos += "*";
                s1.EscribirMensaje("Usando el S1, hola mundo " + asteriscos);
                for (int j = 0; j <= 10; j++)
                {
                    s2.EscribirMensaje("Usando el S2, hola mundo ");
                    for (int k = 0; k <= 10; k++)
                    {
                        asteriscos += "*";
                        s3.EscribirMensaje("Usando el S3, hola mundo " + asteriscos);
                    }

                }
            }

        }
    }
}
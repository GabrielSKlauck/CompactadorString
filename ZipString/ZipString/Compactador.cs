
namespace ZipString
{
    public class Compactador
    {
        public string Compactar(string base64)
        {
            //dddaaaaehfffnggtttjaaaa
            string base64Compactada;
            for (int i = 0; i < base64.Length;)
            {
                int contador = 1;
                string encurtador;
                try
                {
                    while (base64[i] == base64[i + contador])
                    {
                        contador++;
                    }
                    if (contador != 1)
                    {
                        base64 = base64.Remove(i, contador - 1);
                        encurtador = base64[i] + "-" + (contador - 1);                       
                        base64 = base64.Insert(i, encurtador);
                        i += 3;
                    }
                    else
                    {
                        i += 1;
                    }


                }
                catch (Exception e)
                {

                }
                encurtador = "";
                contador = 1;
            }
            Console.WriteLine(base64);
            return "";
        }
    }
}
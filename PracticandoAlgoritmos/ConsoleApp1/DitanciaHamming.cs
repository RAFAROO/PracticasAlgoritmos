namespace PracticasAlgoritmos
{
    public class DitanciaHamming
    {
        string text1 = "ejemplo";
        string text2 = "example";
        int distance =0;

        public void Distancia()
        {
            if (text1.Length != text2.Length)
                throw new Exception("No son iguales las cadenas");
            for(int i = 0; i < text1.Length; i++)
            {
                if (text1[i] != text2[i])
                    distance++;
            }
            Console.WriteLine($"Distancia es de: {distance}");
        }
    }
}

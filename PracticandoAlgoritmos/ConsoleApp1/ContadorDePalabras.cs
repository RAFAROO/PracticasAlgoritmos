namespace PracticasAlgoritmos
{
    public class ContadorDePalabras
    {
        string text = "ejemplo de contador de palabras          ";
        int n = 0;

        public void ContandoPalabras()
        {
            var palabras = text.Trim().Split(' ');
            n = palabras.Length;
            Console.WriteLine(n);
        }
    }
}

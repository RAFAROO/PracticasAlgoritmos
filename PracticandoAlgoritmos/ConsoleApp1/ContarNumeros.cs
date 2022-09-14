using System.Text.RegularExpressions;

namespace PracticasAlgoritmos
{
    public class ContarNumeros
    {
        string text = "lkjsdflkj4334lj34j34jl34j3j4lj3l4j3l";
        string busquedaFiltro = @"[0-9]";
        int contador = 0;
        public void NumeroContar()
        {
            contador = Regex.Matches(text, busquedaFiltro).Count();
            Console.WriteLine(contador);
        }
    }
}

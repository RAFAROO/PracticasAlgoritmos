namespace PracticasAlgoritmos
{
    public class InvertirCadena
    {
        string text = "";
        string result = "";

        public void CadenaInvertida(string cadena)
        {
            ///Solucion 1
            //text = cadena;
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    result += text[i];
            //}
            ///Solucion 2
            char[] chars = cadena.ToCharArray();
            Array.Reverse(chars);
            result = new string(chars);

            Console.Write(result);
        }
        
    }
}

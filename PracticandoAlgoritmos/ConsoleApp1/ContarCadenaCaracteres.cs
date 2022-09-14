namespace PracticasAlgoritmos
{
    internal class ContarCadenaCaracteres
    {
        string cadena = "lksdjflkjdsflkjdlfjdlskfjsdlfjdljj";

        char character = 'j';
        int n = 0;

        public void ContarCadena()
        {
            ///Opcion 1
            //foreach (var item in cadena)
            //{
            //    if (item == character)
            //        n++;
            //}
            ///Opcion 2
            ///
            n = cadena.Where(c=>c == character).Count();
            Console.WriteLine($"La palabra/caracter {character} se repite :{n} veces");
        }
    }
}

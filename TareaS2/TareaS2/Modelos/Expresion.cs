namespace TareaS2.Modelos
{
    public class Expresion { 
        
        public int numero1 { get; set; } = 0;
        public int numero2 { get; set; } = 0;

        public int suma()
        {
            return numero1 + numero2;
        }
        public int resta()
        {
            return numero1 - numero2;
        }
        public int multiplicacion()
        {
            return numero1 * numero2;
        }
        public int division()
        {
            return numero1 / numero2;
        }

        public int maximo()
        {
            if(numero1 > numero2)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
        }
        public int minimo()
        {
            if (numero1 < numero2)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
        }
    }
}

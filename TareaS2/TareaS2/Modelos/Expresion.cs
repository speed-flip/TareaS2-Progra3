namespace TareaS2.Modelos
{
    public class Expresion { 
        
        public double numero1 { get; set; } = 0;
        public double numero2 { get; set; } = 0;

        public double suma()
        {
            return numero1 + numero2;
        }
        public double resta()
        {
            return numero1 - numero2;
        }
        public double multiplicacion()
        {
            return numero1 * numero2;
        }
        public double division()
        {
            return numero1 / numero2;
        }

        public double maximo()
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
        public double minimo()
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

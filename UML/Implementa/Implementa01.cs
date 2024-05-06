namespace Implementa01
{

    // Herencia
    // Implementación
    public interface ISender
    {
        void Enviar(string message);
    }

    public class EmailSender : ISender
    {
        public void Enviar(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MobileSender : ISender
    {
        public void Enviar(string message)
        {
            Console.WriteLine(message);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ISender logger = new EmailSender();
            logger.Enviar("This message is logged to the console.");
        }
    }


}

namespace Dependencia01
{
    public class Alerta
    {
        private string servicio;
        private string personaAsignada;
        private string informacionError;

        public Alerta(string servicio, string personaAsignada, string informacionError)
        {
            this.servicio = servicio;
            this.personaAsignada = personaAsignada;
            this.informacionError = informacionError;
        }

        public string ObtenerMensaje()
        {
            return $"Error en el servicio {servicio}. Asignado a: {personaAsignada}. Información del error: {informacionError}";
        }
    }


    public class EmailSender
    {
        public void Enviar(Alerta alerta)
        {
            Console.WriteLine($"Enviando alerta por correo electrónico: {alerta.ObtenerMensaje()}");
        }
    }

    public class MobileSender
    {
        public void Llamar(Alerta alerta)
        {
            Console.WriteLine($"Enviando alerta por mensaje de texto: {alerta.ObtenerMensaje()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alerta alerta = new Alerta("Servicio de base de datos", "John Doe", "Error de conexión");

            EmailSender emailSender = new EmailSender();
            MobileSender mobileSender = new MobileSender();

            emailSender.Enviar(alerta);
            mobileSender.Llamar(alerta);
        }
    }

}

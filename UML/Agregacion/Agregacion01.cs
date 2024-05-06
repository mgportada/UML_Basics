
namespace Agregacion01
{
    // Agregación
    public class Rueda
    {
        private readonly string marca;
        private readonly string tipo;
        private readonly decimal diametro;
        private decimal presion;
        private bool pinchada = false;

        public Rueda(string marca, string tipo, decimal diametro, decimal presion)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.diametro = diametro;
            this.presion = presion;
        }
    }

    public class BateriaRecargable
    {
        private readonly string marca;
        private readonly string modelo;
        private readonly int capacidad;
        private int carga;

        public BateriaRecargable(string marca, string modelo, int capacidad)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.capacidad = capacidad;
            this.carga = 0;
        }
    }

    public class Car
    {
        private string matricula;
        private List<Rueda> ruedas;
        private BateriaRecargable bateria;

        public Car(string matricula)
        {
            this.matricula = matricula;
        }

        public void AddRueda(Rueda rueda)
        {
            // check max 4 ruedas
            if (ruedas.Count >= 4)
            {
                throw new Exception("No se pueden añadir más de 4 ruedas.");
            }
            ruedas.Add(rueda);
        }

        public void AddBateria(BateriaRecargable bateria)
        {
            this.bateria = bateria;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("11111AAA");
            Rueda rueda1 = new Rueda("Michelin", "Blanda", 17, 2.2m);
            Rueda rueda2 = new Rueda("Michelin", "Blanda", 17, 2.2m);
            Rueda rueda3 = new Rueda("Michelin", "Blanda", 17, 2.2m);
            Rueda rueda4 = new Rueda("Michelin", "Blanda", 17, 2.2m);

            myCar.AddRueda(rueda1);
            myCar.AddRueda(rueda2);
            myCar.AddRueda(rueda3);
            myCar.AddRueda(rueda4);



            BateriaRecargable bateria = new BateriaRecargable("Tesla", "Model S", 100);
            myCar.AddBateria(bateria);
        }
    }

}

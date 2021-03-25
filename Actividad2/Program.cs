using System;

namespace Actividad2
{


    /*S de Solid*/
    class Coche
    {
        String Marca;
        Coche(String Marca)
        {
            this.Marca = Marca;
        }
        String getMarcaCoche() { return Marca; }
    }

    class CocheBD
    {
        void guardarCocheDB(Coche coche) { 

        }
        void eliminarCocheDB(Coche coche) { 

        }
    }
    /*O de solid*/
    public abstract class Coches
    {
        public abstract int precioMedioCoche();
        /* L de solid*/
        public abstract int numAsientos();
    }
    class Renault1 : Coches
    {
        public override int precioMedioCoche()
        {
            return 18000;
        }
        /* L de solid*/
        public override int numAsientos()
        {
            return 5;
        }
    }


    class Audi : Coches
    {
        public override int precioMedioCoche()
        {
            return 25000;
        }
        /* L de solid*/
        public override int numAsientos()
        {
            return 9;
        }
    }
     class Mercedes : Coches
    {
        public override int precioMedioCoche()
        {
            return 27000;
        }
        /* L de solid*/
        public override int numAsientos()
        {
            return 11;
        }
    }

    interface Iaviones
    {
        public  int precioMedioAvion();
        /* L de solid*/
        public  int numAsientosAvion();
    }

    class Lines : Iaviones
    {
        
        public int precioMedioAvion()
        {
            return 18000000;
        }
        /* L de solid*/
        public int numAsientosAvion()
        {
            return 50;
        }
    }


    class Boeing: Iaviones
    {
        public  int precioMedioAvion()
        {
            return 25000000;
        }
        /* L de solid*/
        public  int numAsientosAvion()
        {
            return 90;
        }
    }
    class Airbus: Iaviones
    {
        public  int precioMedioAvion()
        {
            return 27000000;
        }
        /* L de solid*/
        public  int numAsientosAvion()
        {
            return 110;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Coches[] arrayCoches =
            {
                new Renault1(),
                new Audi(),
                new Mercedes()
            };
            Iaviones[] arrayAviones =
{
                new Boeing(),
                new Airbus(),
                new Lines()
            };

            imprimirPrecioMedioCoche(arrayCoches);
            imprimirNumAsientos(arrayCoches);

            imprimirPrecioMedioAviones(arrayAviones);
            imprimirNumAsientosAvion(arrayAviones);
        }

        static void imprimirPrecioMedioCoche(Coches[] arrayCoches)
        {
            foreach (Coches coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }

        public static void imprimirNumAsientos(Coches[] arrayCoches)
        {
            foreach (Coches coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }
        static void imprimirPrecioMedioAviones(Iaviones[] arrayCoches)
        {
            foreach (Iaviones coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioAvion());
            }
        }

        public static void imprimirNumAsientosAvion(Iaviones[] arrayCoches)
        {
            foreach (Iaviones coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientosAvion());
            }
        }
    }

}

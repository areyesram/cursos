using System;

namespace SequentialCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new Pasos();
            o.AfterPaso1 += () => Console.WriteLine("And then...");
            o.Corre();
        }
    }

    class Pasos
    {
        internal Action AfterPaso1;

        internal void Corre()
        {
            Paso1();
            if (AfterPaso1 != null) AfterPaso1();
            Paso2();
            Paso3();
        }

        void Paso1()
        {
            Console.WriteLine("Paso 1");
        }
        void Paso2()
        {
            Console.WriteLine("Paso 2");
        }
        void Paso3()
        {
            Console.WriteLine("Paso 3");
        }
    }
}

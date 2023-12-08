using System;
using System.Threading;

namespace LogicClock
{
    class Start
    {
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }

        public  Start(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public void Inicio()
        {
            int segundos = 0, minutos = 0, horas = 0;

            while (true)
            {
                if (X == 0)
                {
                    segundos++;
                    if (segundos == 60)
                    {
                        segundos = 0;
                        minutos++;
                        if (minutos == 60)
                        {
                            minutos = 0;
                            horas++;
                        }
                    }
                }

                Console.WriteLine($"Tempo atual: {horas:D2}:{minutos:D2}:{segundos:D2}");

                Thread.Sleep(1000);
            }
        }
    }
}
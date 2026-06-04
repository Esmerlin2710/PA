using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public abstract class Vehiculos
    {

        public string marca = "";
        public string modelo = "";
        public string color = "";
        public bool estado = false;
        public double velocidad;
        public int masa;



        public void Encender()
        {

            estado = true;
            Console.WriteLine("Auto encendido");

        }

        public void Apagar()
        {

            estado = false;
            Console.WriteLine("Auto apagado");
        }

        public abstract void Acelerar(double pedal, double tiempo);
        public abstract void Frenar(double pedal, double tiempo);



    }

    public class Electrico : Vehiculos
    {
        public double bateria = 0;
        public double capacidadBateria = 100;
        public double consumoBateria = 0.03;
        public int fuerzaMax = 7000;
        public int fuerzaFrenoMax = 15000;


        public Electrico(string marca, string modelo, string color, int masa)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.masa = masa;
        }

        public override void Acelerar(double pedal, double tiempo)
        {
            if (!estado)
            {
                Console.WriteLine("El vehículo está apagado");
                return;
            }

            if (bateria <= 0)
            {
                Console.WriteLine("Batería agotada");
                return;
            }

            double consumo = pedal * tiempo * consumoBateria;
            bateria -= consumo;

            if (bateria < 0)
                bateria = 0;

            double aceleracion = (pedal * fuerzaMax) / masa;

            velocidad += aceleracion * tiempo;

            double km = velocidad * 3.6;

            Console.WriteLine($"Velocidad: {km:0.00} Km/h");
            Console.WriteLine($"Batería: {bateria:0.00}%");
        }

        public override void Frenar(double pedalF, double tiempo)
        {
            if (!estado)
            {
                Console.WriteLine("El vehículo está apagado");
                return;
            }
            double fuerza = pedalF * fuerzaFrenoMax;
            double desaceleracion = fuerza / masa;

            velocidad -= desaceleracion * tiempo;

            if (velocidad < 0)
                velocidad = 0;

            RecuperarEnergia(tiempo);
        }

        public void RecuperarEnergia(double tiempoFrenado)
        {
            double energiaRecuperada = tiempoFrenado * 0.1;

            bateria += energiaRecuperada;

            if (bateria > capacidadBateria)
                bateria = capacidadBateria;
        }

        public void RecargarBateria(double carga)
        {
            bateria += carga;

            if (bateria > capacidadBateria)
                bateria = capacidadBateria;

            Console.WriteLine($"Batería actual: {bateria:0.00}%");
        }

        public void MostrarBateria()
        {
            Console.WriteLine($"Nivel de batería: {bateria:0.00}%");
        }

        

        public void MostrarAutonomia()
        {
            double autonomia = bateria * 5;

            Console.WriteLine($"Autonomía estimada: {autonomia:0.00} km");
        }
    }

    public class Motor : Vehiculos
    {
        public int capGasolina = 60;
        public double gasolina;
        public int fuerzaMax = 8000;
        public int fuerzaFrenoMax = 15000;
        public int marchaActual = 0;
        public double consumoBase = 0.05;
        public List<double> relacionesMarcha = new List<double>()
        {
            3.5,
            2.2,
            1.5,
            1.0,
            0.8
        };
        public List<double> velocidadMaximaMarcha = new List<double>()
        {
            11.1,
            19.4,
            30.5,
            44.4,
            61.1
        };

        public Motor(string marca, string modelo, string color, int masa)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.masa = masa;
        }

        

        public override void Acelerar(double pedal, double tiempo)
        {
            if (!estado)
            {
                Console.WriteLine("El auto esta apagado");
                return;
            }
            
            if (gasolina <= 0)
            {
                Console.WriteLine("No tienes gasolina");
                return;
            }

            double consumo = pedal * tiempo * consumoBase;
            gasolina -= consumo;

            if (gasolina < 0)
            {
                gasolina = 0;
                Console.WriteLine("No hay gasolina");
                return;
            }
            double relacionActual = relacionesMarcha[marchaActual];
            double fFinal = (pedal * fuerzaMax) * relacionActual;

            double aceleracion = fFinal / masa;

            velocidad += aceleracion * tiempo;

            if (velocidad > velocidadMaximaMarcha[marchaActual])
            {
                velocidad = velocidadMaximaMarcha[marchaActual];
            }

            double km = velocidad * 3.6;
            Console.WriteLine("La velocidad que andas es: " + km.ToString("0.00") + " Km/h");
            Console.WriteLine("Nivel de gasolina: " + gasolina.ToString("0.00"));
        }

        public void subirMarcha()
        {
            if(marchaActual < 4)
            {
                marchaActual++;
            } else
            {
                Console.WriteLine("No hay mas marchas");
            }
                
        }

        public void bajarMarcha()
        {
            if (marchaActual > 0)
            {
                marchaActual--;
            } else
            {
                Console.WriteLine("No hay mas marchas");
            }
        }

        public override  tvoid Frenar(double pedalF, double tiempo)
        {
            if(estado != false)
            {
                double f = pedalF * fuerzaFrenoMax;
                double frenar = f / masa;
                velocidad = velocidad - (frenar * tiempo);

                if (velocidad < 0)
                {
                    velocidad = 0;
                }
            } else
            {
                Console.WriteLine("El auto esta apagado");
            }
            double km = velocidad * 3.6;
            Console.WriteLine("La velocidad que andas es: " + km.ToString("0.00") + " Km/h");

        }

        public void recargarGasolina(int gaso)
        {
            if (gaso <= capGasolina)
            {
                gasolina += gaso;
                if (gasolina > capGasolina)
                {
                    gasolina = capGasolina;
                }
                
            } else
            {
                Console.WriteLine("No puedes hechar mas de la capacidad");
            }
            
        }
        

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Motor auto1 = new Motor("Bugatti", "Veyron", "Azul", 8000);
        }
    }
}
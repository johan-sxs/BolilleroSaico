using System;
using System.Collections.Generic;

namespace Bolillero.Core
{
    public class Bolillero
    {
byte Cantidad {get;set;}

byte BolilleroAzar {get;set;}

List<byte> Afuera {get;set;}

List<byte> Adentro{get;set;}

Random r;
 
 public Bolillero()
 {
     List<byte> Afuera = new List<byte>();
     List<byte> Dentro = new List<byte>();
     Random r = new Random();
 }
       public Bolillero(byte cantidad) : this() => this.Llenar(cantidad);
        private void Llenar (byte cantidad)
        {
            for(byte i=0; i < cantidad; i++)
            {
                Adentro.Add(i);
            }
        }
        public byte SacarBolilla()
        {
           byte indiceBolilleroAzar = (byte)r.Next(0, Adentro.Count);

            byte bolilla = Adentro [indiceBolilleroAzar];

            Adentro.RemoveAt(indiceBolilleroAzar);

            Afuera.Add(bolilla);

            return bolilla;
        }
         public void RellenarBolillero()
        {
            Adentro.AddRange(Afuera);

            Afuera.Clear();
        }

        public bool Jugar (List<byte> jugada)
        {
            RellenarBolillero(); 
            for(byte i=0; i < jugada.Count; i++)
            {
                if (SacarBolilla() != jugada[i] )
                {
                    return false;
                }
            }
                return true; 
        } 

        public long jugarNVeces (List<byte> jugada, long cantidad )
        {
            long contador = 0; 

            for(long i=0; i < cantidad ; i++ )
            {
                if (Jugar(jugada))
                {
                    contador++ ;
                }
            }

            return contador;
        }
    }  
}
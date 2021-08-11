using System;
using System.Collections.Generic;



namespace Bolillero.Core
{
    public class Bolillero
    {
byte Cantidad {get;set;}

byte Bolillalazar {get;set;}

List<byte> Afuera {get;set;}

List<byte> Dentro{get;set;}
Random N;
 
 public Bolillero()
 {
     List<byte> Afuera = new List<byte>();
     List<byte> Dentro = new List<byte>();
     Random N = new Random();
 }
 public Bolillero(byte Cantidad)
 {
  this.(this.Cantidad);
    } 
}
}
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
namespace milibreria{

}
  class transporte{
     public int matricula;
     public string color;

     public int capacidad;
     public void arrancar(){
        Console.WriteLine("arrancando...");
        
     }
     public  virtual void mover()

     {
        Console.WriteLine("se mueve");
     }
     public void detenerse (){
        Console.WriteLine("deteniendose...");
     }

}
class avion : transporte{
    public string piloto;
    public string color;
    public string marca;
    public int matricula;
    public int capacidad;


        
    public void Volar()
    {
        Console.WriteLine("volando");
    }
    public void aterizar()
    {
        Console.WriteLine("aterizando");
    }
    public void despegar()
    {
        Console.WriteLine("despegando");
    }


     public override void mover()
    {
        Console.WriteLine("moviendo el avion");
    }
}
class auto : transporte 
{
    public bool VTV;
    public int tgnro;
    public void cambioaceite()
   {
    Console.WriteLine("realizar un cambio de aceite");
    }

    public override void mover()
    {
        Console.WriteLine("moviendo el auto");
    }
}

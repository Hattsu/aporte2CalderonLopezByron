public class Parlante: Decorador{

    public Parlante(OrdenBase ordenBase):base(ordenBase){ }

    public override string extension(){
        var teclado = orden.extension();
        Console.WriteLine("Has agregado el parlante adicional");
      return teclado;
    }
}
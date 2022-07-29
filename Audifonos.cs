public class Audifonos: Decorador{
    
    public Audifonos(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string extension(){
        var teclado = orden.extension();
        Console.WriteLine("Has agregado el audifono adicional");
      return teclado;
    }
}
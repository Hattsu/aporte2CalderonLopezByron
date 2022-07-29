public class Cargador: Decorador{
    
    public Cargador(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string extension(){
        var teclado = orden.extension();
        Console.WriteLine("Has agregado el cargador adicional");
      return teclado;
    }
}
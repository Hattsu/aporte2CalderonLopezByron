public class Cargador: Decorador{
    
    public Cargador(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string software(){
        var teclado = "Has agregado el cargador adicional";
      return teclado;
    }
}
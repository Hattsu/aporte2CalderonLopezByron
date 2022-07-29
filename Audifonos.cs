public class Audifonos: Decorador{
    
    public Audifonos(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string software(){
        var teclado = "Has agregado el audifono adicional";
        return teclado;
    }
}
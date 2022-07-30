public class Audifonos: Decorador{
    
    public Audifonos(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string hardware(){
        var hardware1 = "El hardware llamado AUDIFONOS se ha agregado";
        return hardware1;
    }
}
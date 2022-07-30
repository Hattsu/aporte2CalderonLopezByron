public class Cargador: Decorador{
    
    public Cargador(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string hardware(){
        var hardware2 = "El hardware llamado CARGADOR se ha agregado";
        return hardware2;
    }
}
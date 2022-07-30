public class Parlante: Decorador{

    public Parlante(OrdenBase ordenBase):base(ordenBase){ }

    public override string hardware(){
        var teclado = "El hardware llamado PARLANTE se ha agregado";
        return teclado;
    }
}
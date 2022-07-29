public class PantallaRota: Decorador{

    public PantallaRota(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparacion(){
        var repacion = "Has Elegido arreglar tu pantalla rota";
          return repacion;
    }
}
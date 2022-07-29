public class Agua: Decorador{

    public Agua(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparacion(){
        var repacion = "Has Elegido arreglar tu telefono que se le metio agua";
          return repacion;
    }
}
public class Agua: Decorador{

    public Agua(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparacion(){
        var repacion = "la reparacion de tu telefono que se le metio agua se completo..";
          return repacion;
    }
}
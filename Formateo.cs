public class Formateo: Decorador{

    public Formateo(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparacion(){
        var repacion = "Has agregado el formateo para tu celular";
          return repacion;
    }
}
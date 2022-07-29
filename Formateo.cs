public class Formateo: Decorador{

    public Formateo(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparacion(){
        var repacion = "El formateo para tu celular esta completo..";
          return repacion;
    }
}
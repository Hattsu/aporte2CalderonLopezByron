public class PantallaRota: Decorador{

    public PantallaRota(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparacion(){
        var repacion = "el arreglo de tu pantalla rota esta completo..";
          return repacion;
    }
}
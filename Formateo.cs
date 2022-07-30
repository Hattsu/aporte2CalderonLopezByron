public class Formateo: Decorador{

    public Formateo(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparar_dispositivo(){
        var reparar = "Reparando por formateo del dispositivo... completo";
          return reparar;
    }
}
public class Agua: Decorador{

    public Agua(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparar_dispositivo(){
        var reparar = "Reparando por daños de agua del dispositivo... completo";
          return reparar;
    }
}
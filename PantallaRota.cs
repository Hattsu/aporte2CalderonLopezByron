public class PantallaRota: Decorador{

    public PantallaRota(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string reparar_dispositivo(){
        var reparar = "Reparando pantalla rota del dispositivo... completo";
          return reparar;
    }
}
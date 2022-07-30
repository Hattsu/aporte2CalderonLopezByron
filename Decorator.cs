using System;
public class Decorador{
    protected OrdenBase orden;

    public Decorador(OrdenBase orden)
    {
        this.orden= orden;
    }
    public virtual string hardware(){
      return orden.hardware();
    }
    public virtual string reparar_dispositivo(){
      return orden.reparar_dispositivo();
    }
}
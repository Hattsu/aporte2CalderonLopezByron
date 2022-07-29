using System;
public class Decorador{
    protected OrdenBase orden;

    public Decorador(OrdenBase orden)
    {
        this.orden= orden;
    }
    public virtual string extension(){
      return orden.extension();
    }
    public virtual string reparacion(){
      return orden.extension();
    }
}
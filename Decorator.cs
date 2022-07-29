using System;
public class Decorador{
    protected OrdenBase orden;

    public Decorador(OrdenBase orden)
    {
        this.orden= orden;
    }
    public virtual string software(){
      return orden.software();
    }
    public virtual string reparacion(){
      return orden.reparacion();
    }
}
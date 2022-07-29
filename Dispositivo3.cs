public class Dispositivo3:OrdenBase
    {
    public override string reparacion(){
    var repa = "Has reparado tu telefono";
    return repa;
    }
   public override string extension(){
    var repa = "Desea agregar una extencion?";
    return repa;
    }
}
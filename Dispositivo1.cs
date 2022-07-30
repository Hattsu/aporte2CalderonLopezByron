public class Dispositivo1:OrdenBase
    {
    public override string reparar_dispositivo(){
        var repararDi = "El dispositivo 1 entrara en reparación";
        return repararDi;
    }
   public override string hardware(){
        var repararDi = "Agregando un hardware adicional al dispositivo 1";
        return repararDi;
    }
}
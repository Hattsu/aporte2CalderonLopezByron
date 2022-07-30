public class Dispositivo2:OrdenBase
    {
    public override string reparar_dispositivo(){
        var repararDi = "El dispositivo 2 entrara en reparación";
        return repararDi;
    }
   public override string hardware(){
        var repararDi = "Agregando un hardware adicional al dispositivo 2";
        return repararDi;
    }
}
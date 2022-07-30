class Program
{


    public static void Main(String[] args)
    {

        //celular #1
        Console.WriteLine("------------------------------------------");
        var celular1 = new Dispositivo1();
        Console.WriteLine(celular1.reparar_dispositivo());

        var reparacion1 = new PantallaRota(celular1);
        Console.WriteLine(reparacion1.reparar_dispositivo());

        var reparacion2 = new Agua(celular1);
        Console.WriteLine(reparacion2.reparar_dispositivo());

        var reparacion3 = new Formateo(celular1);
        Console.WriteLine(reparacion3.reparar_dispositivo());

        Console.WriteLine(celular1.hardware());

        var cargador = new Cargador(celular1);
        Console.WriteLine(cargador.hardware());
        Console.WriteLine("------------------------------------------");




        //celular #2
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        var celular2 = new Dispositivo2();
        Console.WriteLine(celular2.reparar_dispositivo());

        var reparacion4 = new Agua(celular2);
        Console.WriteLine(reparacion4.reparar_dispositivo());

        var reparacion5 = new Formateo(celular2);
        Console.WriteLine(reparacion5.reparar_dispositivo());

        var reparacion6 = new PantallaRota(celular2);
        Console.WriteLine(reparacion6.reparar_dispositivo());

        Console.WriteLine(celular2.hardware());

        var parlante2 = new Parlante(celular2);
        Console.WriteLine(parlante2.hardware());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");


        //celular 3
        var celular3 = new Dispositivo3();
        Console.WriteLine(celular3.reparar_dispositivo());

        var reparacion7 = new Agua(celular3);
        Console.WriteLine(reparacion7.reparar_dispositivo());

        var reparacion8 = new Formateo(celular3);
        Console.WriteLine(reparacion8.reparar_dispositivo());

        var reparacion9 = new PantallaRota(celular3);
        Console.WriteLine(reparacion9.reparar_dispositivo());

        Console.WriteLine(celular3.hardware());

        var audifonos3 = new Audifonos(celular3);
        Console.WriteLine(audifonos3.hardware());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
    }
}
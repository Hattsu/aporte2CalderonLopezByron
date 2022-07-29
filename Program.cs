class Program
{


    public static void Main(String[] args)
    {

        //telefono #1
        Console.WriteLine("------------------------------------------");
        var telefono = new Dispositivo1();
        Console.WriteLine(telefono.reparacion());

        var reparacion = new PantallaRota(telefono);
        Console.WriteLine(reparacion.reparacion());

        var reparacion2 = new Agua(telefono);
        Console.WriteLine(reparacion2.reparacion());

        var reparacion3 = new Formateo(telefono);
        Console.WriteLine(reparacion3.reparacion());

        Console.WriteLine(telefono.software());

        var cargador = new Cargador(telefono);
        Console.WriteLine(cargador.software());
        Console.WriteLine("------------------------------------------");




        //telefono 2
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        var telefono2 = new Dispositivo2();
        Console.WriteLine(telefono2.reparacion());

        var reparacion4 = new Agua(telefono2);
        Console.WriteLine(reparacion4.reparacion());

        var reparacion5 = new Formateo(telefono2);
        Console.WriteLine(reparacion5.reparacion());

        var reparacion6 = new PantallaRota(telefono);
        Console.WriteLine(reparacion6.reparacion());

        Console.WriteLine(telefono2.software());

        var parlante2 = new Parlante(telefono2);
        Console.WriteLine(parlante2.software());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");


        //telefono 3
        var telefono3 = new Dispositivo3();
        Console.WriteLine(telefono3.reparacion());

        var reparacion7 = new Agua(telefono3);
        Console.WriteLine(reparacion7.reparacion());

        var reparacion8 = new Formateo(telefono3);
        Console.WriteLine(reparacion8.reparacion());

        var reparacion9 = new PantallaRota(telefono3);
        Console.WriteLine(reparacion9.reparacion());

        Console.WriteLine(telefono3.software());

        var audifonos3 = new Audifonos(telefono3);
        Console.WriteLine(audifonos3.software());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
    }
}
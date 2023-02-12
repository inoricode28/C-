using System;

namespace SignoZodiacal
{
    class SignoZodiacal
    {
        static void Main(string[] args)
        {
            int dia, mes;
            Console.Write("Ingresa el valor de dia: ");
            dia = int.Parse(System.Console.ReadLine());
            Console.Write("Ingresa el valor de mes: ");
            mes = int.Parse(System.Console.ReadLine());
            if((dia>=21&&mes==3)||(dia<=20&&mes==4))
                Console.WriteLine("Aries");
            if((dia>=24&&mes==9)||(dia<=23&&mes==10))
                Console.WriteLine("Libra");
            if((dia>=21&&mes==4)||(dia<=21&&mes==5))
                Console.WriteLine("Tauro");
            if((dia>=24&&mes==10)||(dia<=22&&mes==11))
                Console.WriteLine("Escorpio");
            if((dia>=22&&mes==5)||(dia<=21&&mes==6))
                Console.WriteLine("G\u00E9minis");
            if((dia>=23&&mes==11)||(dia<=21&&mes==12))
                Console.WriteLine("Sagitario");
            if((dia>=21&&mes==6)||(dia<=23&&mes==7))
                Console.WriteLine("C\u00E1ncer");
            if((dia>=22&&mes==12)||(dia<=20&&mes==1))
                Console.WriteLine("Capricornio");
            if((dia>=24&&mes==7)||(dia<=23&&mes==8))
                Console.WriteLine("Leo");
            if((dia>=21&&mes==1)||(dia<=19&&mes==2))
                Console.WriteLine("Acuario");
            if((dia>=24&&mes==8)||(dia<=23&&mes==9))
                Console.WriteLine("Virgo");
            if((dia>=20&&mes==2)||(dia<=20&&mes==3))
                Console.WriteLine("Piscis");
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}

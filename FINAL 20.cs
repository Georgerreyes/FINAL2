using System;

namespace Proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre1;
            String nombre2;
            String nombre3;
            String nombre4;
            String nombre5;

            int cantidad1;
            int cantidad2;
            int cantidad3;
            int cantidad4;
            int cantidad5;

            Console.WriteLine("ESCRIBIR EL NOMBRE DE 5 DE LOS EMPLEADOS!");

            Console.WriteLine("ESCRIBE EL NOMBRE DEL PRIMER EMPLEADO");
            nombre1 = Console.ReadLine();
            Console.WriteLine("ESCRIBE EL NOMBRE DEL SEGUNDO EMPLEADO");
            nombre2 = Console.ReadLine();
            Console.WriteLine("ESCRIBE EL NOMBRE DEL TERCER EMPLEADO");
            nombre3 = Console.ReadLine();
            Console.WriteLine("ESCRIBE EL NOMBRE DEL CUARTO EMPLEADO");
            nombre4 = Console.ReadLine();
            Console.WriteLine("ESCRIBE EL NOMBRE DEL QUINTO EMPLEADO");
            nombre5 = Console.ReadLine();


            Console.WriteLine("El primer empleado es :" + nombre1);
            Console.WriteLine("El segundo empleado es :" + nombre2);
            Console.WriteLine("El tercero empleado es :" + nombre3);
            Console.WriteLine("El cuarto empleado es :" + nombre4);
            Console.WriteLine("El quinto empleado es :" + nombre5);


            Console.WriteLine("INCRESE EL SUELDO DE CADA EMPLEADO:");

            Console.WriteLine("1-" + nombre1);
            cantidad1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2-" + nombre2);
            cantidad2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3-" + nombre3);
            cantidad3 = int.Parse(Console.ReadLine());
            Console.WriteLine("4-" + nombre4);
            cantidad4 = int.Parse(Console.ReadLine());
            Console.WriteLine("5-" + nombre5);
            cantidad5 = int.Parse(Console.ReadLine());

            Console.WriteLine("LOS EMPLEADOS CON SU SUELDO DE TRES MESES ES:");


            Console.WriteLine("1-" + nombre1 + "----------" + cantidad1 * 3);
            Console.WriteLine("2-" + nombre2 + "----------" + cantidad2 * 3);
            Console.WriteLine("3-" + nombre3 + "----------" + cantidad3 * 3);
            Console.WriteLine("4-" + nombre4 + "----------" + cantidad4 * 3);
            Console.WriteLine("5-" + nombre5 + "-----------" + cantidad5 * 3);






            if (cantidad1 > cantidad2)
            {

                if (cantidad1 > cantidad3)
                {

                    if (cantidad1 >cantidad4) 
                    {

                        if (cantidad1 > cantidad5)
                        {
                            Console.WriteLine("EL EMPLEADO CON EL SUELDO MAS ALTO ES: " + nombre1+ "CON EL SUELDO DE:" + cantidad1*3);


                        }

                    }
                
                
                }

            
            
            }



            if (cantidad2 > cantidad1)
            {

                if (cantidad2 > cantidad3)
                {

                    if (cantidad2 > cantidad4)
                    {

                        if (cantidad2> cantidad5)
                        {
                            Console.WriteLine("EL EMPLEADO CON EL SUELDO MAS ALTO ES: " + nombre2 + "CON EL SUELDO DE:" + cantidad2 * 3);


                        }

                    }


                }



            }





            if (cantidad3 > cantidad2)
            {

                if (cantidad3 > cantidad1)
                {

                    if (cantidad3 > cantidad4)
                    {

                        if (cantidad3 > cantidad5)
                        {
                            Console.WriteLine("EL EMPLEADO CON EL SUELDO MAS ALTO ES: " + nombre3 + "CON EL SUELDO DE:" + cantidad3 * 3);


                        }

                    }


                }



            }







            if (cantidad4 > cantidad2)
            {

                if (cantidad4 > cantidad3)
                {

                    if (cantidad4 > cantidad1)
                    {

                        if (cantidad4 > cantidad5)
                        {
                            Console.WriteLine("EL EMPLEADO CON EL SUELDO MAS ALTO ES: " + nombre4 + "CON EL SUELDO DE:" + cantidad4* 3);


                        }

                    }


                }



            }










            if (cantidad5 > cantidad2)
            {

                if (cantidad5 > cantidad3)
                {

                    if (cantidad5 > cantidad4)
                    {

                        if (cantidad5 > cantidad1)
                        {
                            Console.WriteLine("EL EMPLEADO CON EL SUELDO MAS ALTO ES: " + nombre5 + "CON EL SUELDO DE:e" + cantidad5 * 3);


                        }

                    }


                }



            }


            Console.ReadKey();
        }
    }
}

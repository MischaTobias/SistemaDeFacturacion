using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 string A1, B1, C1, E1, F1, A2, B2, C2, E2, AF2, nomprod1, nomprod2, nomprod3, nomprod4, nomprod5;
                 int G1, ffdia, ffmes, ffanio, fedia, femes, feanio, cprod1, cprod2, cprod3, cprod4, cprod5, nprod;
                 double D1, valprod1, valprod2, valprod3, valprod4, valprod5, vtprod1, vtprod2, vtprod3, vtprod4, vtprod5, vta;

                //Console.ReadLine() asigna variables.
                //Convert.toInt() hace que el valor string se convierta en int para que el sistema pueda trabajar aritméticamente con ese dato.
                //Las condiciones if() se utilizarán para validar diferentes datos como las fechas.


                //En este momento se solicitará al usuario que ingrese los datos de la factura.

                Console.WriteLine("Bienvenido, por favor ingrese los siguientes datos para la factura:");
                Console.WriteLine(" ");
                Console.WriteLine("Por favor ingrese la serie de factura: ");
                A1 = Console.ReadLine();
                Console.WriteLine("Por favor ingrese el número de factura: ");
                B1 = (Console.ReadLine());
                Console.WriteLine("Por favor ingrese el período de vigencia de la factura: ");
                C1 = Console.ReadLine();
                Console.WriteLine("Por favor ingrese el régimen de ISR: ");
                D1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Si su forma de pago es efectivo, ingrese E; si es a plazos, ingrese P");
                E1 = Console.ReadLine();
                Console.WriteLine("Si la factura está cancelada, ingrese C; si está pendiente, ingrese P");
                F1 = Console.ReadLine();
                Console.WriteLine("Si la forma de entrega es en mostrador, ingrese 1; si es a domicilio, ingrese 2.");
                G1 = Convert.ToInt16(Console.ReadLine());

                C2 = "";
                E2 = "";
                cprod1 = 0;
                cprod2 = 0;
                cprod3 = 0;
                cprod4 = 0;
                cprod5 = 0;

                nomprod1 = "";
                nomprod2 = "";
                nomprod3 = "";
                nomprod4 = "";
                nomprod5 = "";

                valprod1 = 0;
                valprod2 = 0;
                valprod3 = 0;
                valprod4 = 0;
                valprod5 = 0;

                vtprod1 = 0;
                vtprod2 = 0;
                vtprod3 = 0;
                vtprod4 = 0;
                vtprod5 = 0;

                vta = 0;
                AF2 = "";

                //En este momento se le solicitará al usuario los siguientes datos de facturación.
                Console.WriteLine("Por favor ingrese los siguientes datos de facturación:");
                Console.WriteLine("Por favor ingrese el NIT.");
                //En este momento se asigna un valor a la variable; en caso de que el usuario no ingrese un nit, este quedará como C/F.
                A2 = Console.ReadLine();
                if (A2 == "")
                {
                    A2 = "C/F";
                }
                else
                {

                }
                if (A2 != "C/F")
                {
                    C2 = "";
                    Console.WriteLine("Si es una persona individual, ingrese P; si es una empresa, ingrese E");
                    B2 = Console.ReadLine();

                    if (B2 == "P")
                    {
                        Console.WriteLine("Por favor ingrese Nombre y Apellido: ");
                        C2 = Console.ReadLine();
                    }
                    else if (B2 == "E")
                    {
                        Console.WriteLine("Por favor ingrese el nombre de la empresa: ");
                        C2 = Console.ReadLine();
                    }
                }
                else
                {

                }

                Console.WriteLine("Por favor ingrese el día del mes de facturación");
                ffdia = Convert.ToInt16(Console.ReadLine());
                if (ffdia > 0)
                {
                    if (ffdia < 31)
                    {
                        Console.WriteLine("Por favor ingrese el mes de facturación: ");
                        ffmes = Convert.ToInt16(Console.ReadLine());
                        if (ffmes > 0)
                        {
                            if (ffmes < 13)
                            {
                                Console.WriteLine("Por favor ingrese el año de facturación: ");
                                ffanio = Convert.ToInt16(Console.ReadLine());
                                if (ffanio > 0)
                                {
                                    Console.WriteLine("Por favor ingrese la dirección de facturación: ");
                                    E2 = Console.ReadLine();
                                    if (E2 == "")
                                    {
                                        //Si el usuario no ingresa un dato, se tendrá la dirección de facturación predeterminada como Ciudad.
                                        E2 = "Ciudad";
                                    }
                                    else
                                    {

                                    }
                                    if (G1 == 2)
                                    {
                                        //En este momento se validará la fecha de entrega.
                                        Console.WriteLine("Por favor ingrese la dirección de entrega: ");
                                        AF2 = Console.ReadLine();
                                        Console.WriteLine("Por favor ingrese el año de entrega: ");
                                        feanio = Convert.ToInt16(Console.ReadLine());
                                        if (feanio == ffanio)
                                        {
                                            Console.WriteLine("Por favor ingrese el mes de entrega: ");
                                            femes = Convert.ToInt16(Console.ReadLine());
                                            if (femes == ffmes)
                                            {
                                                Console.WriteLine("Por favor ingrese el día de entrega: ");
                                                fedia = Convert.ToInt16(Console.ReadLine());
                                                if (fedia > ffdia)
                                                {

                                                }
                                                else
                                                {
                                                    //En este momento se cierra el programa en caso de que el usuario ingrese una fecha inválida de entrega.
                                                    Console.WriteLine("El programa se cerrará por que la fecha ingresada es inválida.");
                                                    Console.ReadLine();
                                                    Environment.Exit(0);
                                                }
                                            }
                                            else if (femes > ffmes)
                                            {
                                                Console.WriteLine("Por favor ingrese el día de entrega: ");
                                                fedia = Convert.ToInt16(Console.ReadLine());
                                            }
                                        }
                                        else if (feanio > ffanio)
                                        {
                                            Console.WriteLine("Por favor ingrese el mes de entrega: ");
                                            femes = Convert.ToInt16(Console.ReadLine());
                                            Console.WriteLine("Por favor ingrese el día de entrega: ");
                                            fedia = Convert.ToInt16(Console.ReadLine());
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {

                                    }

                                    System.Console.Clear();
                                    /*En este momento se preguntará al usuario datos sobre los productos que el usuario quiera agregar con un
                                     máximo de 5 productos.*/
                                    Console.WriteLine("Por favor ingrese el nombre del producto 1: ");
                                    nomprod1 = Console.ReadLine();
                                    Console.WriteLine("Por favor ingrese la cantidad de producto 1: ");
                                    cprod1 = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Por favor ingrese el precio unitario (En quetzales) del producto: ");
                                    valprod1 = Convert.ToDouble(Console.ReadLine());
                                    vtprod1 = valprod1 * cprod1;
                                    vta = vtprod1;
                                    if (cprod1 > 0)
                                    {
                                        if (valprod1 > 0)
                                        {
                                            Console.WriteLine("El valor total por producto es: Q" + vtprod1);
                                            Console.WriteLine("El valor total acumulado es: Q" + vta);
                                            Console.WriteLine("");

                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {

                                    }


                                    Console.WriteLine("¿Desea agregar otro producto?");
                                    Console.WriteLine("Si la respuesta es sí, ingrese 1; si la respuesta es no, ingrese 2");
                                    nprod = Convert.ToInt16(Console.ReadLine());
                                    switch (nprod)
                                    {
                                        case 1:
                                            System.Console.Clear();
                                            Console.WriteLine("Por favor ingrese el nombre del producto 2: ");
                                            nomprod2 = Console.ReadLine();
                                            if(nomprod2 != nomprod1)
                                            {
                                                 Console.WriteLine("Por favor ingrese la cantidad de producto 2: ");
                                                cprod2 = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine("Por favor ingrese el precio unitario (En quetzales) del producto 2: ");
                                                valprod2 = Convert.ToDouble(Console.ReadLine());
                                                vtprod2 = valprod2 * cprod2;
                                                vta = vta + vtprod2;
                                                if (cprod2 > 0)
                                                {
                                                    if (valprod2 > 0)
                                                    {
                                                        Console.WriteLine("El valor total por producto es: Q" + vtprod2);
                                                        Console.WriteLine("El valor total acumulado es: Q" + vta);
                                                        Console.WriteLine("");

                                                        Console.WriteLine("¿Desea agregar otro producto?");
                                                        Console.WriteLine("Si la respuesta es sí, ingrese 1; si la respuesta es no, ingrese 2");
                                                        nprod = Convert.ToInt16(Console.ReadLine());
                                                        switch (nprod)
                                                        {
                                                            case 1:
                                                                System.Console.Clear();
                                                                Console.WriteLine("Por favor ingrese el nombre del producto 3: ");
                                                                nomprod3 = Console.ReadLine();
                                                                if((nomprod3 != nomprod1) && (nomprod3 != nomprod2))
                                                                {
                                                                    Console.WriteLine("Por favor ingrese la cantidad de producto 3: ");
                                                                    cprod3 = Convert.ToInt32(Console.ReadLine());
                                                                    Console.WriteLine("Por favor ingrese el precio unitario (En quetzales) del producto 3: ");
                                                                    valprod3 = Convert.ToDouble(Console.ReadLine());
                                                                    vtprod3 = valprod3 * cprod3;
                                                                    vta = vta + vtprod3;
                                                                    if (cprod3 > 0)
                                                                    {
                                                                        if (valprod3 > 0)
                                                                        {
                                                                            Console.WriteLine("El valor total por producto es: Q" + vtprod3);
                                                                            Console.WriteLine("El valor total acumulado es: Q" + vta);
                                                                            Console.WriteLine("");

                                                                            Console.WriteLine("¿Desea agregar otro producto?");
                                                                            Console.WriteLine("Si la respuesta es sí, ingrese 1; si la respuesta es no, ingrese 2");
                                                                            nprod = Convert.ToInt16(Console.ReadLine());
                                                                            switch (nprod)
                                                                            {
                                                                                case 1:
                                                                                    System.Console.Clear();
                                                                                    Console.WriteLine("Por favor ingrese el nombre del producto 4: ");
                                                                                    nomprod4 = Console.ReadLine();
                                                                                    if((nomprod4 != nomprod1) && (nomprod4 != nomprod2) && (nomprod4 != nomprod3))
                                                                                    {
                                                                                        Console.WriteLine("Por favor ingrese la cantidad de producto 4: ");
                                                                                        cprod4 = Convert.ToInt32(Console.ReadLine());
                                                                                        Console.WriteLine("Por favor ingrese el precio unitario (En quetzales) del producto 4: ");
                                                                                        valprod4 = Convert.ToDouble(Console.ReadLine());
                                                                                        vtprod4 = valprod4 * cprod4;
                                                                                        vta = vta + vtprod4;
                                                                                        if (cprod4 > 0)
                                                                                        {
                                                                                            if (valprod4 > 0)
                                                                                            {
                                                                                                Console.WriteLine("El valor total por producto es: Q" + vtprod4);
                                                                                                Console.WriteLine("El valor total acumulado es: Q" + vta);
                                                                                                Console.WriteLine("");

                                                                                                Console.WriteLine("¿Desea agregar otro producto?");
                                                                                                Console.WriteLine("Si la respuesta es sí, ingrese 1; si la respuesta es no, ingrese 2");
                                                                                                nprod = Convert.ToInt16(Console.ReadLine());
                                                                                                switch (nprod)
                                                                                                {
                                                                                                    case 1:
                                                                                                        System.Console.Clear();
                                                                                                        Console.WriteLine("Por favor ingrese el nombre del producto 5: ");
                                                                                                        nomprod5 = Console.ReadLine();
                                                                                                        if((nomprod5 != nomprod1) && (nomprod5 != nomprod2) && (nomprod5 != nomprod3) && (nomprod5 != nomprod4))
                                                                                                        {
                                                                                                            Console.WriteLine("Por favor ingrese la cantidad de producto 5: ");
                                                                                                            cprod5 = Convert.ToInt32(Console.ReadLine());
                                                                                                            Console.WriteLine("Por favor ingrese el precio unitario (En quetzales) del producto 5: ");
                                                                                                            valprod5 = Convert.ToDouble(Console.ReadLine());
                                                                                                            vtprod5 = valprod5 * cprod5;
                                                                                                            vta = vta + vtprod5;
                                                                                                            if (cprod5 > 0)
                                                                                                            {
                                                                                                                if (valprod5 > 0)
                                                                                                                {
                                                                                                                    Console.WriteLine("El valor total por producto es: Q" + vtprod5);
                                                                                                                    Console.WriteLine("El valor total acumulado es: Q" + vta);
                                                                                                                    Console.WriteLine("");

                                                                                                                }
                                                                                                                else
                                                                                                                {

                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {

                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                             System.Console.Clear();
                                                                                                             Console.WriteLine("Debe de ingresar nombres de productos que sean diferentes.");
                                                                                                             Console.ReadKey();
                                                                                                             Environment.Exit(0);
                                                                                                        }

                                                                                                        break;
                                                                                                    case 2: break;

                                                                                                    default: break;
                                                                                                }

                                                                                            }
                                                                                            else
                                                                                            {

                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {

                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                         System.Console.Clear();
                                                                                         Console.WriteLine("Debe de ingresar nombres de productos que sean diferentes.");
                                                                                         Console.ReadKey();
                                                                                         Environment.Exit(0);
                                                                                    }
                                                                                
                                                                                    break;
                                                                                case 2: break;

                                                                                default: break;
                                                                            }

                                                                        }
                                                                        else
                                                                        {

                                                                        }
                                                                    }
                                                                    else
                                                                    {

                                                                    }
                                                                }
                                                                else
                                                                {
                                                                     System.Console.Clear();
                                                                     Console.WriteLine("Debe de ingresar nombres de productos que sean diferentes.");
                                                                     Console.ReadKey();
                                                                     Environment.Exit(0);
                                                                }   
                                                            
                                                                break;
                                                            case 2: break;

                                                            default: break;
                                                        }



                                                    }
                                                    else
                                                    {

                                                    }
                                                }
                                                else
                                                {

                                                }
                                            }
                                            else
                                            {
                                                System.Console.Clear();
                                                Console.WriteLine("Debe de ingresar nombres de productos que sean diferentes.");
                                                Console.ReadKey();
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 2: break;

                                        default: break;
                                    }

                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }

                    }
                    else
                    {

                    }
                }
                else
                {

                }
                System.Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("                            Trabajos Informáticos, S.A.                             ");
                Console.WriteLine("                                                     Factura Serie: " + A1 + "  No. " + B1);
                Console.WriteLine("                                                                       Regimen: " + C1);
                Console.WriteLine("                                                                   Vigencia: " + D1);
                Console.WriteLine("                                                                                     ");
                Console.WriteLine("Fecha: " + Convert.ToString(ffdia) + "/");
                Console.WriteLine("Nombre: " + Convert.ToString(C2));
                Console.WriteLine("Dirección: " + E1 + " | NIT: " + A2);
                Console.WriteLine("Forma de Pago: " + E2);
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("Cantidad          | Descripcción         | Valor Unitario           | Valor Total   ");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine(cprod1 + "                | " + nomprod1 + "            | " + valprod1 + "                 | " + vtprod1 + "         ");
                Console.WriteLine(cprod2 + "                | " + nomprod2 + "            | " + valprod2 + "                 | " + vtprod2 + "         ");
                Console.WriteLine(cprod3 + "                | " + nomprod3 + "            | " + valprod3 + "                 | " + vtprod3 + "         ");
                Console.WriteLine(cprod4 + "                | " + nomprod4 + "            | " + valprod4 + "                 | " + vtprod4 + "         ");
                Console.WriteLine(cprod5 + "                | " + nomprod5 + "            | " + valprod5 + "                 | " + vtprod5 + "         ");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("Total:" + vta);
                Console.WriteLine("Forma de Entrega:" + G1);
                Console.WriteLine("Dirección de entregas:" + AF2);
                Console.ReadKey();

            }
            catch
            {
                System.Console.Clear();
                Console.WriteLine("Debe ingresar datos válidos para la factura, el programa se cerrará.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

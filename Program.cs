using System;
namespace CalculoDeSalario
{
    class SalarioNeto
    {
        static void Main(string[] args)
        {
            double horas, impuestos, precio_hora, salario_bruto, salario_neto;
            string nombre;
            Console.WriteLine("Ingresar nombre del empleado:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresar las horas trabajadas");
            horas = double.Parse(Console.ReadLine());
            Console.Write("Ingresar precio de horas trabajadas");
            precio_hora = double.Parse(Console.ReadLine());
            salario_bruto = precio_hora * horas;
            impuestos = 0.20 * salario_bruto;
            salario_neto = salario_bruto - impuestos;

            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Valor de salario bruto: " + salario_bruto);
            Console.WriteLine("Valor de sus impuestos: " + impuestos);
            Console.WriteLine("Valor de salario neto: " + salario_neto);

            Console.WriteLine();
            Console.Write("Presionar una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}

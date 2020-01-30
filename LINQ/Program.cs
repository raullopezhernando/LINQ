using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LINQ
{
    class Program
    {


        static void Main(string[] args)
        {



            var estudiantes = new[]
          {
                new
                 {
                    EstudianteID = 1,
                    Nombre = "Héctor",
                    ApellidoPaterno = "Pérez",
                    Universidad = "Real de Brasil"
                },
                new
                {
                    EstudianteID = 2,
                    Nombre = "Ana",
                    ApellidoPaterno = "Nepomuceno",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 3,
                    Nombre = "Pedro",
                    ApellidoPaterno = "Sánchez",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 4,
                    Nombre = "José",
                    ApellidoPaterno = "Infante",
                    Universidad = "Harvard"
                },
                new
                {
                    EstudianteID = 5,
                    Nombre = "Regina",
                    ApellidoPaterno = "Bustamante",
                    Universidad = "Oxford"
                },
                new
                {
                    EstudianteID = 6,
                    Nombre = "Rodrigo",
                    ApellidoPaterno = "Jiménez",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 7,
                    Nombre = "Miguel",
                    ApellidoPaterno = "Hernández",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 8,
                    Nombre = "Marilyn",
                    ApellidoPaterno = "Monroe",
                    Universidad = "UNAM"
                },
                new
                {
                    EstudianteID = 9,
                    Nombre = "Leonardo",
                    ApellidoPaterno = "Estrada",
                    Universidad = "Brooklyn"
                },
                new
                {
                    EstudianteID = 10,
                    Nombre = "Ricardo",
                    ApellidoPaterno = "Rojas",
                    Universidad = "Real de Brasil"
                },
            };

            var universidades = new[]
            {
                new
                {
                    Universidad = "Real de Brasil",
                    Ciudad = "Brasilia",
                    Pais = "Brasil"
                },
                new
                {
                    Universidad = "Oxford",
                    Ciudad = "Oxford",
                    Pais = "Reino Unido"
                },
                new
                {
                    Universidad = "Harvard",
                    Ciudad = "Cambridge",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "Brooklyn",
                    Ciudad = "Nueva York",
                    Pais = "Estados Unidos"
                },
                new
                {
                    Universidad = "UNAM",
                    Ciudad = "Ciudad de México",
                    Pais = "México"
                },
            };


            //Para que se de LINQ ambas tienen que extender de IEnumerable y por ello se recorren con Foreach. Solo se rellena la lita de los nombres cuando hacemos el Foreeach 



            // METODO SELECT CON LINQ -------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Obtener Nombre y Apellidos  de los todos los estudiantes. 1ª Forma - Concatenando con $

            //IEnumerable<string> nombreEstudiantesYApellidoPaterno = estudiantes.Select(e => $"{e.Nombre} {e.ApellidoPaterno}");

            //foreach (var nombresYApellidos in nombreEstudiantesYApellidoPaterno)
            //{
            //    Console.WriteLine(nombresYApellidos);

            //}



            // Obtener Nombre y Apellidos  de los todos los estudiantes. 1ª Forma - Concatenando con $


            //var nombreEstudiantesYApellido = estudiantes.Select(e => new 
            //{
            //    Nombre = e.Nombre,
            //    Apellido = e.ApellidoPaterno


            //});


            //foreach (var nombresYApellidos in nombreEstudiantesYApellido)
            //{
            //    Console.WriteLine(nombresYApellidos.Nombre + nombresYApellidos.Apellido);

            //}




            //////// FIN SELECT LINQ--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //////////SELECT WHERE--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // En esta consulta lo qyue vamoos hacer es ordenar las universidades por orden alfabetico de forma ascendente y luego imprimirlas


            //IEnumerable<string> universidadesOrdenAlfabeticoAscendente = universidades.OrderBy(u => u.Universidad).Select(u => u.Universidad);

            //// En esta consulta lo qyue vamoos hacer es ordenar las universidades por orden alfabetico de forma decreciente y luego imprimirlas

            //IEnumerable<string> universidadesOrdenAlfabeticoDescendente = universidades.OrderByDescending(u => u.Universidad).Select(u => u.Universidad);

            //// ThenBy --- En esta consulta podemos ver un ThenBy el cual aplica un filtro mas a la consulta. Esto quiere decir que ordenaremos por universidad y pais

            //IEnumerable<string> universidadesOrdenAlfabeticoDescendienteYPorPais = universidades.OrderByDescending(u => u.Universidad).ThenBy( u => u.Pais).Select(u => u.Universidad);

            //// Utilizando Group By()

            //var universidadesPais = universidades.GroupBy(u => u.Pais);

            //foreach (var grupo in universidadesPais)
            //{
            //    Console.WriteLine($"Univerdidad:{grupo.Key} \t {grupo.Count()}");

            //    foreach (var universidad in grupo)
            //    {
            //        Console.WriteLine($"\t {universidad.Universidad}");


            //    }


            //}




            //foreach (var uniOrdenAlfabetico in universidadesOrdenAlfabeticoAscendente)
            //{
            //    Console.WriteLine("Estas son las universidades en orden alfabetico hacia delante");
            //    Console.WriteLine(uniOrdenAlfabetico);
            //}


            //// Seleccionamos las universidades en las que el Pais es "Estados Unidos" 

            //var universidadesEU = universidades.Where(u => u.Pais == "Estados Unidos").Select(e=> e.Universidad);

            //foreach (var universidad in universidades) 
            //{

            //    Console.WriteLine(universidad);
            //}



            // PROBANDO METODOS DE RESUMEN

            int numeroUniversidades = universidades.Select(u => u.Universidad).Count(); // Te devuelve el numero de Universidades PERO TIENE EN CUENTA LAS UNIVERSIDADES DUPLICADAS (MAL)
            int numeroUniversidades = universidades.Select(u => u.Universidad).Distinct().Count(); // Te devuelve el numero de Universidades PERO NO TIENE EN CUENTA LAS UNIVERSIDADES DUPLICADAS (BIEN)




            Console.ReadLine();
        }


    

    }
}

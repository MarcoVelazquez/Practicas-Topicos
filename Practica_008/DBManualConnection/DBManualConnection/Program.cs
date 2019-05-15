using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace DBManualConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection dbc = new DBConnection();

            dbc.PullData();
            


            string salida= "";
            /*foreach (DataRow row in dbc.dataTable.Rows)
            {
                foreach (DataColumn col in dbc.dataTable.Columns)
                    salida += row[col] + " | ";

                Console.WriteLine(salida);
             
            }*/

            /*for (int i = 0; i < dbc.dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dbc.dataTable.Columns.Count; j++)
                    salida += (dbc.dataTable.Rows[i])[j].ToString() + " | ";
                Console.WriteLine(salida);
                salida = "";
            }*/


            IEnumerable<DataRow> tuplas = dbc.dataTable.AsEnumerable();
            foreach (DataRow row in tuplas)
            {
                foreach (object n in row.ItemArray)
                {
                    Console.Write("{0}\t", n.ToString().Trim());
                }

                Console.WriteLine("");
            }
            
           var ordenados = tuplas.OrderBy<DataRow, string>(t => t["Nombre"].ToString());
            Console.WriteLine("Ordenados");
            foreach (DataRow row in ordenados)
            {
                foreach (object n in row.ItemArray)
                    Console.Write("{0}\t ",n.ToString().Trim());

                Console.WriteLine("");
            }
            
            var ordeID = dbc.dataTable.AsEnumerable().OrderBy<DataRow, int>(t => int.Parse(t["NoControl"].ToString()));
            Console.WriteLine("Ordenados por ID");
            foreach (DataRow row in ordeID)
            {
                foreach (object n in row.ItemArray)
                    Console.Write(n.ToString());

                Console.WriteLine("");
            }
            
            IEnumerable<string> materias = (from estudiantes in dbc.dataTable.AsEnumerable()
                                                    select estudiantes.Field<string>("Materia")).Distinct<string>();
            Console.WriteLine("Materias");
            foreach (string m in materias)
                Console.WriteLine(m);
            
            IEnumerable<string> matUp = (from estudiantes in dbc.dataTable.AsEnumerable()
                                            select estudiantes.Field<string>("Materia").ToUpper()).Distinct();
            Console.WriteLine("Upper case");
            foreach (string m in matUp)
                Console.WriteLine(m);
            
            var ordDec = tuplas.OrderByDescending<DataRow, string>(d => d.Field<string>("Nombre"));
            Console.WriteLine("Nombre desc");
            foreach (DataRow row in ordDec)
            {
                foreach (object n in row.ItemArray)
                    Console.Write(n.ToString());

                Console.WriteLine("");
            }
           IEnumerable<string> nombresEstudiantes = /*dbc.dataTable.AsEnumerable().Select<DataRow,string>(a => a["Nombre"].ToString());*/from estudiantes in dbc.dataTable.AsEnumerable() select estudiantes.Field<string>("Nombre");
            //IEnumerable<string> nombresEstudiantes = from estudiantes in dbc.dataTable.AsEnumerable()
                                                    // select estudiantes.Field<string>("Nombre");

            foreach (string nombre in nombresEstudiantes)
           {
                Console.WriteLine(new string(nombre.ToCharArray()
        .Where(c => c!= 'a')
        .ToArray()) + "|");
                //Console.WriteLine(nombre + ": {0}",nombre.Length );
                Console.Write(nombre.Trim() );
                Console.WriteLine("|");
            }

            //var nomLargo = nombresEstudiantes.Where<string>(n => n./*Trim().*/Length > 4);
            ////var nomOrd = dbc.dataTable.AsEnumerable().OrderBy<DataRow,"Nombre">(r => r['Nombre']);
            //foreach (string nl in nomLargo)
            //    Console.WriteLine(nl);


        }
    }
}

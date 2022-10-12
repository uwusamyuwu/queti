using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    class Familia
    {
        private int idFamilia { get; set; }
        private string nombre { get; set; }
        private string parentesco { get; set; }
        private string ocupacion { get; set; }

        public DataTable llenarFamilia()
        {
            MySqlConnection conexion = new MySqlConnection("server=10.120.3.200;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = conexion;

            conexion.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            instruccion.CommandText = "select * from familia";
            Adapter.SelectCommand = instruccion;
            DataSet SetDatos = new DataSet();
            Adapter.Fill(SetDatos);
            DataTable Tabla = new DataTable();
            Tabla = SetDatos.Tables[0];
            conexion.Close();

            return Tabla;
        }
    }

}

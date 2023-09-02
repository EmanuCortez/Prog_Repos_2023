using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Veterinaria_2023.Entidades;

namespace Veterinaria_2023.Entidades.AccesoDatos
{
    internal class ProductServices
    {
        private AccesoDatos oAccesoDatos;

        public ProductServices()
        {
            oAccesoDatos = new AccesoDatos();
        }

        public DataTable getTipos()
        {
            return oAccesoDatos.ConsultarTabla("Tipos");
        }


        //public bool Save(Mascota oMascota, bool esNuevo)
        //{
        //    bool success = false;
        //    string sql;

        //    if (esNuevo)
        //        sql = "Insert into Mascotas Values(@codigo, @nombre, @edad, @tipo, @duenio, @atencion)";
        //    else
        //        sql = "Update Mascotas SET nombre = @nombre, edad = @edad, tipo = @tipo, duenio = @duenio, atencion =  @atencion WHERE codigo = @codigo";

        //    //Convertimo un objeto Producto en una lista de parámetros
        //    List<Parametro> parametros = new List<Parametro>();
        //    parametros.Add(new Parametro("@codigo", oMascota.IdMascota));
        //    parametros.Add(new Parametro("@nombre", oMascota.Nombre));
        //    parametros.Add(new Parametro("@edad", oMascota.Edad));
        //    parametros.Add(new Parametro("@tipo", oMascota.Tipo));
        //    parametros.Add(new Parametro("@duenio", oMascota.Duenio));
        //    parametros.Add(new Parametro("@atencion", oMascota.Atencion));

        //    success = oAccesoDatos.ActualizarConParametros(sql, parametros);

        //    return success;
        //}


        //public bool Delete(int codigo)
        //{
        //    bool success = false;
        //    string sql = "DELETE from Productos WHERE codigo = @codigo";

        //    //Convertimo un objeto Producto en una lista de parámetros
        //    List<Parametro> parametros = new List<Parametro>();
        //    parametros.Add(new Parametro("@codigo", codigo));

        //    return oAccesoDatos.ActualizarConParametros(sql, parametros);
        //}


        public List<Mascota> getAll()
        {
            List<Mascota> lst = new List<Mascota>();

            DataTable t = oAccesoDatos.ConsultarSP("SP_SELECCIONAR_MASCOTA");

            //for en datatable para convertir filas en objetos de negocio:

            Mascota oMascota;
            Duenio oDuenio;

            foreach (DataRow fila in t.Rows)
            {
                //mapeamos
                oMascota = new Mascota();

                int codigo = Convert.ToInt32(fila[0]);
                oMascota.IdMascota = codigo;

                string nombre = fila[1].ToString();
                oMascota.Nombre = nombre;

                int edad = Convert.ToInt32(fila[2]);
                oMascota.Edad = edad;

                string sexo = fila[3].ToString();
                oMascota.Sexo = sexo;

                int tipo = Convert.ToInt32(fila[4]);
                oMascota.Tipo = tipo.ToString();

                oDuenio = new Duenio();
                int codigoD = Convert.ToInt32(fila[5]);
                oDuenio.Codigo = codigoD;

                string nombreD = fila[6].ToString();
                oDuenio.Nombre = nombreD;

                oMascota.Duenio = oDuenio;


                lst.Add(oMascota);
                
            }
            return lst;
        }

        public int ProximaCarpeta()
        {

            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Veterinaria_2023;Integrated Security=True");


            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARPETA";
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@next";
            parameter.SqlDbType = SqlDbType.Int;
            parameter.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(parameter);
            cmd.ExecuteNonQuery();

            cnn.Close();

            return (int)parameter.Value;

        }

        public int Carpeta()
        {

            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Veterinaria_2023;Integrated Security=True");


            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARPETA";
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@id_mascota";
            parameter.SqlDbType = SqlDbType.Int;

            cmd.Parameters.Add(parameter);
            cmd.Parameters["@id_mascota"].Value = int.Parse(.Text);
            cmd.ExecuteNonQuery();

            cnn.Close();

            return (int)parameter.Value;

        }
    }
}

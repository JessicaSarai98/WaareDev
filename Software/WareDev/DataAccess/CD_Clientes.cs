using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        DataTable tabla3 = new DataTable();
        SqlCommand comando = new SqlCommand();
        //---- MOSTRAR TABLA----------
        //Mostrar usuario 
        public DataTable MostrarU()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from data";
            //comando.CommandText = "select Id= "+id+", username='"+username+"', firstName='"+firstName+"', lastName='"+lastName+"' from data ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //mostrar cliente
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from clientes";
            //comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //mostrar clientes físicos
        public DataTable MostrarCli2()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from clientesFisicos";
            //comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //mostrar proveedores 
        public DataTable MostrarS()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from supplier";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        //mostrar proveedores fisicos
        public DataTable MostrarSFisicos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from ProveedorFisicos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        //mostrar raw 

        public DataTable MostrarR()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from rawMaterials";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla; 
        }

        //mostrar inputs

            public DataTable MostrarI()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from inputs";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla; 
        }
        //mostrar finished products

            public DataTable MostrarF()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from FinishedProducts";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla; 
        }

        //mostrar rawMaterials en start
        public DataTable MostrarRawStart()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select name, amountPurchased, description, mat as 'Almacen' from rawMaterials UNION select name, amountPurchased, description, insu as 'Almacen' from inputs UNION select name, amountPurchased, description, fin as 'Almacen' from FinishedProducts ORDER BY Almacen asc;";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla; 

        }

        ////mostrar inputs en start
        //public DataTable MostrarInputStart()
        //{
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "select name, amountPurchased, description, insu from inputs";
        //    leer = comando.ExecuteReader();
        //    tabla2.Load(leer);
        //    conexion.CerrarConexion();
        //    return tabla2;

        //}
        ////mostrar finished products en start
        //public DataTable MostrarFinishedStart()
        //{
        //    comando.Connection = conexion.AbrirConexion();
        //    comando.CommandText = "select name, amountPurchased, description, fin from FinishedProducts";
        //    leer = comando.ExecuteReader();
        //    tabla3.Load(leer);
        //    conexion.CerrarConexion();
        //    return tabla3;

        //}

        //-----AGREGAR--------

        //insertar clientes
        public void Insertar(int id, string name, string rfc, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, double tasaa, string stat, string
            vendedor, string pm, string cfdi, string note)
        {
            // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into clientes values("+id+",'" + name + "','" + rfc + "','" + phone + "','" + email + "','" + address + "','" + city + "','" + state + "','" + country + "','" + cp + "','" + identy + "'," + tasaa + ",'" + stat + "','" + vendedor + "','" + pm + "','" + cfdi + "','" + note + "')";

            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

        }

        //insertar clientes fisicos
        public void Insertar2(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into clientesFisicos values(" + id + ",'" + nombres + "','" + apellido1 + "','" + 
                apellido2 + "','" + registro + "','" + razon + "','" + ciudad + "','" + calle + "','" + numero + "','" + 
                lada + "','" + telefono + "','" + fax + "','" + correo + "')";

            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

        }

        //insertar datos de usuarios
        public void InsertarU(string username, string pass, string email, string firstname, string lastname, byte[] foto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into data values('" + username + "', '" + pass + "', '" + email + "', '" + firstname + "', '" + lastname + "','" + @foto + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        //insertar datos de proveedores 
        public void InsertarS(int id, string name, string rfc, string phone, string email, string addres, string country, string state, string city, string divisa)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into supplier values("+id+",'" + name + "', '" + rfc + "', '" + phone + "', '" + email + "', '" + addres + "', '" + country + "', '" + state + "', '" + city + "', '" + divisa + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        //insertar datos de proveedores fisicos
        public void InsertarSFisicos(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into ProveedorFisicos values(" + id + ",'" + nombres + "','" + apellido1 + "','" +
                apellido2 + "','" + registro + "','" + razon + "','" + ciudad + "','" + calle + "','" + numero + "','" +
                lada + "','" + telefono + "','" + fax + "','" + correo + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        //----EDITAR----

        //actualizar datos CLIENTE 

        public void Editar(string name, string RFC, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, double tasaa, string stat, string
            vendedor, string pm, string cfdi, string note, int id)
        {
            // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update clientes set name='" + name + "', RFC= '" + RFC + "', phone= '" + phone + "',email='" + email + "', address='" + address + "'," +
                "city='" + city + "', state='" + state + "', country='" + country + "', codigopostal='" + cp + "', identidadfiscal='" + identy + "', tasa=" + tasaa + ", status='" + stat + "'," +
                "vendedor='" + vendedor + "',payment='" + pm + "', CFDI='" + cfdi + "', note='" + note + "'  where Id='" + id + "'";
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();


        }
        //editar cliente fisico
        public void Editarfisica(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update clientesFisicos set nombres='" + nombres + "', primerApellido= '" + apellido1 + "', segundoApellido= '" + apellido2 + 
                "', registroFiscal='" + registro + "', razonSocial='" + razon + "', ciudad='" + ciudad + "', calle='" + calle + "', numero='" + numero + 
                "', lada='" + lada + "', telefono='" + telefono + "', fax='" + fax + "', correo='" + correo + "'  where Id='" + id + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        //actualizar datos de USUARIO
        public void EditarU(string username, string pass, string email, string firstname, string lastname, byte[] imagen, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update data set username='" + username + "', password='" + pass + "',email='" + email + "',firstName='" + firstname + "'," +
                "lastName='" + lastname + "',imagen=@imagen where Id='"+id+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 
        }

        //actualizar datos de proveedores
        public void EditarS(string name, string rfc, string phone, string email, string addres, string country, string state, string city, string divisa, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update supplier set name='"+name+ "',RFC='"+rfc+ "', " +
                "phone='"+phone+ "',email='"+email+ "', addres='"+addres+ "',country='"+country+"',state='"+state+"'," +
                "city='"+city+ "', currency='"+divisa+ "' where Id='" + id + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 
        }


        //actualizar datos de proveedores fisicos
        public void EditarSFisicos(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update ProveedorFisicos set nombres='" + nombres + "', primerApellido= '" + apellido1 + "', segundoApellido= '" + apellido2 +
                "', registroFiscal='" + registro + "', razonSocial='" + razon + "', ciudad='" + ciudad + "', calle='" + calle + "', numero='" + numero +
                "', lada='" + lada + "', telefono='" + telefono + "', fax='" + fax + "', correo='" + correo + "'  where Id='" + id + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        //-----ELIMINAR-----
        //Eliminar clientes
        public void Eliminar(int id, string database)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from "+ database +" where Id=" + id + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            // comando.Parameters.AddWithValue("Id", id);

            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();
            //conexion.CerrarConexion(); 
        }


        //eliminar usuarios 
        public void EliminarU(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from data where Id=" + id + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        //eliminar proveedores
        public void EliminarS(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from supplier where Id="+id+"";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 
        }

        //eliminar proveedores fisicos
        public void EliminarSFisicos(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from ProveedorFisicos where Id=" + id + "";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
        //eliminar Materia Prima (Raw)
        public void EliminarR(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from rawMaterials where Id="+id+"";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 
        }

        //eliminar insumos (inputs)

        public void EliminarI(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from inputs where Id="+id+"";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 

        }

        //eliminar finishedProducts 

    public void EliminarFini(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText ="delete from FinishedProducts where Id="+id+"";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection(@"Data Source = LAPTOP-SDO1671B; Initial Catalog = users; Integrated Security = True; Pooling=False");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion; 
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion; 
        }
    }
}
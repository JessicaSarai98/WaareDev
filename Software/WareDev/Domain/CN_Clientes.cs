﻿using System;
using System.Data;
using DataAccess;

namespace Domain

{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        //----------MOSTRAR EN TABLA-----
        //Mostrar usuarios
        public DataTable MostrarUsu()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarU();
            return tabla;
        }
        //Mostrar clientes
        public DataTable MostrarCli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        //Mostrar clientes fisicos
        public DataTable MostrarCliFisicos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCli2();
            return tabla;
        }

        //Mostrar proveedores fisicos
        public DataTable MostrarSupFisicos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarSFisicos();
            return tabla;
        }

        //Mostrar proveedores
        public DataTable MostrarSup()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarS();
            return tabla;
        }
        //Mostrar proveedores fisicos
        public DataTable MostrarSupfisicos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarSFisicos();
            return tabla;
        }

        //Mostrar raw
        public DataTable MostrarRaw()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarR();
            return tabla;
        }

        //mostrar inputs
        public DataTable MostrarInp()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarI();
            return tabla;
        }

        //mostrar finished products
        public DataTable MostrarFinished()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarF();
            return tabla;
        }

        //mostrar rawMaterials en start
        public DataTable MostrarRS()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarRawStart();
            return tabla;
        }

        //mostrar inputs en start
        //public DataTable MostrarIS()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = objetoCD.MostrarInputStart();
        //    return tabla;
        //}
        //mostrar finished products en start
        //public DataTable MostrarFPS()
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = objetoCD.MostrarFinishedStart();
        //    return tabla;
        //}

        //------NUEVO----------
        //insertar cliente
        public void InsertarClie(string id, string name, string rfc, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, string tasaa, string stat, string
            vendedor, string pm, string cfdi, string note)
        {
            objetoCD.Insertar(Convert.ToInt32(id),name, rfc, phone, email, address, city, state,
                country, cp, identy, Convert.ToSingle(tasaa), stat, vendedor, pm, cfdi, note);
        }

        //insertar cliente fisico
        public void InsertarClieFisico(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            objetoCD.Insertar2(Convert.ToInt32(id), nombres, apellido1, apellido2, registro, razon,
            ciudad, calle, numero, lada, telefono, fax, correo);
        }
        //insertar datos de usuario
        public void InsertarUsu(string username, string pass, string email, string firstname, string lastname, byte[]foto)
        {
            objetoCD.InsertarU(username, pass, email, firstname, lastname, foto);
        }

        //insertar datos de proveedor
        public void InsertarSupp(string id, string name, string RFC, string phone, string email, string addres, string country, string state,
           string city, string currency)
        {
            objetoCD.InsertarS(Convert.ToInt32(id),name, RFC, phone, email, addres, country, state, city, currency);
        }

        //insertar datos de proveedor fisico
        public void InsertarSuppFisicos(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            objetoCD.InsertarSFisicos(Convert.ToInt32(id), nombres, apellido1, apellido2, registro, razon,
            ciudad, calle, numero, lada, telefono, fax, correo);
        }



        //-------EDITAR DATOS-------
        //actualizar datos de cliente
        public void EditarClie(string name, string RFC, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, string tasaa, string stat, string
            vendedor, string pm, string cfdi, string note, string id)
        {
            objetoCD.Editar(name, RFC, phone, email, address, city, state, country, cp, identy, Convert.ToDouble(tasaa),
                stat, vendedor, pm, cfdi, note, Convert.ToInt32(id));
        }

        //cliente fisico
        public void EditarClieFisica(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            objetoCD.Editarfisica(Convert.ToInt32(id), nombres, apellido1, apellido2, registro, razon,
            ciudad, calle, numero, lada, telefono, fax, correo);
        }

        //actualizar datos de usuario
        public void EditarUsu(string username, string pass, string email, string firstname, string lastname, byte[] foto, string id)
        {
            objetoCD.EditarU(username, pass, email, firstname, lastname, foto, Convert.ToInt32(id));
        }

        //actualizar datos de proveedor
        public void EditarSup(string name, string RFC, string phone, string email, string addres, string country, string state,
           string city, string currency, string id)
        {
            objetoCD.EditarS(name, RFC, phone, email, addres, country, state, city, currency, Convert.ToInt32(id));
        }

        //actualizar datos de proveedor fisicos
        public void EditarSupFisicos(int id, string nombres, string apellido1, string apellido2, string registro, string razon,
            string ciudad, string calle, string numero, string lada, string telefono, string fax, string correo)
        {
            objetoCD.EditarSFisicos(Convert.ToInt32(id), nombres, apellido1, apellido2, registro, razon,
            ciudad, calle, numero, lada, telefono, fax, correo);
        }

        //-----ELIMINAR---------

        //eliminar cliente
        public void EliminarCli(string id, string database)
        {
            objetoCD.Eliminar(Convert.ToInt32(id), database);
        }

        //eliminar usuario 
        public void EliminarUsu(string id)
        {
            objetoCD.EliminarU(Convert.ToInt32(id));
        }


        //eliminar proveedor
        public void EliminarSup(string id)
        {
            objetoCD.EliminarS(Convert.ToInt32(id));
        }

        //eliminar proveedor fisico
        public void EliminarSupFisica(string id)
        {
            objetoCD.EliminarSFisicos(Convert.ToInt32(id));
        }

        //eliminar Materia Prima (Raw)
        public void EliminarRaw(string id)
        {
            objetoCD.EliminarR(Convert.ToInt32(id));
        }

        //eliminar insumo (inputs)

        public void EliminarInp(string id)
        {
            objetoCD.EliminarI(Convert.ToInt32(id));
        }

        //eliminar finished products
        public void EliminarF(string id)
        {
            objetoCD.EliminarFini(Convert.ToInt32(id));
        }
    }
}

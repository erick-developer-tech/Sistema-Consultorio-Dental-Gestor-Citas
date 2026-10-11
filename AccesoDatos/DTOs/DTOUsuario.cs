using AccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AccesoDatos.DTOs
{
    public class DTOUsuario
    {
        private readonly string _connectionString;

        public DTOUsuario(string connectionString) 
        {
            _connectionString = connectionString;
        }

        public bool InsertarUsuario(MUsuario usuario) 
        {
            var parametros = new
            {
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Telefono = usuario.Telefono,
                Email = usuario.Email,
                Horario = usuario.Horario,
                Usuario = usuario.Usuario,
                Contraseña = usuario.Contraseña,
                Rol = usuario.Rol
            };
            using (IDbConnection db = new SqlConnection(_connectionString)) 
            {
                db.Execute(
                    "sp_InsertarUsuario",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool ActualizarUsuario(MUsuario usuario)
        {
            var parametros = new
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Telefono = usuario.Telefono,
                Email = usuario.Email,
                Horario = usuario.Horario,
                Rol = usuario.Rol
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_ActualizarUsuario",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool ActualizarCredenciales(MUsuario usuario)
        {
            var parametros = new
            {
                Id = usuario.Id,
                Usuario = usuario.Usuario,
                Contraseña = usuario.Contraseña
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_ActualizarCredenciales",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public IEnumerable<MUsuario> ObtenerUsuarios() 
        {
            using (IDbConnection db = new SqlConnection(_connectionString)) 
            {
                return db.Query<MUsuario>(
                    "sp_ObtenerUsuarios",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public IEnumerable<MUsuario> BuscarUsuarios(string criterio)
        {
            var parametros = new
            {
                Criterio = criterio
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MUsuario>(
                    "sp_BuscarUsuarios",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public IEnumerable<MUsuario> ValidarCredenciales(string usuario)
        {
            var parametros = new
            {
                Usuario = usuario
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MUsuario>(
                    "sp_ValidarCredenciales",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public bool BajaUsuario(int id) 
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_connectionString)) 
            {
                db.Execute(
                    "sp_BajaUsuario",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}

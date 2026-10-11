using AccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AccesoDatos.DTOs
{
    public class DTOPaciente
    {
        private readonly string _connectionString;

        public DTOPaciente(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool InsertarPaciente(MPaciente paciente)
        {
            var parametros = new
            {
                Nombre = paciente.Nombre,
                Apellidos = paciente.Apellidos,
                Telefono = paciente.Telefono,
                Email = paciente.Email,
                Alergias = paciente.Alergias
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_InsertarPaciente",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool ActualizarPaciente(MPaciente paciente)
        {
            var parametros = new
            {
                Id = paciente.Id,
                Nombre = paciente.Nombre,
                Apellidos = paciente.Apellidos,
                Telefono = paciente.Telefono,
                Email = paciente.Email,
                Alergias = paciente.Alergias
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_ActualizarPaciente",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public IEnumerable<MPaciente> ObtenerPacientes()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MPaciente>(
                    "sp_ObtenerPacientes",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public IEnumerable<MPaciente> BuscarPacientes(string criterio)
        {
            var parametros = new
            {
                Criterio = criterio
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MPaciente>(
                    "sp_BuscarPacientes",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public bool EliminarPaciente(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_EliminarPaciente",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}

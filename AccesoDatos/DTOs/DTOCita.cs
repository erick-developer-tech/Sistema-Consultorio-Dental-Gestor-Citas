using AccesoDatos.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DTOs
{
    public class DTOCita
    {
        private readonly string _connectionString;

        public DTOCita(string connectionString) 
        {
            _connectionString = connectionString;
        }

        public bool InsertarCita(MCita cita) 
        {
            var parametros = new
            {
                IdUsuario = cita.IdUsuario,
                IdPaciente = cita.IdPaciente,
                IdServicio = cita.IdServicio,
                FechaHora = cita.FechaHora,
                Notas = cita.Notas
            };
            using (IDbConnection db = new SqlConnection(_connectionString)) 
            {
                db.Execute(
                    "sp_InsertarCita",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool ActualizarCita(MCita cita)
        {
            var parametros = new
            {
                Id = cita.Id,
                IdUsuario = cita.IdUsuario,
                IdPaciente = cita.IdPaciente,
                IdServicio = cita.IdServicio,
                FechaHora = cita.FechaHora,
                Estado = cita.Estado,
                Notas = cita.Notas
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_ActualizarCita",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool PagarCita(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_PagarCita",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool EliminarCita(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_EliminarCita",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public IEnumerable<MCita> ObtenerCitas() 
        {
            using (IDbConnection db = new SqlConnection(_connectionString)) 
            {
                return db.Query<MCita>(
                    "sp_ObtenerCitas",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public IEnumerable<MCita> BuscarCitas(DateTime fechaInicio, DateTime fechaFin)
        {
            var parametros = new 
            {
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MCita>(
                    "sp_BuscarCitas",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
    }
}

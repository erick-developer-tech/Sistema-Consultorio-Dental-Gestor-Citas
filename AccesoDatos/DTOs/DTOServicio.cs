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
    public class DTOServicio
    {
        private readonly string _connectionString;

        // Unico constructor que recibe la cadena de conexión
        public DTOServicio(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool InsertarServicio(MServicio servicio)
        {
            var parametros = new
            {
                Servicio = servicio.Servicio,
                Costo = servicio.Costo
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_InsertarServicio",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool ActualizarServicio(MServicio servicio)
        {
            var parametros = new
            {
                Id = servicio.Id,
                Servicio = servicio.Servicio,
                Costo = servicio.Costo
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_ActualizarServicio",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public IEnumerable<MServicio> ObtenerServicios()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MServicio>(
                    "sp_ObtenerServicios",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public IEnumerable<MServicio> BuscarServicios(string criterio)
        {
            var parametros = new
            {
                Criterio = criterio
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MServicio>(
                    "sp_BuscarServicios",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public bool EliminarServicio(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_EliminarServicio",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
    }
}

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
    public class DTOReceta
    {
        private readonly string _connectionString;

        public DTOReceta(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool InsertarReceta(MReceta receta)
        {
            var parametros = new
            {
                IdCita = receta.IdCita,
                Diagnostico = receta.Diagnostico,
                Tratamiento = receta.Tratamiento
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_InsertarReceta",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public bool ActualizarReceta(MReceta receta)
        {
            var parametros = new
            {
                Id = receta.Id,
                IdCita = receta.IdCita,
                Diagnostico = receta.Diagnostico,
                Tratamiento = receta.Tratamiento
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_ActualizarReceta",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }
        public bool EliminarReceta(int id)
        {
            var parametros = new
            {
                Id = id
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute(
                    "sp_EliminarReceta",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );
                return true;
            }
        }

        public IEnumerable<MReceta> ObtenerRecetas() 
        {
            using (IDbConnection db = new SqlConnection(_connectionString)) 
            {
                return db.Query<MReceta>(
                    "sp_ObtenerRecetas",
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public IEnumerable<MReceta> BuscarRecetas(string criterio)
        {
            var parametros = new
            {
                Criterio = criterio
            };
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<MReceta>(
                    "sp_BuscarRecetas",
                    parametros,
                    commandType: CommandType.StoredProcedure
                    );           
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceCSharp.Model.VO;

namespace WebServiceCSharp.Model.DAO
{
    public class CargosDAO
    {

        public string InserirCargo(Cargos pCargo)
        {
            string msg, sql;
            try
            {
                ConexaoDB conexaodb = new ConexaoDB();
                sql = "INSERT INTO cargos (nome, vlrhoramin, vlrhoramax) VALUES ( '" + pCargo.cargo + "' , " +
                                                                                    pCargo.vlrmin + " , " +
                                                                                    pCargo.vlrmax + ")";
                conexaodb.conectar();
                conexaodb.comandosql(sql);
                conexaodb.desconectar();
                msg = "Inserido com Sucesso";
            }

            catch (Exception e)
            { msg = e.Message; }
            return msg;
        }
    }
}
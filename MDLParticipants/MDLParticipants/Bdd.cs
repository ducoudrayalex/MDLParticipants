using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;  // bibliothèque pour les expressions régulières

namespace MDLParticipants
{
    class Bdd
    {
        //
        // propriétés membres
        //
        private OracleConnection CnOracle;
        private OracleCommand UneOracleCommand;
        private OracleDataAdapter UnOracleDataAdapter;
        private DataTable UneDataTable;
        private OracleDataReader UnReader;
        //
        // méthodes
        //
        /// <summary>
        /// constructeur de la connexion
        /// </summary>
        /// <param name="UnLogin">login utilisateur</param>
        /// <param name="UnPwd">mot de passe utilisateur</param>
        public Bdd(String UnLogin, String UnPwd)
        {
            ConnectionStringSettings CnString = new ConnectionStringSettings();
            try
            {
                /// <remarks>on commence par récupérer dans CnString les informations contenues dans le fichier app.config
                /// pour la connectionString de nom StrConnMdl
                /// </remarks>
                CnString = ConfigurationManager.ConnectionStrings["StrConnMdl"];
                CnOracle = new OracleConnection(string.Format(CnString.ConnectionString,
                                                    ConfigurationManager.AppSettings["SERVEROUT"],
                                                    ConfigurationManager.AppSettings["PORTOUT"],
                                                    ConfigurationManager.AppSettings["SID"],
                                                    UnLogin,
                                                    UnPwd
                                                    )
                                                );
                ///<remarks>
                /// on va remplacer dans la chaine de connexion les paramètres par le login et le pwd saisis
                ///dans les zones de texte. Pour ça on va utiliser la méthode Format de la classe String.                /// 
                /// </remarks>

                CnOracle.Open();
            }
            catch (OracleException)
            {
                // si la connexion IN a échoué, on tente la connexion out.
                try
                {
                    CnString = ConfigurationManager.ConnectionStrings["StrConnMdl"];
                    CnOracle = new OracleConnection(string.Format(CnString.ConnectionString,
                                                      ConfigurationManager.AppSettings["SERVERIN"],
                                                      ConfigurationManager.AppSettings["PORTIN"],
                                                      ConfigurationManager.AppSettings["SID"],
                                                      UnLogin,
                                                      UnPwd
                                                      )
                                                  );
                    CnOracle.Open();
                }
                catch (OracleException)
                {
                    throw new Exception("connexion impossible à la base");
                }
            }
        }
        /// <summary>
        /// Methode d'execution d'une requete
        /// </summary>
        /// <param name="UnObjetCommande"></param>
        /// <returns>DataTable</returns>
        private DataTable ExecuteRequete(OracleCommand UnObjetCommande)
        {
            UnReader = UneOracleCommand.ExecuteReader();
            UneDataTable = new DataTable();
            UneDataTable.Load(UnReader);
            UnReader.Close();
            return UneDataTable;
        }
        public DataTable GetParticipants()
        {
            try
            {
                String Req = "select * from  VPARTICIPANT01";
                this.UneOracleCommand = new OracleCommand(Req, CnOracle);
                //UnOracleDataAdapter = new OracleDataAdapter();
                //UnOracleDataAdapter.SelectCommand = this.UneOracleCommand;
                //UneDataTable = new DataTable();
                //UnOracleDataAdapter.Fill(UneDataTable);
                //return UneDataTable;
                return this.ExecuteRequete(this.UneOracleCommand);
            }
            catch (OracleException)
            {
                throw new Exception("Erreur de lecture des données");
            }
        }
    }
}

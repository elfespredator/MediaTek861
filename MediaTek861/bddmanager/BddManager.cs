using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MediaTek86.bddmanager
{

    public class BddManager
    {
    
        private static BddManager instance = null;

        
        private readonly MySqlConnection connection;

       
        private BddManager(string stringConnexion)
        {
            connection = new MySqlConnection(stringConnexion);
            connection.Open();
        }

        public static BddManager GetInstance(string stringConnexion)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnexion);
            }
            return instance;
        }

     
        public List<Dictionary<string, object>> ReqSelect(string req, Dictionary<string, object> parameters = null)
        {
            List<Dictionary<string, object>> records = new List<Dictionary<string, object>>();
            MySqlCommand cmd = new MySqlCommand(req, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> kv in parameters)
                {
                    cmd.Parameters.AddWithValue(kv.Key, kv.Value);
                }
            }
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dictionary<string, object> record = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    record.Add(reader.GetName(i), reader.IsDBNull(i) ? null : reader.GetValue(i));
                }
                records.Add(record);
            }
            reader.Close();
            return records;
        }

      
        public void ReqUpdate(string req, Dictionary<string, object> parameters = null)
        {
            MySqlCommand cmd = new MySqlCommand(req, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> kv in parameters)
                {
                    cmd.Parameters.AddWithValue(kv.Key, kv.Value);
                }
            }
            cmd.ExecuteNonQuery();
        }
    }
}
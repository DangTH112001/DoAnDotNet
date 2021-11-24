using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using mvc.Models;

namespace mvc.Data {
    public class StoreContext {
        public string ConnectionString {get; set;}

        public StoreContext(string ConnectionString) {
            this.ConnectionString = ConnectionString;
        }

        private MySqlConnection GetConnection() {
            return new MySqlConnection(ConnectionString);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QLNCKH
{
    class DB
    {

        public static SqlConnection GetDBConnection()
        {
            string datasource = @"ANHVIET\DMSQL";
            string database = "QLDT";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database +"; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }


    }
}
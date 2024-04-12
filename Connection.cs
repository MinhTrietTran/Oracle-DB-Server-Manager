﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace UsersManagement
{
    internal class Connection
    {
        private static string stringConnection = @"DATA SOURCE=localhost;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\Users\Admin\Oracle\network\admin;PASSWORD=heongusi22;PERSIST SECURITY INFO=True;USER ID=SYS";
        public static OracleConnection GetOracleConnection()
        {
            return new OracleConnection(stringConnection);
        }
    }
}

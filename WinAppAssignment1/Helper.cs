using System;
using System.Data.SqlClient;

namespace WinAppAssignment1
{
    public class Helper
    {
        public static string GetConnectionDetails(SqlConnection c)
        {
            return 
                  $"Connection Status Details. State at the Form Load time: {Environment.NewLine}"
                + $"{Environment.NewLine}"
                + $"Connection Status:\t {c.State}{Environment.NewLine}"
                + $"Conn TimeOut:\t{c.ConnectionTimeout}{Environment.NewLine}"
                + $"Packet Size:\t {c.PacketSize}{Environment.NewLine}"
                + $"Server Version:\t {c.ServerVersion}{Environment.NewLine}"
                + $"Workstation ID:\t {c.WorkstationId}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace WinAppAssignment1
{
    /// <summary>
    /// Krzysztof Szczurowski
    /// Helper class to support any UI operations;
    /// BCIT COMP3618 Assingment 1;
    /// Repo: https://github.com/kriss3/BCIT_COMP3618_Assignment1_QueryAnalyzer.git
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Formats the Connection details as requested in assignment details;
        /// </summary>
        /// <param name="c">Current, active connection to DB</param>
        /// <returns></returns>
        public static string GetConnectionDetails(SqlConnection c)
        {
            return 
                  $"Connection Status Details. State at the time of Form Load: {Environment.NewLine}"
                + $"{Environment.NewLine}"
                + $"Connection Status:\t {c.State}{Environment.NewLine}"
                + $"Conn TimeOut:\t{c.ConnectionTimeout}{Environment.NewLine}"
                + $"Packet Size:\t {c.PacketSize}{Environment.NewLine}"
                + $"Server Version:\t {c.ServerVersion}{Environment.NewLine}"
                + $"Workstation ID:\t {c.WorkstationId}";
        }

        //Sentinel pattern => ask about it.
        //Basic validation against Dropping tables or Deleting tables from Db 
        public static bool IsValid(string query)
        {
            var result = false;
            var blackList = new List<String> { "Delete", "Drop" };

            if (!blackList.Any(x => query.Contains(x)))
            {
                result = true;
            }
            return result;
        }
    }
}

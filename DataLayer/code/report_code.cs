using System;
using System.Collections.Generic;
using System.Text;
using db_lib.db_conn;
using DataLayer.Models;
using Dapper;
using db_lib.stored_proc;
using System.Linq;

namespace DataLayer.code
{
    public class report_code : db_connection
    {


        Reports_quer report_quer = new Reports_quer();


        /// <summary>
        /// Get all records of transactions
        /// </summary>
        /// <returns> returns a list of transactions</returns>
        public List<Report> GetAllTransactions()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<Report>(report_quer.Quer_GetAllTrans);
                return result.ToList();
            }
        }

        /// <summary>
        /// searrching the transactions by year and month
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns>returns a list of transactions</returns>
        public List<Report> GetFilteredTransactions_Y_Mon(string keyword, string year, string month)
        {
            keyword = "%" + keyword;
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<Report>(report_quer.Quer_FilterTransByYearMonth, new { keyword, year, month });
                return result.ToList();
            }
        }

        /// <summary>
        /// searching the transactions by month only
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="month"></param>
        /// <returns>returns a list of transactions</returns>
        public List<Report> GetFilteredTransactions_By_Mon_only(string keyword, string month)
        {
            keyword = "%" + keyword;
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<Report>(report_quer.Quer_FilterTransByMonth, new { keyword, month });
                return result.ToList();
            }
        }

        /// <summary>
        /// searching the transactions by year only
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Report> GetFilteredTransactionsByYear(string keyword, string year)
        {
            keyword = "%" + keyword ;
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<Report>(report_quer.Quer_FilterTrans_By_Year_Only, new { keyword, year });
                return result.ToList();
            }
        }

        /// <summary>
        /// searching the transactions by a serch word only - no month or year specified
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<Report> GetAllFilteredTransactions(string keyword)
        {
            keyword = "%" + keyword;
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<Report>(report_quer.Quer_AllFilterTrans, new { keyword });
                return result.ToList();
            }
        }


    }
}

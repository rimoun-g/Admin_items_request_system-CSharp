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

        public List<Report> GetAllTransactions()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<Report>(report_quer.Quer_GetAllTrans);
                return result.ToList();
            }
        }

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

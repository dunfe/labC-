using HE130007_KhoiTran_Lab3.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE130007_KhoiTran_Lab3.DAL
{
    class CopyDAO
    {
        public static DataTable GetDataTable()
        {
            string cmd = "select * from Copy";
            return DAO.GetDataTable(cmd);
        }
        public static int GetBookNumberMax()
        {
            DataTable dt = GetDataTable();
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return (int)(dt.Compute("max(bookNumber)", ""));
            }
        }
        public static int GetCopNumberMax()
        {
            DataTable dt = GetDataTable();
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return (int)(dt.Compute("max(copyNumber)", ""));
            }
        }

        public static int GetSequenceNumberMax()
        {
            DataTable dt = GetDataTable();
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return (int)(dt.Compute("max(sequenceNumber)", ""));
            }
        }

        public static bool Insert(Copy c)
        {
            SqlCommand cmd = new SqlCommand("insert into Copy(copyNumber,bookNumber,sequenceNumber,type,price)" + "values (@copyNumber,@bookNumber,@sequenceNumber,@type,@price)");
            return DAO.UpdateTable(cmd);
        }

        public static bool Update(Copy c)
        {
            SqlCommand cmd = new SqlCommand("update Copy set copyNumber = @copyNumber,sequenceNumber = @sequenceNumber,type=@type,price=@price where bookNumber = @bookNumber");
            cmd.Parameters.AddWithValue("@copyNumber", c.CopyNumber);
            cmd.Parameters.AddWithValue("@bookNumber", c.BookNumber);
            cmd.Parameters.AddWithValue("@title", c.SequenceNumber);
            cmd.Parameters.AddWithValue("@authors", c.Type);
            cmd.Parameters.AddWithValue("@publisher", c.Price);
            return DAO.UpdateTable(cmd);
        }
        public static Boolean Delete(int copyNumber)
        {
            SqlCommand cmd = new SqlCommand("delete Copy where copyNumber = @copyNumber");
            cmd.Parameters.AddWithValue("@bookNumber", copyNumber);
            return DAO.UpdateTable(cmd);
        }

      internal static Copy GetCopy(int copyNumber) {
         throw new NotImplementedException();
      }
   }
}

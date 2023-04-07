using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using DTO;
namespace DAO
{
    public class NhanvienDAO
    {

        public static DataTable LoadUserLists(OracleConnection cn)
        {
            DataTable UsersList = new DataTable();
            try
            {
                OracleCommand command = new OracleCommand("SYS.LIST_USERS", cn);
                command.CommandType = CommandType.StoredProcedure;
                // Add output parameter of type OracleRefCursor
                OracleParameter outputParam = new OracleParameter("C_LIST", OracleDbType.RefCursor);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);
                // Execute the command and get the OracleDataReader
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(UsersList);
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(UsersList.Rows.Count.ToString());
            return UsersList;
        }

    }
    public class DBA_ROLESDAO
    {
        public static DataTable LoadRoleLists(OracleConnection cn)
        {
            DataTable RolesList = new DataTable();
            try
            {
                OracleCommand command = new OracleCommand("SYS.LIST_ROLES", cn);
                command.CommandType = CommandType.StoredProcedure;
                // Add output parameter of type OracleRefCursor
                OracleParameter outputParam = new OracleParameter("C_LIST", OracleDbType.RefCursor);
                outputParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParam);
                // Execute the command and get the OracleDataReader
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(RolesList);
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine(RolesList.Rows.Count.ToString());
            return RolesList;
        }
    }
    public class ROLE_TAB_PRIVSDAO
    {
        public static DataTable RolePrvis(string role, OracleConnection cn)
        {
            DataTable InforPrivs = new DataTable();
            try
            {
                OracleCommand command = new OracleCommand("SYS.ROLE_PRIVILEGES_TAB", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("ROLE_NAME", OracleDbType.Varchar2).Value = role; 
                command.Parameters.Add("R_LSTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                // Execute the command and get the OracleDataReader
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(InforPrivs);

            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }
            return InforPrivs;
        }


    }
    public class DBA_ROLE_PRIVSDAO
    {
        public static DataTable LoadUserPrivs(DBA_ROLE_PRIVSDTO NV, OracleConnection cn)
        {
            DataTable InforPrivs = new DataTable();
            try
            {
                OracleCommand command = new OracleCommand("SYS.ROLE_USER_TAB", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("MANV", OracleDbType.Varchar2).Value = NV.Grantee();
                command.Parameters.Add("R_LSTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                // Execute the command and get the OracleDataReader
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(InforPrivs);

            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }
            return InforPrivs;
        }
    }


    public class USER_TAB_PRIVSDAO
    {
        public static DataTable LoadUserPrivs(USER_TAB_PRIVSDTO NV, OracleConnection cn)
        {
            DataTable InforPrivs = new DataTable();
            try
            {
                OracleCommand command = new OracleCommand("SYS.PR_USER_TAB", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("MANV", OracleDbType.Varchar2).Value = NV.Grantee();
                command.Parameters.Add("R_LSTS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                // Execute the command and get the OracleDataReader
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(InforPrivs);

            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine(ex.Message);
            }
            return InforPrivs;
        }
    }
}

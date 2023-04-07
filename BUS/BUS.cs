using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using DTO;
namespace BUS
{
    public class NhanvienBus
    {
        public static DataTable LoadUserLists(OracleConnection cn)
        {
            //NhanvienDAO NV = new NhanvienDAO();
            DataTable users_list;
            users_list = NhanvienDAO.LoadUserLists(cn);
            return users_list;
        }
    }
    public class DBA_ROLESBUS
    {
        public static DataTable LoadRoleLists(OracleConnection cn)
        {
            //DBA_ROLESDAO NV = new DBA_ROLESDAO();
            DataTable roles_list;
            roles_list = DBA_ROLESDAO.LoadRoleLists(cn);
            return roles_list;
        }

    }
    public class ROLE_TAB_PRIVSBUS
    {
        public static DataTable RolePrvis(string role, OracleConnection cn)
        {
            DataTable priLists = ROLE_TAB_PRIVSDAO.RolePrvis(role, cn);
            return priLists;
        }
    }
    public class DBA_ROLE_PRIVSBUS
    {
        public static DataTable LoadUserPrivs(DBA_ROLE_PRIVSDTO NV, OracleConnection cn)
        {
            DataTable dt;
            dt = DBA_ROLE_PRIVSDAO.LoadUserPrivs(NV, cn);
            return dt;
        }
    }
    public class USER_TAB_PRIVSBUS
    {
        public static DataTable LoadUserPrivs(USER_TAB_PRIVSDTO NV, OracleConnection cn)
        {
            DataTable dt;
            dt = USER_TAB_PRIVSDAO.LoadUserPrivs(NV, cn);
            return dt;
        }
    }
}

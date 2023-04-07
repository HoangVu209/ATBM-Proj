using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using BUS;
namespace ATBM_Proj.Resources.Forms
{
    public partial class Dashborad : Form
    {
        public Dashborad()
        {
            InitializeComponent();
        }
        private OracleConnection _cn;
        public Dashborad(OracleConnection cn)
        {
            _cn = cn;
            InitializeComponent();
            LoadUserList();
            LoadRoleList();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadUserList()
        {
            DataTable dataTable;
            dataTable = NhanvienBus.LoadUserLists(_cn);
            dtgUserList.DataSource = dataTable;
            dtgUserList.Columns[1].Width = 145;
            dtgUserList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 74);
            dtgUserList.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            dtgUserList.EnableHeadersVisualStyles = false;
            dtgUserList.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgUserList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void LoadRoleList()
        {
            DataTable dataTable;
            dataTable = DBA_ROLESBUS.LoadRoleLists(_cn);
            dtgListRoles.DataSource = dataTable;
            dtgListRoles.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 34, 74);
            dtgListRoles.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            dtgListRoles.EnableHeadersVisualStyles = false;
            dtgListRoles.Columns[4].Width = 54;
            dtgListRoles.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgListRoles.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

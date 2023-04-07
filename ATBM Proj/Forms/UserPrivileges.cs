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
using DTO;
using BUS;
using FontAwesome.Sharp;
namespace ATBM_Proj.Forms
{ 
    public partial class UserPrivileges : Form
    {

        private OracleConnection _con;
        public UserPrivileges(OracleConnection conn)
        {
            InitializeComponent();
            _con = conn;
            LoadUser();
            

        }

        private void LoadUser()
        {
            DataTable dt;
            dt = NhanvienBus.LoadUserLists(_con);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "MANV";
            comboBox1.ValueMember = "MANV";
            comboBox1.SelectedIndex = -1;

        }
        private void LoadRolePrivs()
        {
            DataTable dt;
            DBA_ROLE_PRIVSDTO t = new DBA_ROLE_PRIVSDTO(comboBox1.SelectedValue.ToString());
            dt = DBA_ROLE_PRIVSBUS.LoadUserPrivs(t, _con);
            dataGridView1.DataSource = dt;

        }
        private void LoadUserPrivs()
        {
            DataTable dt;
            USER_TAB_PRIVSDTO t = new USER_TAB_PRIVSDTO(comboBox1.SelectedValue.ToString());
            dt = USER_TAB_PRIVSBUS.LoadUserPrivs(t, _con);
            dataGridView2.DataSource = dt;

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadRolePrivs();
            LoadUserPrivs();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IconChar> iconChars = new List<IconChar>
            {
                IconChar.UserAlt,
                IconChar.Users,
                IconChar.PeopleArrows,
                IconChar.PeopleCarry,
                
                IconChar.PeopleCarryBox
          
            };

            // Tạo số nguyên ngẫu nhiên trong khoảng từ 0 đến số lượng IconChar có thể sử dụng
            int index = new Random().Next(iconChars.Count);
            // Gán IconChar tại vị trí ngẫu nhiên cho PictureBox
            iconPictureBox1.IconChar = iconChars[index];
        }
    }
}

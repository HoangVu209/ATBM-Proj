using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Oracle.ManagedDataAccess.Client;
namespace ATBM_Proj.Forms
{
    public partial class RolePrivileges : Form
    {
        private OracleConnection _con;
        public RolePrivileges(OracleConnection conn)
        {
            InitializeComponent();
            _con = conn;
            if (_con.State == ConnectionState.Closed)
            {
                _con.Open();
            }
            LoadComboBoxItems();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ ComboBox
            if (comboBox1.SelectedValue != null)
            {
                string selectedValue = comboBox1.SelectedValue.ToString();

                // Dựa vào giá trị được chọn để thiết lập hình ảnh cho PictureBox
                switch (selectedValue)
                {
                    case "NHANVIEN":
                        pictureBox.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
                        break;
                    case "NVTRUONGPHONG":
                        pictureBox.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
                        break;
                    case "NVTAICHINH":
                        pictureBox.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
                        break;
                    case "NVNHANSU":
                        pictureBox.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
                        break;
                    case "NVTRDA":
                        pictureBox.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
                        break;
                    default:
                        // Nếu không có giá trị nào phù hợp, xóa hình ảnh của PictureBox
                        pictureBox.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle; ;
                        break;
                }
            }
        }
  
        private void LoadComboBoxItems()
        {
            // Lấy DataTable từ đâu đó
            DataTable dt = DBA_ROLESBUS.LoadRoleLists(_con);
            
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ROLE";
            comboBox1.ValueMember = "ROLE";
            comboBox1.SelectedIndex = -1;
            // Thiết lập DisplayMember và ValueMember để ComboBox hiển thị và lấy dữ liệu

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string role = comboBox1.SelectedValue.ToString();
            DataTable priv = ROLE_TAB_PRIVSBUS.RolePrvis(role, _con);
            dtgRole.DataSource = priv;
            dtgRole.ForeColor = Color.Black;
        }
    }
}

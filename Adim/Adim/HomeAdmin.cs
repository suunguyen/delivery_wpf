using System.Data.SqlClient;
namespace Adim
{
    public partial class adminHome : Form
    {
        private SqlConnection conn;
        public adminHome(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void HomeAdminListAccount_Click(object sender, EventArgs e)
        {
            Form accountList = new XemDanhSachTaiKhoanAdmin(conn);
            accountList.Show();
            this.Hide();
        }

        private void HomeAdminThemTaiKhoan_Click(object sender, EventArgs e)
        {
            Form addAccount = new ThemTaiKhoanAdmin(conn);
            addAccount.Show();
            this.Hide();
        }

        private void HomeAdminXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form deleteAdmin = new XoaTaiKhoanAdmin(conn);
            deleteAdmin.Show();
        }
    }
}
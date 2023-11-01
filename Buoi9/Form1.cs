using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi9
{
    public partial class Form1 : Form
    {
        ketnoi kn = new ketnoi();
        SqlConnection connsql;
        public Form1()
        {
            InitializeComponent();
            connsql = kn.connect;

            PopulateMaPhieuNhapComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Now;
            string ngayHienTaiFormatted = ngayHienTai.ToString("dd-MM-yyyy");
            textBox_NgayNhap.Text = ngayHienTaiFormatted;

            Random random = new Random();
            int randomNumber = random.Next(10000000, 99999999);
            textBox_MaPhieuNhap.Text = "PN" + randomNumber.ToString("D8");
        }

        private void textBox_NgayNhap_TextChanged(object sender, EventArgs e)
        {

        }

        //kết nối sql
        public class ketnoi
        {
            public SqlConnection connect;
            public ketnoi()
            {
                connect = new SqlConnection("Data Source=LAPTOP-L0J0D79V\\WIPPOO;Initial Catalog=Net;Integrated Security=True");
            }
            public ketnoi(string strcn)
            {
                connect = new SqlConnection(strcn);
            }
        }

        private void button_TaoPhieuNhap_Click(object sender, EventArgs e)
        {
            string maPhieuNhap = textBox_MaPhieuNhap.Text;
            DateTime ngayNhap = DateTime.Parse(textBox_NgayNhap.Text); 
            string nhaCungCap = comboBox_NhaCungCap.Text;
            int thanhTien = int.Parse(textBox_ThanhTien.Text);
            
            using (SqlConnection connection = kn.connect)
            {
                connection.Open();
                
                string insertQuery = "INSERT INTO PhieuNhap (MaPhieuNhap, NgayNhap, Nhacungcap, ThanhTien) " +
                    "VALUES (@MaPhieuNhap, @NgayNhap, @Nhacungcap, @ThanhTien)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
                    command.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                    command.Parameters.AddWithValue("@Nhacungcap", nhaCungCap);
                    command.Parameters.AddWithValue("@ThanhTien", thanhTien);
                    
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dữ liệu đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm dữ liệu. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button_LuuPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void button_ThemSanPham_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox_MaPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_NhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_MaPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //phương thức để đổ dữ liệu vô comboBox_MaPhieuNhap
        private void PopulateMaPhieuNhapComboBox()
        {
            using (SqlConnection connection = kn.connect)
            {
                connection.Open();
                string query = "SELECT MaPhieuNhap FROM PhieuNhap";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string maPhieuNhap = reader["MaPhieuNhap"].ToString();
                            comboBox_MaPhieuNhap.Items.Add(maPhieuNhap);
                        }
                    }
                }
            }
        }
    }
}

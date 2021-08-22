using QuanLyCafe.Business.Component;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Presentation
{
    public partial class fm_quanlyban : Form
    {

        E_tb_BanCafe thucthi = new E_tb_BanCafe();
        // ConnectDB cn = new ConnectDB();

        public fm_quanlyban()
        {
            InitializeComponent();
        }

       

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            fm_thembanCafe fm = new fm_thembanCafe();
            fm.ShowDialog();
        }

        private void fm_quanlyban_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {



            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=QL_Quancaphe;Integrated Security=True";
            con.Open();



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM tb_Ban";
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ma = dt.Rows[i][0].ToString();
                string tenban = dt.Rows[i][1].ToString();
                string trangthai = dt.Rows[i][2].ToString();

                Button btnBanCF = new Button()
                {
                    Location = new Point(3, 3),
                    Name = "btnBanCF" + i,
                    Size = new System.Drawing.Size(85, 52),
                    TabIndex = 0,
                    Text = tenban,
                    UseVisualStyleBackColor = true,
                   
                };

                if (Convert.ToInt32(dt.Rows[i][2].ToString()) == 0)
                {
                    btnBanCF.BackColor = System.Drawing.Color.White;
                }
                else
                    btnBanCF.BackColor = System.Drawing.Color.Red;

                btnBanCF.Click += delegate (object sender, EventArgs e) { btnBanCF_Click(sender, e, ma,trangthai, MessageType.B1); };


                //AddLayoutPanel
                flowLayoutPanelDanhSachBan.Controls.Add(btnBanCF);

            }
           
        }

        private void btnBanCF_Click(object sender, EventArgs e, string ma,string trangthai, MessageType b1)
        {
            fm_TuyChon fm = new fm_TuyChon(ma,trangthai);
            fm.ShowDialog();
        }

        enum MessageType
        {
            B1,
            B2,
            B3
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDanhSachBan.Controls.Clear();

            loadData();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT_Project_NhomAnhSang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form FormChild;

        private void OpenFormChild(Form childFrom)
        {
            //nếu khởi tạo rồi thì đóng lại
            if (FormChild != null)
            {
                FormChild.Close();
            }
            FormChild = childFrom;
            childFrom.TopLevel = false; //Khi mà show lên thì vẫn thực hiện tiêp lên được form cha
            childFrom.FormBorderStyle = FormBorderStyle.None; //bỏ khung 
            childFrom.Dock = DockStyle.Fill; //Chèn đầy body
            pictureBox1.Controls.Add(childFrom); //them vao
            pictureBox1.Tag = childFrom; //chuyển dữ liệu 
            childFrom.BringToFront(); //Mang đến phía trước
            childFrom.Show(); //hiển thị
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormPrim());
        }
        private void label4_Click(object sender, EventArgs e)
        {
            if (FormChild != null)
            {
                FormChild.Close();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormInfo()); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormDijkstra()); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }
    }
}

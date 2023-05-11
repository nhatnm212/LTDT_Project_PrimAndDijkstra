using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTDT_Project_NhomAnhSang
{
    public partial class FormDijkstra : Form
    {
        bool ready = false;
        bool readyPoints = false;
        bool readyEdges = false;
        bool readySP = false;
        bool readyEP = false;
        bool displayDistances = false;
        bool displayRoad = false;

        // trang thai chuong trinh 
        bool running = false;
        bool fix = false;
        //  bool create = true;

        int numberPoints; // so diem
        int Edges;// so canh
        int startPoint;
        int endPoint;
        Point[] aPoint = new Point[21];// Luu danh sach diem
        int[,] MTK = new int[21, 21]; // ma tran ke 
        Mark[] history = new Mark[21]; 
        
        public FormDijkstra()
        {
            InitializeComponent();
        }
        
        // Chi gianh cho ve chi so diem va 2 dau mut cua 1 doan thang
        public Point CTD(Point pt)
        {
            int k = SanChoi.Height / 205;

            pt.X = pt.X * k + 5;
            pt.Y = pt.Y * k + 5;
            return pt;
        }

        // Tìm trung điểm của 1 đoạn thẳng
        public Point TrungDiem(int a, int b)
        {
            Point td = new Point();
            td.X = (aPoint[a].X + aPoint[b].X) / 2;
            td.Y = (aPoint[a].Y + aPoint[b].Y) / 2;
            return td;
        }

        private void SanChoi_Paint(object sender, PaintEventArgs e)
        {
            if (ready == false) return;
            // But dung de ve mui ten
            // Pen MuiTenPen = new Pen(Color.Red, 2);
            //MuiTenPen.StartCap = LineCap.RoundAnchor;
            //MuiTenPen.EndCap = LineCap.ArrowAnchor;


            //  bút có mũi tên
            Pen p = new Pen(Color.Blue, 2);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            p.CustomEndCap = bigArrow;

            // but khong mui ten
            Pen pen = new Pen(Color.Black, 1);


            Pen penStart = new Pen(Color.Blue, 4);
            Pen penEnd = new Pen(Color.Yellow, 4);

            // but : khi chua nhap 2 diem dau va cuoi (Điểm thường)
            SolidBrush br = new SolidBrush(Color.White);

            // but : chỉ nhap diem dau
            SolidBrush brStart = new SolidBrush(Color.GreenYellow);
            // but : chỉ nhap diem cuoi
            SolidBrush brEnd = new SolidBrush(Color.Purple);

            Graphics gr = SanChoi.CreateGraphics();
            // Ve duong di truoc
            if (readyEdges == true && readyPoints == true)
            {
                for (int h = 1; h <= numberPoints; h++)
                {
                    for (int k = 1; k <= numberPoints; k++)
                    {
                        if (MTK[h, k] != 0)

                            gr.DrawLine(pen, CTD(aPoint[h]), CTD(aPoint[k]));
                    }
                }
            }

            //Diem render sau
            if (readyPoints == true)
            {

                if (readySP == true && readyEP == false)
                {

                    for (int i = 1; i <= numberPoints; i++)
                    {
                        if (i == startPoint)
                        {
                            continue;

                        }
                        gr.FillEllipse(br, CTD(aPoint[i]).X - 5, CTD(aPoint[i]).Y - 5, 25, 25);
                        gr.DrawString(i + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[i]).X, CTD(aPoint[i]).Y);
                    }
                    // vẽ điểm đầu sau những điểm thường
                    gr.FillEllipse(brStart, CTD(aPoint[startPoint]).X - 5, CTD(aPoint[startPoint]).Y - 5, 25, 25);
                    gr.DrawString(startPoint + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[startPoint]).X, CTD(aPoint[startPoint]).Y);
                }
                else if (readySP == false && readyEP == true)
                {
                    for (int i = 1; i <= numberPoints; i++)
                    {
                        if (i == endPoint)
                        {
                            continue;

                        }
                        gr.FillEllipse(br, CTD(aPoint[i]).X - 5, CTD(aPoint[i]).Y - 5, 25, 25);
                        gr.DrawString(i + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[i]).X, CTD(aPoint[i]).Y);
                    }
                    // vẽ điểm cuối sau những điểm thường
                    gr.FillEllipse(brEnd, CTD(aPoint[endPoint]).X - 5, CTD(aPoint[endPoint]).Y - 5, 25, 25);
                    gr.DrawString(endPoint + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[endPoint]).X, CTD(aPoint[endPoint]).Y);
                }
                else if (readySP == true && readyEP == true)
                {
                    for (int i = 1; i <= numberPoints; i++)
                    {
                        if (i == startPoint || i == endPoint)
                        {
                            continue;

                        }
                        gr.FillEllipse(br, CTD(aPoint[i]).X - 5, CTD(aPoint[i]).Y - 5, 25, 25);
                        gr.DrawString(i + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[i]).X, CTD(aPoint[i]).Y);
                    }
                    // vẽ điểm đầu và điểm cuối sau những điểm thường
                    gr.FillEllipse(brStart, CTD(aPoint[startPoint]).X - 5, CTD(aPoint[startPoint]).Y - 5, 25, 25);
                    gr.DrawString(startPoint + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[startPoint]).X, CTD(aPoint[startPoint]).Y);

                    gr.FillEllipse(brEnd, CTD(aPoint[endPoint]).X - 5, CTD(aPoint[endPoint]).Y - 5, 25, 25);
                    gr.DrawString(endPoint + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[endPoint]).X, CTD(aPoint[endPoint]).Y);
                }
                else
                    for (int i = 1; i <= numberPoints; i++)
                    {

                        gr.FillEllipse(br, CTD(aPoint[i]).X - 5, CTD(aPoint[i]).Y - 5, 25, 25);
                        gr.DrawString(i + "", new Font("Consolas", 9), new SolidBrush(Color.Black), CTD(aPoint[i]).X, CTD(aPoint[i]).Y);
                    }
            }


            if (displayRoad == true && running == true)
            {
                int tempSau = endPoint;
                while (true)
                {

                    int tempTruoc = history[tempSau].DiemDiToi;
                    gr.DrawLine(p, CTD(aPoint[tempTruoc]), CTD(aPoint[tempSau]));

                    if (tempTruoc == startPoint) break;
                    tempSau = tempTruoc;

                }
                // displayRoad = false;
            }

            if (displayDistances == true)
            {
                Point tempPoint = new Point();
                for (int i = 1; i <= numberPoints; i++)
                {
                    for (int j = 1; j <= numberPoints; j++)
                    {
                        if (MTK[i, j] != 0)
                        {
                            tempPoint = TrungDiem(i, j);
                            //Hien thi do dai tai trung diem
                            gr.DrawString(MTK[i, j].ToString(), new Font("Consolas", 8), new SolidBrush(Color.DodgerBlue), CTD(tempPoint));
                        }
                    }

                }
            }
            // gr.DrawLine(MuiTenPen, CTD(aPoint[1]), CTD(aPoint[2]));

            //Graphics g = e.Graphics;
            ////g.SmoothingMode = SmoothingMode.AntiAlias;
            ////g.FillRectangle(Brushes.White, this.ClientRectangle);

            //Pen p = new Pen(Color.Black, 10);
            //p.StartCap = LineCap.Round;
            //p.EndCap = LineCap.ArrowAnchor;
            //g.DrawLine(p, 30, 30, 80, 30);
            //p.Dispose();
        }
        
        // Khoi tao ma tran ke
        public void cstA()
        {
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    MTK[i, j] = 0;
                }
            }
        }

        private void timer_edges_Tick(object sender, EventArgs e)
        {
            if (txtSoDiem.Text != null && txtSoDiem.Text != "")
            {
                int soDiem = int.Parse(txtSoDiem.Text);
                int soDC;
                if (soDiem == 0 || soDiem == 1) lbEdges.Text = "Error";
                else if (soDiem == 2) lbEdges.Text = "1";
                else
                {
                    soDC = soDiem + soDiem * (soDiem - 3) / 2;
                    lbEdges.Text = soDC.ToString();
                }
            }
            else
            {
                lbEdges.Text = "0";
            }
        }

        //Kiểm tra điểm vừa tạo có trùng với điểm trước đó hay không,cập nhật điểm trực tiếp
        public void TaoDiem(int stt)
        {
            Random rd = new Random();
            //  Point kq = new Point();
            bool OK = true;
            int temp;
            if (stt == 1)
            {
                aPoint[1].X = rd.Next(0, 200);
                aPoint[1].Y = rd.Next(0, 200);
                return;

            }
            while (true)
            {
                aPoint[stt].X = rd.Next(0, 200);
                aPoint[stt].Y = rd.Next(0, 200);
                for (int i = 1; i < stt; i++)
                {
                    temp = KhoangCach(i, stt);
                    if (temp == 0)
                    {

                        OK = false;
                        break;
                    }
                }
                if (OK == true) break;
            }
        }

        private void btCreatePoints_Click(object sender, EventArgs e)
        {
            // Nút chỉ hoạt động nếu chương trình chưa chạy, ở chế độ khởi tạo
            if (running == true || fix == true) return;


            // ngoai lệ
            if (txtSoDiem.Text == "")
            {
                return;
            }
            if (int.Parse(txtSoDiem.Text) > 20)
            {
                string message = "Nhập vào số điểm không quá 20";
                string caption = "Nhập sai dữ liệu";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }





            readyPoints = true;
            btState1.BackColor = Color.Lime;

            numberPoints = int.Parse(txtSoDiem.Text);
            Random rd = new Random();
            int t = 1;
            while (true)
            {
                if (t > numberPoints) break;
                //    TaoDiem(t);
                aPoint[t].X = rd.Next(0, 200);
                aPoint[t].Y = rd.Next(0, 200);

                t++;
            }

            ready = true;
            SanChoi.Invalidate();
            SanChoi.Refresh();
        }

        //tính độ dài từ điểm a tới điểm b
        public int KhoangCach(int a, int b)
        {
            int d = 0;
            d = Convert.ToInt32(Math.Sqrt((aPoint[a].X - aPoint[b].X) * (aPoint[a].X - aPoint[b].X) + (aPoint[a].Y - aPoint[b].Y) * (aPoint[a].Y - aPoint[b].Y)));
            return d;
        }

        private void btCreateEs_Click(object sender, EventArgs e)
        {
            // Nút chỉ hoạt động nếu chương trình chưa chạy, ở chế độ khởi tạo
            if (running == true) return;

            //bắt ngoại lệ
            if (readyPoints == false)
            {
                string message = "Nhập và khởi tạo SỐ ĐIỂM trước !";
                string caption = "Lỗi thiếu đầu vào";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }
            // ngoai lệ
            if (txtSoDuong.Text == "")
            {
                return;
            }




            Edges = int.Parse(txtSoDuong.Text);
            // khoi tao lai ma tran ke
            cstA();
            Random rd2 = new Random();
            int x, y, d;
            // Cac diem dau va cuoi khong trung nhau, canh k dc lap lai
            int t = 0;
            while (true)
            {
                if (t == Edges) break;
                x = rd2.Next(1, numberPoints + 1); // Ham random(x,y) chỉ chay tu x-> (y-1) nên cộng thêm 1 đơn vị 
                y = rd2.Next(1, numberPoints + 1);
                if (MTK[x, y] != 0 || x == y) continue;
                d = KhoangCach(x, y);
                MTK[x, y] = d;
                MTK[y, x] = d;
                t++;


            }

            readyEdges = true;
            btnState2.BackColor = Color.Lime;

            // nếu trạng thái chương trình là đang sửa thì chạy lại thuật toán
            if (fix == true)
            {
                ChayChuongTrinh();
            }

            ready = true;
            SanChoi.Invalidate();
            SanChoi.Refresh();
        }

        private void btCreateSP_Click(object sender, EventArgs e)
        {
            // Nút chỉ hoạt động nếu chương trình chưa chạy, ở chế độ khởi tạo
            if (running == true && fix == false) return;

            // bắt ngoại lệ
            if (readyPoints == false)
            {
                string message = "Nhập và tạo SỐ ĐIỂM trước!";
                string caption = "Lỗi thiếu đầu vào";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }

            if (txtStartPoint.Text == "")
            {
                return;
            }


            startPoint = int.Parse(txtStartPoint.Text);
            readySP = true;
            btnState3.BackColor = Color.Lime;
            if (fix == true) ChayChuongTrinh();

            ready = true;
            SanChoi.Invalidate();
            SanChoi.Refresh();
        }

        private void btCreateEP_Click(object sender, EventArgs e)
        {
            // Nút chỉ hoạt động nếu chương trình chưa chạy, ở chế độ khởi tạo
            if (running == true && fix == false) return;

            // bắt ngoại lệ
            if (readyPoints == false)
            {
                string message = "Nhập và tạo SỐ ĐIỂM trước!";
                string caption = "Lỗi thiếu đầu vào";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }
            if (txtEndPoint.Text == "")
            {
                return;
            }

            endPoint = int.Parse(txtEndPoint.Text);
            readyEP = true;
            btnState4.BackColor = Color.Lime;
            if (fix == true) ChayChuongTrinh();

            ready = true;
            SanChoi.Invalidate();
            SanChoi.Refresh();
        }

        // Điều kiện đê nút kết quả thực hiện
        public bool AllReady()
        {
            if (readyPoints == true && readyEdges == true && readySP == true && readyEP == true)
            {
                return true;
            }
            else return false;
        }
        // Khởi tạo full history
        public void resetHistory()
        {
            for (int i = 0; i <= 20; i++)
            {
                history[i] = new Mark();
            }
        }
        public void ChayChuongTrinh()
        {
            // Điều kiện để chạy chương trình
            if (AllReady() == false && running == true)
            {
                string message = "Nhập đầy đủ thông tin đầu vào";
                string caption = "Lỗi đầu vào";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }
            // Khóa lại không cho sửa chữa
            if (running == true)
            {
                txtEndPoint.Enabled = false;
                txtSoDiem.Enabled = false;
                txtSoDuong.Enabled = false;
                txtStartPoint.Enabled = false;
            }

            // Ngăn chặn việc cac nut reset, đưa chương trình về trạng thái đang chạy
            running = true;
            lblStatusPro.Text = "Đang chạy";


            resetHistory();

            // Khởi tạo các điểm trong history và điểm bắt đầu
            for (int i = 1; i <= numberPoints; i++)
            {
                history[i].DiemDiToi = startPoint;

            }
            history[startPoint].DoDai = 0;
            history[startPoint].DiemDiToi = startPoint;
            history[startPoint].DaDuyet = true;

            // xu ly
            int tempMark = startPoint;
            int sum = 0;
            while (true)
            {

                // tinh do dai den cac diem ke cua diem hien tai tempMark
                for (int i = 1; i <= numberPoints; i++)
                {
                    if (history[i].DaDuyet == true) continue;

                    // neu chua Duyet ta xem co ke hay khong
                    if (MTK[i, tempMark] != 0)
                    {
                        if (history[i].DaDuyet == false) sum++;
                        if (history[i].DoDai == -1 || history[tempMark].DoDai + MTK[i, tempMark] < history[i].DoDai)
                        {
                            history[i].DoDai = history[tempMark].DoDai + MTK[i, tempMark];
                            history[i].DiemDiToi = tempMark;
                        }


                    }

                }

                // Tim ra diem be nhat duoc chon
                //  sum = 0;
                int dMin = 1000000;
                int tempi = 0;
                int tiepTuc = 0;
                for (int i = 1; i <= numberPoints; i++)
                {
                    if (history[i].DaDuyet == true || history[i].DoDai == -1) continue;

                    if (history[i].DoDai < dMin)
                    {
                        dMin = history[i].DoDai;
                        tempi = i;
                        tiepTuc++;
                    }

                }

                if (tiepTuc == 0) break;
                // danh dau va cap nhat lai diem duoc chon
                // history[tempi].DiemDiToi = tempMark;
                history[tempi].DaDuyet = true;
                tempMark = tempi;
                if (tempMark == endPoint) break;



            } // ket thuc while

            // Dua ra ket qua

            if (running == true && fix == false)
            {
                if (history[endPoint].DoDai == -1)
                {
                    rtbHienThi.Text = "không tồn tại đường đi từ điểm " + startPoint + " tới điểm " + endPoint;
                }
                else
                {
                    rtbHienThi.Text = "Độ dài nhỏ nhất từ điểm " + startPoint + " đến điểm " + endPoint + " là: " + history[endPoint].DoDai;
                    displayRoad = true;

                }
            }


            // nếu chương trình đang ở chế độ chạy để sửa ta sẽ đổi lại running 
            if (fix == true)
                running = false;
            SanChoi.Invalidate();
            SanChoi.Refresh();
        }

        // MAIN : KẾT QUẢ SAU KHI TÌM KIẾM ĐƯỜNG ĐI 
        private void btnKetQua_Click(object sender, EventArgs e)
        {
            // điều kiện đầu vào
            // Điều kiện để chạy chương trình
            if (AllReady() == false)
            {
                string message = "Nhập đầy đủ thông tin đầu vào";
                string caption = "Lỗi đầu vào";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }

            // Nút chỉ hoạt động nếu chương trình chưa chạy, ở chế độ khởi tạo

            if (running == true) return;
            running = true;
            if (fix == true)
                fix = false;

            ChayChuongTrinh();
        }

        private void btnDisplayKC_Click(object sender, EventArgs e)
        {
            // ném ngoại lệ
            if (readyPoints == false || readyEdges == false)
            {
                string message = "Nhập đầy đủ SỐ ĐIỂM và SỐ ĐƯỜNG NỐI !";
                string caption = "Lỗi thiếu đầu vào";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                return;
            }

            if (displayDistances == true) displayDistances = false;
            else displayDistances = true;

            ready = true;
            SanChoi.Invalidate();
            SanChoi.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset đầu vào tại giao diện
            txtEndPoint.Text = "";
            txtEndPoint.Enabled = true;
            txtSoDiem.Text = "";
            txtSoDiem.Enabled = true;
            txtSoDuong.Text = "";
            txtSoDuong.Enabled = true;
            txtStartPoint.Text = "";
            txtStartPoint.Enabled = true;
            rtbHienThi.Text = "";
            rtbHienThi.Enabled = true;

            //Đưa chương trình về trạng thái ban đầu (not running)
            running = false;
            fix = false;
            // create = true;


            // reset cơ sở dữ liệu
            ready = false;
            readyPoints = false;
            readyEdges = false;
            readySP = false;
            readyEP = false;
            displayDistances = false;
            displayRoad = false;

            //reset lại ma trận kề, history[]
            cstA();

            // rest lại đèn bao hiệu
            btnState2.BackColor = Color.LightGray;
            btState1.BackColor = Color.LightGray;
            btnState3.BackColor = Color.LightGray;
            btnState4.BackColor = Color.LightGray;
            lblStatusPro.Text = "Khởi tạo";

            SanChoi.Refresh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //xét trạng thái của chương trình, nếu nó đang chạy mới cho sửa
            if (running == false)
            {
                // thông báo
                string message = "Thao tác Sửa chỉ sử dụng khi chương trình đang chạy !";
                string caption = "Lưu ý !";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                return;
            }
            // set lại trạng thái chương trình
            lblStatusPro.Text = "Sửa";
            fix = true;
            running = false;
            // thay doi trang thai cac nut khoi tao
            btnState2.BackColor = Color.Yellow;
            btnState3.BackColor = Color.Yellow;
            btnState4.BackColor = Color.Yellow;

            // enable lại txt nhập đầu vào
            txtEndPoint.Enabled = true;
            txtSoDuong.Enabled = true;
            txtStartPoint.Enabled = true;
            rtbHienThi.Text = "";
            //  sua ready
            //readyEdges = false;
            //readyEP = false;
            //readySP = false;
        }
    }
}


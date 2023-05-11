using System;
using System.Collections.Generic;
using System.Text;

namespace LTDT_Project_NhomAnhSang
{
    public class Prim
    {
        public struct GRAPH
        {
            public int soDinh; 
            public int[,] maTran; 
            public int[] visited; // đánh dấu đỉnh i đã xét hay chưa, nếu 0 là chưa xét 

            public GRAPH(int soDinh)
            {
                this.soDinh = soDinh;
                this.maTran = new int[100, 100];
                this.visited = new int[100]; 
            }
        }
        public struct CANH
        {
            public int u; // Đỉnh thứ nhất 
            public int v; // Đỉnh thứ hai 
            public int trongSo; 
        }
        CANH[] T = new CANH[100]; // Mảng lưu các cạnh trong Prim 
        // Bước 1: Gán số cạnh của cây khung ban đầu = 0 
        int nT = 0; 
        public void DuyetPrim(GRAPH g)
        {
            // Bước 2: Khởi tạo nhãn các đỉnh là chưa duyệt (0) 
            for (int i = 0; i < g.soDinh; i++)
            {
                g.visited[i] = 0; 
            }
            // Bước 3: Đánh dấu đỉnh 0 là đã duyệt 
            g.visited[0] = 1; 
            // Nếu đủ n-1 cạnh thì dừng lại 
            while (nT < g.soDinh - 1) 
            {
                // Tạo canhNhoNhat để lưu cạnh nhỏ nhất từ 1 đỉnh đã xét đến đỉnh chưa xét 
                CANH canhNhoNhat = new CANH(); 
                int min = -1; 
                for (int i = 0; i < g.soDinh; i++)
                {
                    // Nếu là đỉnh chưa xét 
                    if (g.visited[i] == 0)
                    {
                        for (int j = 0; j < g.soDinh; j++)
                        {
                            if (g.visited[j] == 1 && (g.maTran[i, j] != 0))
                            {
                                if (min == -1 || g.maTran[i, j] < min)
                                {
                                    min = g.maTran[i, j];
                                    canhNhoNhat.u = i;
                                    canhNhoNhat.v = j;
                                    canhNhoNhat.trongSo = g.maTran[i, j];
                                }
                            }
                        }
                    }
                }
                // Thêm cạnh nhỏ nhất vào tập T 
                T[nT] = canhNhoNhat; 
                // Tăng số cạnh lên 1 
                nT++; 
                g.visited[canhNhoNhat.u] = 1; 
            }
        }
        // Xuất kết quả cây khung nhỏ nhất của đồ thị 
        public string ketQuaChay(GRAPH g)
        {
            DuyetPrim(g); 
            string tmp = "";
            string kq = "";
            for (int i = 0; i < nT; i++)
            {
                int _v = T[i].v + 1;
                int _u = T[i].u + 1;
                tmp = "(" + _v + "," + _u + ")\r\n";
                if (tmp != "(1,1)\r\n")
                    kq += tmp; 
            }
            return kq;
        }
        // Xuất tổng giá trị của cây 
        public string tongGiaTri(GRAPH g)
        {
            DuyetPrim(g);
            int sum = 0;
            for (int i = 0; i < nT; i++)
            {
                sum += T[i].trongSo;
            }
            return Convert.ToString(sum);
        }
        public string luuv(GRAPH g)
        {
            DuyetPrim(g);
            string tmp = "";
            string kq = "";
            for (int i = 0; i < nT; i++)
            {
                int _v = T[i].v;
                tmp = _v + "\r\n";
                kq += tmp;
            }
            return kq;
        }
        public string luuu(GRAPH g)
        {
            DuyetPrim(g);
            string tmp = "";
            string kq = "";
            for (int i = 0; i < nT; i++)
            {
                int _u = T[i].u;
                tmp = _u + "\r\n";
                kq += tmp;
            }
            return kq;
        }
    }
}

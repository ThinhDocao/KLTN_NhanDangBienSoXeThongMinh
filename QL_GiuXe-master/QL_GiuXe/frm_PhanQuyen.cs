using DevExpress.XtraGrid;
using QL_GiuXe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_PhanQuyen : Form
    {
        public frm_PhanQuyen()
        {
            InitializeComponent();
            PhanQuyen_NguoiDung.Instance.LoadPQ();
            if(PhanQuyen_NguoiDung.Instance.Quyen_PhanQuyenNhanVien =="Xem")
            {
                btnSave.Enabled = false;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView2.OptionsBehavior.ReadOnly = true;
                gridVPQ.OptionsBehavior.ReadOnly = true;
                gridView4.OptionsBehavior.ReadOnly = true;
            }
        }
        DataTable data,DT;
        private void PQ_Load(object sender, EventArgs e)
        {



            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                var query = (from a in db.NhanViens
                             join b in db.NhanVien_ChucVus
                             on a.MaNV equals b.MaNV
                             join c in db.ChucVus
                             on b.MaCV equals c.MaCV
                             where b.MaCV=="CV001"
                             select new
                             {
                                 a.MaNV,a.TenNV,c.TenCV,a.NgayTao
                             }).OrderByDescending(x => x.NgayTao).ToList();
                
                glueNV.Properties.DataSource = query;
                glueNV.Properties.DisplayMember = "TenNV";
                glueNV.Properties.ValueMember = "MaNV";


                DT = new DataTable();
                DT.Clear();
                DT.Columns.Add("MaCV");
                DT.Columns.Add("TenCV");
                DT.Columns.Add("GhiChu");
                var queryCV = db.ChucVus.ToList();
                foreach (var item in queryCV)
                {

                    Object[] O = { item.MaCV,item.TenCV,item.GhiChu};

                    DT.Rows.Add(O);

                }
                gridCV.DataSource = DT;

                txtMaCV.DataBindings.Add(new Binding("Text", gridCV.DataSource, "MaCV"));

                txtMaCV.Visible = false;
            }

        }

        

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridView1.FocusedColumn.ColumnHandle > 2)
            {
                for (int i = 3; i <= 8; i++)
                {
                    //MessageBox.Show(gridView1.GetFocusedDataSourceRowIndex().ToString());
                    //MessageBox.Show(i.ToString());
                    data.Rows[gridView1.GetFocusedDataSourceRowIndex()][i] = 10;
                }

                data.Rows[gridView1.GetFocusedDataSourceRowIndex()][gridView1.FocusedColumn.ColumnHandle] = 1;

                gridControl1.DataSource = data;
                
            }


        }

        private void glueNV_EditValueChanged(object sender, EventArgs e)
        {
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                var load = (from a in db.NhanViens
                            join b in db.NhanVien_NhomNguoiDungs
                            on a.MaNV equals b.MaNV
                            where a.MaNV == b.MaNV
                            join c in db.ChiTietQuyens
                            on b.MaCTQuyen equals c.MaCTQuyen
                            where b.MaCTQuyen == c.MaCTQuyen
                            join d in db.PhanQuyen_NhomNguoiDungs
                            on b.PQ_NND equals d.PQ_NND
                            where b.PQ_NND == d.PQ_NND
                            join ee in db.NhomNguoiDungs
                            on d.MaNhom equals ee.MaNhom
                            where d.MaNhom == ee.MaNhom
                            join f in db.PhanQuyens
                            on d.MaQuyen equals f.MaQuyen /*new {A=d.MaQuyen } equals new {A=f.MaQuyen}*/
                            where a.MaNV == glueNV.EditValue.ToString()
                            select new
                            {
                                a.MaNV,
                                a.TenNV,
                                f.TenQuyen,
                                ee.TenNhom,
                                c.TenCTQuyen,
                                d.PQ_NND
                            }).ToList();











                var pqs = (from a in db.PhanQuyens
                           join b in db.PhanQuyen_NhomNguoiDungs on a.MaQuyen equals b.MaQuyen
                           join c in db.NhomNguoiDungs on b.MaNhom equals c.MaNhom
                           select new
                           {
                               PQ_NND = b.PQ_NND,
                               TenNhom = c.TenNhom,
                               TenQuyen = a.TenQuyen,
                           }).ToList();

                data = new DataTable();
                data.Columns.Add("PQ_NND");
                data.Columns.Add("TenNhom");
                data.Columns.Add("TenQuyen");
                data.Columns.Add("MCTQ001", typeof(int));
                data.Columns.Add("MCTQ002", typeof(int));
                data.Columns.Add("MCTQ003", typeof(int));
                data.Columns.Add("MCTQ004", typeof(int));
                data.Columns.Add("MCTQ005", typeof(int));
                data.Columns.Add("MCTQ006", typeof(int));

                foreach (var item in pqs)
                {
                    int t = 0;
                    foreach (var itemPq in load)
                    {
                        if(item.TenNhom ==itemPq.TenNhom && item.TenQuyen ==itemPq.TenQuyen && item.PQ_NND==itemPq.PQ_NND)
                        {
                            if(itemPq.TenCTQuyen== "Cấm")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 1, 0, 0, 0, 0, 0 };
                                data.Rows.Add(K);
                                t = 1;
                            }
                            else if(itemPq.TenCTQuyen== "Xem")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 1, 0, 0, 0, 0 };
                                data.Rows.Add(K);
                                t = 1;
                            }
                            else if(itemPq.TenCTQuyen== "Sửa")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 1, 0, 0, 0 };
                                data.Rows.Add(K);
                                t = 1;
                            }
                            else if(itemPq.TenCTQuyen== "Thêm")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 0, 1, 0, 0 };
                                data.Rows.Add(K);
                                t = 1;

                            }
                            else if(itemPq.TenCTQuyen== "Sửa và xóa")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 0, 0, 1, 0 };
                                data.Rows.Add(K);
                                t = 1;
                            }
                            else
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 0, 0, 0, 1 };
                                data.Rows.Add(K);
                                t = 1;
                            }
                            
                        }
                    }
                    if(t!=1)
                    {
                        Object[] O = { item.PQ_NND, item.TenNhom, item.TenQuyen, 1, 0, 0, 0, 0, 0 };
                        data.Rows.Add(O);
                    }
                    
                }
                gridControl1.DataSource = data;


                //    var model = pqs.Select(pq => new PhanQuyenModel
                //    {
                //        TenNhom = pq.TenNhom,
                //        TenQuyen = pq.TenQuyen,
                //        PQ_NND = pq.PQ_NND
                //}).ToList();
                //    DataTable data = new DataTable();

                //    gridControl1.DataSource = data;



                TenNhom.GroupIndex = 0;

                gridView1.OptionsView.ShowGroupedColumns = true;


                GridGroupSummaryItem countt = new GridGroupSummaryItem();
                countt.FieldName = TenNhom.FieldName;
                countt.DisplayFormat = "";
                countt.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridView1.GroupSummary.Clear();
                gridView1.GroupSummary.Add(countt);
                

                gridView1.ExpandAllGroups();
                TenQuyen.BestFit();


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(gridView1.GetFocusedDataSourceRowIndex().ToString());
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                for (int i = 0; i < db.PhanQuyens.Count(); i++)
                {
                    gridView1.FocusedRowHandle = i;
                    for(int j=3;j<=8;j++)
                    {
                        if(data.Rows[gridView1.GetFocusedDataSourceRowIndex()][j].ToString() == "1")
                        {
                            data.Rows[gridView1.GetFocusedDataSourceRowIndex()][j] = 1;
                            break;
                        }
                    }
                    //if(data.Rows[gridView1.GetFocusedDataSourceRowIndex()][3].ToString() != "1")
                    //{
                    //    if()
                    //}
                    //MessageBox.Show(data.Rows[gridView1.GetFocusedDataSourceRowIndex()][3].ToString());   
                    //MessageBox.Show("" + gridView1.GetRowCellDisplayText(i,"MCTQ001"));
                    //if(gridView1.GetRowCellDisplayText(i, "MCTQ001")!="1")
                    //{
                    //    MessageBox.Show("" + gridView1.GetDataSourceRowIndex(i));


                    //    MessageBox.Show("" + gridView1.GetFocusedDataSourceRowIndex());
                    //    MessageBox.Show(data.Rows[i]["MCTQ001"].ToString());
                    //}
                    
                }

                foreach (DataRow item in data.Rows)
                {
                    var aaa = db.NhanVien_NhomNguoiDungs.Where(x => x.PQ_NND.Equals(item["PQ_NND"].ToString()) && x.MaNV.Equals(glueNV.EditValue.ToString())).SingleOrDefault();
                    
                    NhanVien_NhomNguoiDung NV_NND = new NhanVien_NhomNguoiDung();
                    int i = 1;
                    if (aaa==null)
                        
                    
                    {
                        
                        NV_NND.MaNV = glueNV.EditValue.ToString();
                        NV_NND.PQ_NND = item["PQ_NND"].ToString();

                        while(1!=0)
                        {
                            if(item["MCTQ00"+i.ToString()].ToString()=="1")
                            {
                                NV_NND.MaCTQuyen = "MCTQ00" + i.ToString();
                                break;
                            }
                            i++;
                        }
                        NV_NND.GhiChu = "Thêm mới ngày : "+DateTime.Now;
                        db.NhanVien_NhomNguoiDungs.InsertOnSubmit(NV_NND);
                        db.SubmitChanges();
                       
                    }
                    
                    else
                    {
                        


                        NhanVien_NhomNguoiDung edit = db.NhanVien_NhomNguoiDungs.Where(x => x.MaNV.Equals(glueNV.EditValue.ToString()) && x.PQ_NND.Equals(item["PQ_NND"].ToString())).SingleOrDefault();


                        while (1 != 0)
                        {
                            
                            if (item["MCTQ00" + i.ToString()].ToString() == "1")
                            {
                                if(edit.MaCTQuyen == ("MCTQ00" + i.ToString()))
                                {
                                    break;
                                }
                                edit.MaCTQuyen = "MCTQ00" + i.ToString();
                                break;
                            }
                            i++;
                        }
                        edit.GhiChu = "Đã sửa ngày: "+DateTime.Now;
                        
                        
                        db.SubmitChanges();


                    }

                    //MessageBox.Show("PQ_NND : " + item["PQ_NND"].ToString() + " -- TenNhom: "+item["TenNhom"].ToString()
                    //    +"--  TenQuyen : "+item["TenQuyen"].ToString()
                    //    +"-- MCTQ001: "+item["MCTQ001"].ToString()
                    //    +"-- MCTQ002: "+item["MCTQ002"].ToString()
                    //    +"-- MCTQ003: "+item["MCTQ004"].ToString()
                    //    +"-- MCTQ005: "+item["MCTQ005"].ToString()
                    //    +"-- MCTQ006: "+item["MCTQ006"].ToString());
                }

            }
            MessageBox.Show("Lưu thành công");

                
        }

        DataTable dataPQ;

        private void gridVPQ_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridVPQ.FocusedColumn.ColumnHandle > 2)
            {
                for (int i = 3; i <= 8; i++)
                {
                    //MessageBox.Show(gridView1.GetFocusedDataSourceRowIndex().ToString());
                    //MessageBox.Show(i.ToString());
                    dataPQ.Rows[gridVPQ.GetFocusedDataSourceRowIndex()][i] = 10;
                }

                dataPQ.Rows[gridVPQ.GetFocusedDataSourceRowIndex()][gridVPQ.FocusedColumn.ColumnHandle] = 1;

                gridPQ.DataSource = dataPQ;

            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            //{
            //    for (int i = 0; i < db.PhanQuyens.Count(); i++)
            //    {
            //        gridVPQ.FocusedRowHandle = i;
            //        for (int j = 3; j <= 8; j++)
            //        {
            //            if (dataPQ.Rows[gridVPQ.GetFocusedDataSourceRowIndex()][j].ToString() == "1")
            //            {
            //                dataPQ.Rows[gridVPQ.GetFocusedDataSourceRowIndex()][j] = 1;
            //                break;
            //            }
            //        }
            //        //if(data.Rows[gridView1.GetFocusedDataSourceRowIndex()][3].ToString() != "1")
            //        //{
            //        //    if()
            //        //}
            //        //MessageBox.Show(data.Rows[gridView1.GetFocusedDataSourceRowIndex()][3].ToString());   
            //        //MessageBox.Show("" + gridView1.GetRowCellDisplayText(i,"MCTQ001"));
            //        //if(gridView1.GetRowCellDisplayText(i, "MCTQ001")!="1")
            //        //{
            //        //    MessageBox.Show("" + gridView1.GetDataSourceRowIndex(i));


            //        //    MessageBox.Show("" + gridView1.GetFocusedDataSourceRowIndex());
            //        //    MessageBox.Show(data.Rows[i]["MCTQ001"].ToString());
            //        //}

            //    }

            //    foreach (DataRow item in dataPQ.Rows)
            //    {
            //        var aaa = db.ChucVu_PhanQuyens.Where(x => x.PQ_NND.Equals(item["PQ_NND"].ToString()) && x.MaCV.Equals(txtMaCV.Text)).SingleOrDefault();

            //        ChucVu_PhanQuyen NV_NND = new ChucVu_PhanQuyen();
            //        int i = 1;
            //        if (aaa == null)
            //        {
            //            NV_NND.ChucVu_PQ = Guid.NewGuid().ToString();
            //            NV_NND.MaCV = txtMaCV.Text;
            //            NV_NND.PQ_NND = item["PQ_NND"].ToString();

            //            while (1 != 0)
            //            {
            //                if (item["MCTQ00" + i.ToString()].ToString() == "1")
            //                {
            //                    NV_NND.MaCTQuyen = "MCTQ00" + i.ToString();
            //                    break;
            //                }
            //                i++;
            //            }

            //            db.ChucVu_PhanQuyens.InsertOnSubmit(NV_NND);
            //            db.SubmitChanges();


            //        }

            //        else
            //        {



            //            ChucVu_PhanQuyen edit = db.ChucVu_PhanQuyens.Where(x => x.MaCV.Equals(txtMaCV.Text) && x.PQ_NND.Equals(item["PQ_NND"].ToString())).SingleOrDefault();


            //            while (1 != 0)
            //            {

            //                if (item["MCTQ00" + i.ToString()].ToString() == "1")
            //                {
            //                    if (edit.MaCTQuyen == ("MCTQ00" + i.ToString()))
            //                    {
            //                        break;
            //                    }
            //                    edit.MaCTQuyen = "MCTQ00" + i.ToString();
            //                    break;
            //                }
            //                i++;
            //            }
            //            //edit.GhiChu = "Đã sửa ngày: " + DateTime.Now;


            //            db.SubmitChanges();


            //        }

            //        //MessageBox.Show("PQ_NND : " + item["PQ_NND"].ToString() + " -- TenNhom: "+item["TenNhom"].ToString()
            //        //    +"--  TenQuyen : "+item["TenQuyen"].ToString()
            //        //    +"-- MCTQ001: "+item["MCTQ001"].ToString()
            //        //    +"-- MCTQ002: "+item["MCTQ002"].ToString()
            //        //    +"-- MCTQ003: "+item["MCTQ004"].ToString()
            //        //    +"-- MCTQ005: "+item["MCTQ005"].ToString()
            //        //    +"-- MCTQ006: "+item["MCTQ006"].ToString());
            //    }


                


            //}
            //MessageBox.Show("Lưu thành công");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSaveCV_Click(object sender, EventArgs e)
        {
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                for (int i = 0; i < db.PhanQuyens.Count(); i++)
                {
                    gridVPQ.FocusedRowHandle = i;
                    for (int j = 3; j <= 8; j++)
                    {
                        if (dataPQ.Rows[gridVPQ.GetFocusedDataSourceRowIndex()][j].ToString() == "1")
                        {
                            dataPQ.Rows[gridVPQ.GetFocusedDataSourceRowIndex()][j] = 1;
                            break;
                        }
                    }
                    //if(data.Rows[gridView1.GetFocusedDataSourceRowIndex()][3].ToString() != "1")
                    //{
                    //    if()
                    //}
                    //MessageBox.Show(data.Rows[gridView1.GetFocusedDataSourceRowIndex()][3].ToString());   
                    //MessageBox.Show("" + gridView1.GetRowCellDisplayText(i,"MCTQ001"));
                    //if(gridView1.GetRowCellDisplayText(i, "MCTQ001")!="1")
                    //{
                    //    MessageBox.Show("" + gridView1.GetDataSourceRowIndex(i));


                    //    MessageBox.Show("" + gridView1.GetFocusedDataSourceRowIndex());
                    //    MessageBox.Show(data.Rows[i]["MCTQ001"].ToString());
                    //}

                }

                foreach (DataRow item in dataPQ.Rows)
                {
                    var aaa = db.ChucVu_PhanQuyens.Where(x => x.PQ_NND.Equals(item["PQ_NND"].ToString()) && x.MaCV.Equals(txtMaCV.Text)).SingleOrDefault();

                    ChucVu_PhanQuyen NV_NND = new ChucVu_PhanQuyen();
                    int i = 1;
                    if (aaa == null)
                    {
                        NV_NND.ChucVu_PQ = Guid.NewGuid().ToString();
                        NV_NND.MaCV = txtMaCV.Text;
                        NV_NND.PQ_NND = item["PQ_NND"].ToString();

                        while (1 != 0)
                        {
                            if (item["MCTQ00" + i.ToString()].ToString() == "1")
                            {
                                NV_NND.MaCTQuyen = "MCTQ00" + i.ToString();
                                break;
                            }
                            i++;
                        }

                        db.ChucVu_PhanQuyens.InsertOnSubmit(NV_NND);
                        db.SubmitChanges();


                    }

                    else
                    {



                        ChucVu_PhanQuyen edit = db.ChucVu_PhanQuyens.Where(x => x.MaCV.Equals(txtMaCV.Text) && x.PQ_NND.Equals(item["PQ_NND"].ToString())).SingleOrDefault();


                        while (1 != 0)
                        {

                            if (item["MCTQ00" + i.ToString()].ToString() == "1")
                            {
                                if (edit.MaCTQuyen == ("MCTQ00" + i.ToString()))
                                {
                                    break;
                                }
                                edit.MaCTQuyen = "MCTQ00" + i.ToString();
                                break;
                            }
                            i++;
                        }
                        //edit.GhiChu = "Đã sửa ngày: " + DateTime.Now;


                        db.SubmitChanges();


                    }

                    //MessageBox.Show("PQ_NND : " + item["PQ_NND"].ToString() + " -- TenNhom: "+item["TenNhom"].ToString()
                    //    +"--  TenQuyen : "+item["TenQuyen"].ToString()
                    //    +"-- MCTQ001: "+item["MCTQ001"].ToString()
                    //    +"-- MCTQ002: "+item["MCTQ002"].ToString()
                    //    +"-- MCTQ003: "+item["MCTQ004"].ToString()
                    //    +"-- MCTQ005: "+item["MCTQ005"].ToString()
                    //    +"-- MCTQ006: "+item["MCTQ006"].ToString());
                }





            }
            MessageBox.Show("Lưu thành công");
        }

        private void txtMaCV_EditValueChanged(object sender, EventArgs e)
        {
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {

                var queryNV = (from a in db.NhanViens
                               join b in db.NhanVien_ChucVus
                               on a.MaNV equals b.MaNV
                               where b.MaCV == txtMaCV.Text
                               select new
                               {
                                   a.MaNV,
                                   a.TenNV,
                                   a.GioiTinh,
                                   a.NgayTao,
                                   a.SDT,
                                   a.TinhTrang
                               }).ToList();
                gridNV.DataSource = queryNV;



                /////
                ///
                var queryCV = (from a in db.ChucVus
                               join b in db.ChucVu_PhanQuyens
                               on a.MaCV equals b.MaCV
                               join c in db.ChiTietQuyens
                               on b.MaCTQuyen equals c.MaCTQuyen
                               join d in db.PhanQuyen_NhomNguoiDungs
                               on b.PQ_NND equals d.PQ_NND
                               join ee in db.NhomNguoiDungs
                               on d.MaNhom equals ee.MaNhom
                               join ff in db.PhanQuyens
                               on d.MaQuyen equals ff.MaQuyen
                               where a.MaCV == txtMaCV.Text
                               select new 
                               {
                                   a.MaCV,
                                   a.TenCV,
                                   ff.TenQuyen,
                                   ee.TenNhom,
                                   c.TenCTQuyen,
                                   d.PQ_NND
                               }
                               ).ToList();



                var pqs = (from a in db.PhanQuyens
                           join b in db.PhanQuyen_NhomNguoiDungs on a.MaQuyen equals b.MaQuyen
                           join c in db.NhomNguoiDungs on b.MaNhom equals c.MaNhom
                           select new
                           {
                               PQ_NND = b.PQ_NND,
                               TenNhom = c.TenNhom,
                               TenQuyen = a.TenQuyen,
                           }).ToList();

                dataPQ = new DataTable();
                dataPQ.Columns.Add("PQ_NND");
                dataPQ.Columns.Add("TenNhom");
                dataPQ.Columns.Add("TenQuyen");
                dataPQ.Columns.Add("MCTQ001", typeof(int));
                dataPQ.Columns.Add("MCTQ002", typeof(int));
                dataPQ.Columns.Add("MCTQ003", typeof(int));
                dataPQ.Columns.Add("MCTQ004", typeof(int));
                dataPQ.Columns.Add("MCTQ005", typeof(int));
                dataPQ.Columns.Add("MCTQ006", typeof(int));

                foreach (var item in pqs)
                {
                    int t = 0;
                    foreach (var itemPq in queryCV)
                    {
                        if (item.TenNhom == itemPq.TenNhom && item.TenQuyen == itemPq.TenQuyen && item.PQ_NND == itemPq.PQ_NND)
                        {
                            if (itemPq.TenCTQuyen == "Cấm")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 1, 0, 0, 0, 0, 0 };
                                dataPQ.Rows.Add(K);
                                t = 1;
                            }
                            else if (itemPq.TenCTQuyen == "Xem")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 1, 0, 0, 0, 0 };
                                dataPQ.Rows.Add(K);
                                t = 1;
                            }
                            else if (itemPq.TenCTQuyen == "Sửa")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 1, 0, 0, 0 };
                                dataPQ.Rows.Add(K);
                                t = 1;
                            }
                            else if (itemPq.TenCTQuyen == "Thêm")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 0, 1, 0, 0 };
                                dataPQ.Rows.Add(K);
                                t = 1;

                            }
                            else if (itemPq.TenCTQuyen == "Sửa và xóa")
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 0, 0, 1, 0 };
                                dataPQ.Rows.Add(K);
                                t = 1;
                            }
                            else
                            {
                                Object[] K = { item.PQ_NND, item.TenNhom, item.TenQuyen, 0, 0, 0, 0, 0, 1 };
                                dataPQ.Rows.Add(K);
                                t = 1;
                            }

                        }
                    }
                    if (t != 1)
                    {
                        Object[] O = { item.PQ_NND, item.TenNhom, item.TenQuyen, 1, 0, 0, 0, 0, 0 };
                        dataPQ.Rows.Add(O);
                    }

                }
                gridPQ.DataSource = dataPQ;


                //    var model = pqs.Select(pq => new PhanQuyenModel
                //    {
                //        TenNhom = pq.TenNhom,
                //        TenQuyen = pq.TenQuyen,
                //        PQ_NND = pq.PQ_NND
                //}).ToList();
                //    DataTable data = new DataTable();

                //    gridControl1.DataSource = data;



                TenNhomm.GroupIndex = 0;

                gridVPQ.OptionsView.ShowGroupedColumns = true;


                GridGroupSummaryItem countt = new GridGroupSummaryItem();
                countt.FieldName = TenNhomm.FieldName;
                countt.DisplayFormat = "";
                countt.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridVPQ.GroupSummary.Clear();
                gridVPQ.GroupSummary.Add(countt);


                gridVPQ.ExpandAllGroups();
                TenQuyenn.BestFit();

            }
        }
    }


   
}

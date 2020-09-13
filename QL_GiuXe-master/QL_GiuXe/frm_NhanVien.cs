using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QL_GiuXe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
            //MessageBox.Show(""+DateTime.Now);
            gridControl1.DataSource = list;
            MatKhau.Visible = false;
            labelControl11.Visible = false;
            txtMK.Visible = false;

            PhanQuyen_NguoiDung.Instance.LoadPQ();
            if (PhanQuyen_NguoiDung.Instance.Quyen_NV == "Xem")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            if (PhanQuyen_NguoiDung.Instance.Quyen_NV == "Sửa")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            if (PhanQuyen_NguoiDung.Instance.Quyen_NV == "Thêm")
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            if (PhanQuyen_NguoiDung.Instance.Quyen_NV == "Sửa và xóa")
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }


        }


        DataTable DT;

        private void btnRefesh_Click(object sender, EventArgs e)
        {

            
        }

        private void AddNewRowInGroupMode(DevExpress.XtraGrid.Views.Grid.GridView View)
        {
            //Get the handle of the source data row 
            //The row provides group column values for a new row 
            int rowHandle = View.GetDataRowHandleByGroupRowHandle(View.FocusedRowHandle);
            //Store group column values 
            object[] groupValues = null;
            int groupColumnCount = View.GroupedColumns.Count;
            if (groupColumnCount > 0)
            {
                groupValues = new object[groupColumnCount];
                for (int i = 0; i < groupColumnCount; i++)
                {
                    groupValues[i] = View.GetRowCellValue(rowHandle, View.GroupedColumns[i]);
                }
            }
            //Add a new row 
            //View.AddNewRow();
            //Get the handle of the new row 
            int newRowHandle = View.FocusedRowHandle;
            object newRow = View.GetRow(newRowHandle);
            //Set cell values corresponding to group columns 
            if (groupColumnCount > 0)
            {
                for (int i = 0; i < groupColumnCount; i++)
                {
                    View.SetRowCellValue(newRowHandle, View.GroupedColumns[i], groupValues[i]);
                }
            }
            //Accept the new row 
            //The row moves to a new position according to the current group settings 
            View.UpdateCurrentRow();
            //Locate the new row 
            for (int n = 0; n < View.DataRowCount; n++)
            {
                if (View.GetRow(n).Equals(newRow))
                {
                    View.FocusedRowHandle = n;
                    break;
                }
            }

        }



        private void GridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            string MaNhanV = "NV00001";
            GridView view = sender as GridView;
            for (int i = 0; i <DT.Rows.Count-1; i++)
            {
                int ff = 0;
                foreach (DataRow item in DT.Rows)
                {
                    if(ff<int.Parse(item["MaNV"].ToString().Substring(2)))
                        ff= int.Parse(item["MaNV"].ToString().Substring(2));
                }

                MaNhanV = "NV";
                ff += 1;
                if (ff >= 10000)
                    MaNhanV += ff;
                else if (ff >= 1000)
                    MaNhanV += ("0" + ff);
                else if (ff >= 100)
                    MaNhanV += ("00" + ff);
                else if (ff >= 10)
                    MaNhanV += ("000" + ff);
                else
                    MaNhanV += ("0000" + ff);
            }

            view.SetRowCellValue(e.RowHandle, view.Columns[0], MaNhanV);
            view.SetRowCellValue(e.RowHandle, view.Columns[1], 1);
            view.SetRowCellValue(e.RowHandle, view.Columns[7], "True");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new DataTable();
            data.Clear();
            data.Columns.Add("Cell",typeof(int));
            data.Columns.Add("Row", typeof(int));
            data.Columns.Add("Value");
            tbImage = new DataTable();
            tbImage.Clear();
            tbImage.Columns.Add("MaNV");
            tbImage.Columns.Add("Image");

            barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            barAndDockingController1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            barAndDockingController1.AppearancesBar.Bar.BackColor = barAndDockingController1.AppearancesBar.MainMenu.BackColor = Color.DarkTurquoise;

            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                

                DT = new DataTable();
                DT.Clear();
                DT.Columns.Add("MaNV");
                DT.Columns.Add("MatKhau");
                DT.Columns.Add("TenNV");
                DT.Columns.Add("GioiTinh");
                DT.Columns.Add("SDT");
                DT.Columns.Add("CMND");
                DT.Columns.Add("DiaChi");
                DT.Columns.Add("TinhTrang", typeof(bool));
                DT.Columns.Add("GhiChu");
                DT.Columns.Add("NgayTao",typeof(DateTime));
                DT.Columns.Add("NguoiTao");
                DT.Columns.Add("MaCV");
                
                
                //gridControl1.DataSource = DT;
                //var query = db.NhanViens.OrderByDescending(x=>x.NgayTao).ToList();
                var query = (from a in db.NhanViens
                             join b in db.NhanVien_ChucVus
                             on a.MaNV equals b.MaNV
                             join c in db.ChucVus
                             on b.MaCV equals c.MaCV
                             select new
                             {
                                 a,b,
                                 c
                             }).OrderByDescending(x => x.a.NgayTao).ToList();
                var queryCV = (from a in db.ChucVus
                               select a).ToList();
                repositoryItemLookUpEdit1.DataSource = queryCV;
                repositoryItemLookUpEdit1.ValueMember = "MaCV";
                repositoryItemLookUpEdit1.DisplayMember = "TenCV";
                foreach (var item in query)
                {
                       
                    Object[] O = { item.a.MaNV, item.a.MatKhau, item.a.TenNV, item.a.GioiTinh, item.a.SDT, item.a.CMND, item.a.DiaChi, item.a.TinhTrang, item.a.GhiChu,item.a.NguoiTao,item.a.NgayTao,item.c.MaCV};
                    
                    DT.Rows.Add(O);
                    
                }


                list.DataSource = DT;
                gridView1.OptionsBehavior.ReadOnly = true;
                txtMaNV.Visible = false;
                //gridView1.ExpandAllGroups();
            }

            //using (DataContextDataContext db = new DataContextDataContext())
            //{
            //    //Load quyền
            //    var load = (from a in db.NhanViens
            //                join b in db.NhanVien_NhomNguoiDungs
            //                on a.MaNV equals b.MaNV
            //                where a.MaNV == b.MaNV
            //                join c in db.ChiTietQuyens
            //                on b.MaCTQuyen equals c.MaCTQuyen
            //                where b.MaCTQuyen == c.MaCTQuyen
            //                join d in db.PhanQuyen_NhomNguoiDungs
            //                on b.PQ_NND equals d.PQ_NND
            //                where b.PQ_NND == d.PQ_NND
            //                join ee in db.NhomNguoiDungs
            //                on d.MaNhom equals ee.MaNhom
            //                where d.MaNhom == ee.MaNhom
            //                join f in db.PhanQuyens
            //                on d.MaQuyen equals f.MaQuyen /*new {A=d.MaQuyen } equals new {A=f.MaQuyen}*/
            //                where a.MaNV == "NV001"
            //                select new
            //                {
            //                    a.MaNV,
            //                    a.TenNV,
            //                    f.TenQuyen,
            //                    ee.TenNhom,
            //                    c.TenCTQuyen,
            //                    d.PQ_NND
            //                }).ToList();


            //    foreach (var item in load)
            //    {
            //        if(item.TenQuyen=="Nhân Viên")
            //        {
            //            if(item.TenCTQuyen=="Xem")
            //            {
            //                btnSave.Enabled = false;
            //                btnSua.Enabled = false;
            //                btnThem.Enabled = false;
            //                btnXoa.Enabled = false;
            //            }    
            //            //if(item.TenCTQuyen=="Sửa")
            //            /// nhìu nhìu
            //        }
            //    }

            //}
            bindingsouce();
        }


        DataTable data;
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (btnSua.Caption == "Hủy")
            {
                data.Rows.Add(gridView1.FocusedColumn.ColumnHandle, gridView1.GetFocusedDataSourceRowIndex(), DT.Rows[gridView1.GetFocusedDataSourceRowIndex()][gridView1.FocusedColumn.ColumnHandle].ToString());

            }

            //MessageBox.Show("" + DT.Rows[gridView1.GetFocusedDataSourceRowIndex()][gridView1.FocusedColumn.ColumnHandle]);
        }

        

        

       

        

        

        



        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Caption == "Thêm")
            {

                list.DataSource = DT;
                btnThem.Caption = "Hủy";
                btnRefesh.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;

                gridView1.OptionsBehavior.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtTen.ReadOnly = false;
                txtCMND.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtGhiChu.ReadOnly = false;
                cboGioiTinh.ReadOnly = false;
                cbTinhTrang.ReadOnly = false;
                pictureEdit1.ReadOnly = false;
                lookUpEdit1.ReadOnly = false;

                MatKhau.Visible = true;
                labelControl11.Visible = true;
                txtMK.Visible = true;

                gridView1.InitNewRow += GridView1_InitNewRow;
                gridView1.AddNewRow();
                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

                //string MatKhau = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MatKhau").ToString();
                //string TenNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
                //string GioiTinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString();
                //string SDT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
                //string CMND = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
                //string DiaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
                //bool TinhTrangs = bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TinhTrang").ToString());

                //string GhiChu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GhiChu").ToString();

                //DT.Rows.Add(Guid.NewGuid().ToString(), MatKhau, TenNV, GioiTinh, SDT, CMND, DiaChi, TinhTrangs, GhiChu);

                //gridControl1.DataSource = DT;

                //AddNewRowInGroupMode(gridView1);
            }
            else
            {
                //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                //gridView1.OptionsView.Reset();
                btnThem.Caption = "Thêm";
                btnRefesh.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnSave.Enabled = false;

                txtDiaChi.ReadOnly = true;
                txtTen.ReadOnly = true;
                txtCMND.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
                cboGioiTinh.ReadOnly = true;
                cbTinhTrang.ReadOnly = true;
                pictureEdit1.ReadOnly = true;
                lookUpEdit1.ReadOnly = true;

                MatKhau.Visible = false;
                labelControl11.Visible = false;
                txtMK.Visible = false;

                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                btnRefesh_ItemClick_1(sender, e);
            }


        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
                    {
                        Int32[] selectedRowHandles = gridView1.GetSelectedRows();
                        for (int i = 0; i < selectedRowHandles.Length; i++)
                        {
                            int selectedRowHandle = selectedRowHandles[i];
                            if (selectedRowHandle >= 0)
                            {
                                string id = gridView1.GetRowCellValue(selectedRowHandle/*gridView1.FocusedRowHandle*/, "MaNV").ToString();
                                NhanVien_ChucVu deleteCV = db.NhanVien_ChucVus.Where(x => x.MaNV.Equals(id)).SingleOrDefault();
                                db.NhanVien_ChucVus.DeleteOnSubmit(deleteCV);
                                NhanVien delete = db.NhanViens.Where(x => x.MaNV.Equals(id)).SingleOrDefault();
                                db.NhanViens.DeleteOnSubmit(delete);
                                db.SubmitChanges();
                            }
                        }







                        btnRefesh_ItemClick_1(sender, e);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Không thể xóa");
            }
        }

        private void btnSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Caption == "Sửa")
            {
                btnSua.Caption = "Hủy";
                list.DataSource = DT;
                btnRefesh.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;
                gridView1.OptionsBehavior.ReadOnly = false;

                txtDiaChi.ReadOnly = false;
                txtTen.ReadOnly = false;
                txtCMND.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtGhiChu.ReadOnly = false;
                cboGioiTinh.ReadOnly = false;
                cbTinhTrang.ReadOnly = false;
                pictureEdit1.ReadOnly = false;
                lookUpEdit1.ReadOnly = false;

                MatKhau.Visible = true;
                labelControl11.Visible = true;
                txtMK.Visible = true;



                //string MaNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
                //string MatKhau = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MatKhau").ToString();
                //string TenNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
                //string GioiTinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString();
                //string SDT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
                //string CMND = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
                //string DiaChi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
                //bool TinhTrang =bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TinhTrang").ToString());

                //string GhiChu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GhiChu").ToString();

                //NhanVien edit = db.NhanViens.Where(x => x.MaNV.Equals(MaNV)).SingleOrDefault();


                //edit.MatKhau = MatKhau;
                //edit.TenNV = TenNV;
                //edit.GioiTinh = GioiTinh;
                //edit.SDT = SDT;
                //edit.CMND = CMND;
                //edit.DiaChi = DiaChi;

                //edit.GhiChu = GhiChu;
                //db.SubmitChanges();
                //btnRefesh_Click(sender, e);
            }
            else
            {
                btnSua.Caption = "Sửa";
                btnRefesh.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSave.Enabled = false;

                txtDiaChi.ReadOnly = true;
                txtTen.ReadOnly = true;
                txtCMND.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
                cboGioiTinh.ReadOnly = true;
                cbTinhTrang.ReadOnly = true;
                pictureEdit1.ReadOnly = true;
                lookUpEdit1.ReadOnly = true;

                MatKhau.Visible = false;
                labelControl11.Visible = false;
                txtMK.Visible = false;

                btnRefesh_Click(sender, e);
            }
        }

        private void btnRefesh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                data = new DataTable();
                data.Clear();
                data.Columns.Add("Cell", typeof(int));
                data.Columns.Add("Row", typeof(int));
                data.Columns.Add("Value");


                DT = new DataTable();
                DT.Clear();
                DT.Columns.Add("MaNV");
                DT.Columns.Add("MatKhau");
                DT.Columns.Add("TenNV");
                DT.Columns.Add("GioiTinh");
                DT.Columns.Add("SDT");
                DT.Columns.Add("CMND");
                DT.Columns.Add("DiaChi");
                DT.Columns.Add("TinhTrang", typeof(bool));
                DT.Columns.Add("GhiChu");
                DT.Columns.Add("NguoiTao");
                DT.Columns.Add("NgayTao",typeof(DateTime));
                
                DT.Columns.Add("MaCV");


                //gridControl1.DataSource = DT;
                //var query = db.NhanViens.OrderByDescending(x=>x.NgayTao).ToList();
                var query = (from a in db.NhanViens
                             join b in db.NhanVien_ChucVus
                             on a.MaNV equals b.MaNV
                             join c in db.ChucVus
                             on b.MaCV equals c.MaCV
                             select new
                             {
                                 a,
                                 b,
                                 c
                             }).OrderByDescending(x => x.a.NgayTao).ToList();
                var queryCV = (from a in db.ChucVus
                               select a).ToList();
                repositoryItemLookUpEdit1.DataSource = queryCV;
                repositoryItemLookUpEdit1.ValueMember = "MaCV";
                repositoryItemLookUpEdit1.DisplayMember = "TenCV";

                
                foreach (var item in query)
                {
                    Object[] O = { item.a.MaNV, item.a.MatKhau, item.a.TenNV, item.a.GioiTinh, item.a.SDT, item.a.CMND, item.a.DiaChi, item.a.TinhTrang, item.a.GhiChu, item.a.NguoiTao, item.a.NgayTao, item.c.MaCV };
                    DT.Rows.Add(O);

                }

                list.ResetBindings(true);
                list.DataSource = DT;
                gridView1.OptionsBehavior.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtTen.ReadOnly = true;
                txtCMND.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
                cboGioiTinh.ReadOnly = true;
                cbTinhTrang.ReadOnly = true;
                pictureEdit1.ReadOnly = true;
                lookUpEdit1.ReadOnly = true;
            }
        }

        private void btnSave_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Focus();
            btnSave.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnRefesh.Enabled = true;
            MatKhau.Visible = false;
            labelControl11.Visible = false;
            txtMK.Visible = false;


            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                if (btnThem.Caption == "Hủy")
                {
                    btnThem.Caption = "Thêm";
                    gridView1.AddNewRow();
                    foreach (DataRow item in DT.Rows)
                    {
                        if (db.NhanViens.Where(x => x.MaNV == item["MaNV"].ToString()).FirstOrDefault() == null)
                        {
                            NhanVien NV = new NhanVien();
                            NV.MaNV = item["MaNV"].ToString();
                            NV.MatKhau = item["MatKhau"].ToString();
                            NV.TenNV = item["TenNV"].ToString();
                            NV.GioiTinh = item["GioiTinh"].ToString();
                            NV.SDT = item["SDT"].ToString();
                            NV.CMND = item["CMND"].ToString();
                            NV.DiaChi = item["DiaChi"].ToString();

                            

                            foreach (DataRow pic in tbImage.Rows)
                            {
                                if (pic["Image"].ToString() == "") continue;
                                PictureEdit pictureEdit = new PictureEdit();
                                if (item["MaNV"].ToString() == pic["MaNV"].ToString())
                                { 
                                    pictureEdit.Image = Image.FromFile(pic["Image"].ToString());
                                    NV.Anh = imageToByteArray(pictureEdit.Image, ImageFormat.Png);
                                }
                            }
                            

                            NV.GhiChu = item["GhiChu"].ToString();
                            NV.TinhTrang = bool.Parse(item["TinhTrang"].ToString());
                            NV.NgayTao = DateTime.Now;
                            NV.NguoiTao = null;

                            NhanVien_ChucVu NVCV = new NhanVien_ChucVu();
                            NVCV.MaNV = item["MaNV"].ToString();
                            NVCV.MaCV = item["MACV"].ToString();
                            if (NVCV.MaCV == "")
                                NVCV.MaCV = "CV001";

                            db.NhanViens.InsertOnSubmit(NV);
                            //db.SubmitChanges();
                            db.NhanVien_ChucVus.InsertOnSubmit(NVCV);
                            db.SubmitChanges();





                            var abc = (from a in db.NhanVien_ChucVus
                                       join b in db.ChucVus
                                       on a.MaCV equals b.MaCV
                                       join c in db.ChucVu_PhanQuyens
                                       on b.MaCV equals c.MaCV
                                       where a.MaCV == item["MaCV"].ToString()
                                       && a.MaNV == item["MaNV"].ToString()
                                       select new
                                       {
                                           a.MaNV,
                                           c.PQ_NND,
                                           c.MaCTQuyen
                                       }
                                     ).ToList();
                            if(abc!=null)
                            {
                                foreach (var ccc in abc)
                                {
                                    NhanVien_NhomNguoiDung nv_nnd = new NhanVien_NhomNguoiDung();
                                    nv_nnd.MaNV = ccc.MaNV;
                                    nv_nnd.PQ_NND = ccc.PQ_NND;
                                    nv_nnd.MaCTQuyen = ccc.MaCTQuyen;
                                    db.NhanVien_NhomNguoiDungs.InsertOnSubmit(nv_nnd);

                                }
                                db.SubmitChanges();

                            }



                        }

                    }
                    gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                }
                if (btnSua.Caption == "Hủy")
                {

                    btnSua.Caption = "Sửa";

                    foreach (DataRow item in data.Rows)
                    {
                        DT.Rows[int.Parse(item["Row"].ToString())][int.Parse(item["Cell"].ToString())] = item["Value"].ToString();
                    }

                    foreach (DataRow item in DT.Rows)
                    {
                        NhanVien edit = db.NhanViens.Where(x => x.MaNV.Equals(item["MaNV"].ToString())).SingleOrDefault();


                        edit.MatKhau = item["MatKhau"].ToString();
                        edit.TenNV = item["TenNV"].ToString();
                        edit.GioiTinh = item["GioiTinh"].ToString();
                        edit.SDT = item["SDT"].ToString();
                        edit.CMND = item["CMND"].ToString();
                        edit.DiaChi = item["DiaChi"].ToString();
                        edit.TinhTrang = bool.Parse(item["TinhTrang"].ToString());
                        edit.GhiChu = item["GhiChu"].ToString();

                        foreach (DataRow pic in tbImage.Rows)
                        {
                            if (pic["Image"].ToString() == "") continue;
                            PictureEdit pictureEdit = new PictureEdit();
                            if (item["MaNV"].ToString() == pic["MaNV"].ToString())
                            {
                                pictureEdit.Image = Image.FromFile(pic["Image"].ToString());
                                edit.Anh = imageToByteArray(pictureEdit.Image, ImageFormat.Png);
                            }
                        }

                        //edit.Anh = imageToByteArray(pictureEdit1.Image, ImageFormat.Png);
                        NhanVien_ChucVu editCV = db.NhanVien_ChucVus.Where(x => x.MaNV.Equals(item["MaNV"].ToString())).SingleOrDefault();
                        editCV.MaCV=item["MaCV"].ToString();
                        db.SubmitChanges();

                        var abc = (from a in db.NhanVien_ChucVus
                                   join b in db.ChucVus
                                   on a.MaCV equals b.MaCV
                                   join c in db.ChucVu_PhanQuyens
                                   on b.MaCV equals c.MaCV
                                   where a.MaCV == item["MaCV"].ToString()
                                   && a.MaNV == item["MaNV"].ToString()
                                   select new
                                   {
                                       a.MaNV,
                                       c.PQ_NND,
                                       c.MaCTQuyen
                                   }
                                     ).ToList();
                        if (abc != null)
                        {
                            foreach (var ccc in abc)
                            {
                                NhanVien_NhomNguoiDung editNV_nnd = db.NhanVien_NhomNguoiDungs.Where(x => x.MaNV.Equals(item["MaNV"].ToString()) && x.PQ_NND.Equals(ccc.PQ_NND)).SingleOrDefault();
                                editNV_nnd.MaCTQuyen = ccc.MaCTQuyen;
                                db.SubmitChanges();

                            }
                            

                        }



                    }

                }
                btnRefesh_ItemClick_1(sender, e);
                MessageBox.Show("Save thanh công");



            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string filePath;
            var saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "NhanVien.xlsx";
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDialog.ShowDialog();
            filePath = saveDialog.FileName;

            if (filePath != "")
            {
                gridControl1.ExportToXlsx(filePath);
            }

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsSelection.MultiSelect = false;
            gridView1.FocusedRowHandle = 0;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.SelectRow(gridView1.FocusedRowHandle);


            //gridView1.OptionsSelection.MultiSelect = true;
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle == 0)
                return;
            gridView1.OptionsSelection.MultiSelect = false;
            gridView1.FocusedRowHandle = gridView1.FocusedRowHandle - 1;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.SelectRow(gridView1.FocusedRowHandle);
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle == DT.Rows.Count - 1)
                return;
            gridView1.OptionsSelection.MultiSelect = false;
            gridView1.FocusedRowHandle = gridView1.FocusedRowHandle + 1;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.SelectRow(gridView1.FocusedRowHandle);
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsSelection.MultiSelect = false;
            gridView1.FocusedRowHandle = DT.Rows.Count - 1;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.SelectRow(gridView1.FocusedRowHandle);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //lbName.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
            //txtDiaChi.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            //cboGioiTinh.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString();
            //txtSDT.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            //txtCMND.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            //txtGhiChu.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GhiChu").ToString();
            //cbTinhTrang.Checked= bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TinhTrang").ToString());
        }

        private void txtDiaChi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //if(txtDiaChi.==true)
            //{
            //    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DiaChi",txtDiaChi.Text);
            //}
        }
        
        private void bindingsouce()
        {
            txtDiaChi.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "DiaChi"));
            txtTen.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "TenNV"));
            lbName.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "TenNV"));
            cboGioiTinh.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "GioiTinh"));
            txtSDT.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "SDT"));
            txtCMND.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "CMND"));
            txtGhiChu.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "GhiChu"));
            cbTinhTrang.DataBindings.Add(new Binding("Checked", gridControl1.DataSource, "TinhTrang"));
            lbNguoiTao.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "NguoiTao"));
            lbNgayTao.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "NgayTao"));
            txtMK.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "MatKhau"));

            lookUpEdit1.DataBindings.Add(new Binding("EditValue", gridControl1.DataSource, "MaCV"));

            QL_BaiXeDataContext db = new QL_BaiXeDataContext();
            var query = (from a in db.NhanViens
                         join b in db.NhanVien_ChucVus
                         on a.MaNV equals b.MaNV
                         join c in db.ChucVus
                         on b.MaCV equals c.MaCV
                         select new
                         {
                             a,
                             b,
                             c
                         }).OrderByDescending(x => x.a.NgayTao).ToList();
            var queryCV = (from a in db.ChucVus
                           select a).ToList();
            lookUpEdit1.Properties.DataSource = queryCV;
            lookUpEdit1.Properties.ValueMember = "MaCV";
            lookUpEdit1.Properties.DisplayMember = "TenCV";

            txtMaNV.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "MaNV"));

            


        }
        BindingSource list = new BindingSource();
        DataTable tbImage;

        public byte[] imageToByteArray(Image imageToConvert, ImageFormat format)
        {
            MemoryStream ms = new MemoryStream();
            imageToConvert.Save(ms, format);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
                {
                    var query = db.NhanViens.Where(x=>x.MaNV==txtMaNV.Text).FirstOrDefault();
                    if (query != null && query.Anh != null)
                        pictureEdit1.Image = byteArrayToImage(query.Anh.ToArray());
                    else
                        pictureEdit1.EditValue = null;
                }
            }
            catch
            {

            }
            
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + pictureEdit1.GetLoadedImageLocation());
            if(btnSave.Enabled==true)
                tbImage.Rows.Add(txtMaNV.Text, pictureEdit1.GetLoadedImageLocation());
        }


    }

    
}

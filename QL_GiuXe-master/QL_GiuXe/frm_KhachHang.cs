using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using QL_GiuXe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiuXe
{
    public partial class frm_KhachHang : Form
    {
        public string Truyen_MaKH = "";
        int tat = 0;
        public frm_KhachHang()
        {
            InitializeComponent();
            gridControl1.DataSource = list;
        }

        public frm_KhachHang(int gt)
        {          
            InitializeComponent();
            gridControl1.DataSource = list;
            tat = 1;
        }


        DataTable data;
        DataTable DT;

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            //barButtonItem19.Visibility
            data = new DataTable();
            data.Clear();
            data.Columns.Add("Cell", typeof(int));
            data.Columns.Add("Row", typeof(int));
            data.Columns.Add("Value");

            barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            barAndDockingController1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            barAndDockingController1.AppearancesBar.Bar.BackColor = barAndDockingController1.AppearancesBar.MainMenu.BackColor = Color.DarkTurquoise;

            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {



                DT = new DataTable();
                DT.Clear();
                DT.Columns.Add("MaKH");
                DT.Columns.Add("TenKH");
                DT.Columns.Add("Anh_KH",typeof(Image));
                DT.Columns.Add("GioiTinh");
                DT.Columns.Add("SDT");
                DT.Columns.Add("CMND");
                DT.Columns.Add("SoPhong");

                //gridControl1.DataSource = DT;
                var query = db.KhachHangs.ToList();

                foreach (var item in query)
                {
                    Object[] O = { item.MaKH, item.TenKH, item.Anh_KH, item.GioiTinh, item.SDT, item.CMND, item.SoPhong };
                    DT.Rows.Add(O);

                }


                list.DataSource = DT;
                gridView1.OptionsBehavior.ReadOnly = true;
            }

            Tat();
            bindingsouce();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns[0], Guid.NewGuid().ToString().Substring(0,5));
            view.SetRowCellValue(e.RowHandle, view.Columns[1], 2);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (btnSua.Caption == "Hủy")
            {
                data.Rows.Add(gridView1.FocusedColumn.ColumnHandle, gridView1.GetFocusedDataSourceRowIndex(), DT.Rows[gridView1.GetFocusedDataSourceRowIndex()][gridView1.FocusedColumn.ColumnHandle].ToString());

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                gridView1.InitNewRow += GridView1_InitNewRow; ;
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

                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

                btnRefesh_ItemClick(sender, e);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                                string id = gridView1.GetRowCellValue(selectedRowHandle/*gridView1.FocusedRowHandle*/, "MaKH").ToString();
                                KhachHang delete = db.KhachHangs.Where(x => x.MaKH.Equals(id)).SingleOrDefault();
                                db.KhachHangs.DeleteOnSubmit(delete);
                                db.SubmitChanges();
                            }
                        }







                        btnRefesh_ItemClick(sender, e);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Không thể xóa");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                btnRefesh_ItemClick(sender, e);
            }
        }

        private void btnRefesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                DT.Columns.Add("MaKH");
                DT.Columns.Add("TenKH");
                DT.Columns.Add("Anh_KH");
                DT.Columns.Add("GioiTinh");
                DT.Columns.Add("SDT");
                DT.Columns.Add("CMND");
                DT.Columns.Add("SoPhong");

                //gridControl1.DataSource = DT;
                var query = db.KhachHangs.ToList();

                foreach (var item in query)
                {
                    Object[] O = { item.MaKH, item.TenKH, item.Anh_KH, item.GioiTinh, item.SDT, item.CMND, item.SoPhong };
                    DT.Rows.Add(O);

                }


                list.DataSource = DT;
                gridView1.OptionsBehavior.ReadOnly = true;
            }
        }


        
        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }


        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }


        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSave.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnRefesh.Enabled = true;
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                if (btnThem.Caption == "Hủy")
                {
                    btnThem.Caption = "Thêm";
                    gridView1.AddNewRow();
                    foreach (DataRow item in DT.Rows)
                    {
                        if (db.KhachHangs.Where(x => x.MaKH == item["MaKH"].ToString()).FirstOrDefault() == null)
                        {
                            KhachHang Kh = new KhachHang();
                            Kh.MaKH = item["MaKH"].ToString();
                            Kh.TenKH = item["TenKH"].ToString();
                            Kh.GioiTinh = item["GioiTinh"].ToString();
                            Kh.SDT = item["SDT"].ToString();
                            Kh.CMND = item["CMND"].ToString();
                            Kh.SoPhong = item["SoPhong"].ToString();
                            //Kh.Anh_KH = ImageToByteArray(Image.FromFile(item["Anh_KH"].ToString()));


                            db.KhachHangs.InsertOnSubmit(Kh);
                            db.SubmitChanges();
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
                        KhachHang edit = db.KhachHangs.Where(x => x.MaKH.Equals(item["MaKH"].ToString())).SingleOrDefault();


                        edit.TenKH = item["TenKH"].ToString();
                        edit.GioiTinh = item["GioiTinh"].ToString();
                        edit.SDT = item["SDT"].ToString();
                        edit.CMND = item["CMND"].ToString();
                        edit.SoPhong = item["SoPhong"].ToString();
                        db.SubmitChanges();
                    }

                }



            }

            btnRefesh_ItemClick(sender, e);
            MessageBox.Show("Save thanh công");
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void bindingsouce()
        {
            txtMaKH.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "MaKH"));
            txtTen.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "TenKH"));
            cboGioiTinh.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "GioiTinh"));
            txtSDT.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "SDT"));
            txtCMND.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "CMND"));
            txtSoPhong.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "SoPhong"));
            lbName.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "TenKH"));




        }
        BindingSource list = new BindingSource();

        private void Tat()
        {
            if (tat == 1)
            {
                barButtonItem17.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem16.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem15.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem14.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem13.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem7.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnRefesh.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSua.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnThem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem19.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKH.Text == string.Empty)
            {
                XtraMessageBox.Show("Chưa chọn khách hàng", "Chọn khách hàng");
                return;
            }
            else
            {
                Truyen_MaKH = txtMaKH.Text;
                this.Close();
            }
        }
    }
}

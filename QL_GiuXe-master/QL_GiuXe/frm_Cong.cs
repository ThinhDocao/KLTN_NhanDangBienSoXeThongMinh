using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frm_Cong : Form
    {
        public frm_Cong()
        {
            InitializeComponent();
        }
        DataTable data;
        DataTable DT;
        private void frmCong_Load(object sender, EventArgs e)
        {
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
                DT.Columns.Add("Ma_Cong");
                DT.Columns.Add("Ten_Cong");
                DT.Columns.Add("ChucNang");
                DT.Columns.Add("TinhTrang", typeof(bool));
                DT.Columns.Add("GhiChu");

                //gridControl1.DataSource = DT;
                var query = db.Congs.ToList();

                foreach (var item in query)
                {
                    Object[] O = { item.Ma_Cong, item.Ten_Cong, item.ChucNang, item.TinhTrang, item.GhiChu };
                    DT.Rows.Add(O);

                }


                gridControl1.DataSource = DT;
                gridView1.OptionsBehavior.ReadOnly = true;
            }

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            
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

        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns[0], Guid.NewGuid().ToString());
            view.SetRowCellValue(e.RowHandle, view.Columns[1], 2);
            view.SetRowCellValue(e.RowHandle, view.Columns[3], "True");
        }

        private void btnSave_Click(object sender, EventArgs e)
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

                gridControl1.DataSource = DT;
                btnThem.Caption = "Hủy";
                btnRefesh.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;
                gridView1.OptionsBehavior.ReadOnly = false;
                gridView1.InitNewRow += GridView1_InitNewRow;
                gridView1.AddNewRow();
                //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

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

                //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

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
                                string id = gridView1.GetRowCellValue(selectedRowHandle/*gridView1.FocusedRowHandle*/, "Ma_Cong").ToString();
                                Cong delete = db.Congs.Where(x => x.Ma_Cong.Equals(id)).SingleOrDefault();
                                db.Congs.DeleteOnSubmit(delete);
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
                gridControl1.DataSource = DT;
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



                DT = new DataTable();
                DT.Clear();
                DT.Columns.Add("Ma_Cong");
                DT.Columns.Add("Ten_Cong");
                DT.Columns.Add("ChucNang");
                DT.Columns.Add("TinhTrang", typeof(bool));
                DT.Columns.Add("GhiChu");

                //gridControl1.DataSource = DT;
                var query = db.Congs.ToList();

                foreach (var item in query)
                {
                    Object[] O = { item.Ma_Cong, item.Ten_Cong, item.ChucNang, item.TinhTrang, item.GhiChu };
                    DT.Rows.Add(O);

                }


                gridControl1.DataSource = DT;
                gridView1.OptionsBehavior.ReadOnly = true;
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
                    foreach (DataRow item in DT.Rows)
                    {
                        if (db.Congs.Where(x => x.Ma_Cong == item["Ma_Cong"].ToString()).FirstOrDefault() == null)
                        {
                            Cong cong = new Cong();
                            cong.Ma_Cong = item["Ma_Cong"].ToString();
                            cong.Ten_Cong = item["Ten_Cong"].ToString();
                            cong.ChucNang = item["ChucNang"].ToString();

                            cong.TinhTrang = bool.Parse(item["TinhTrang"].ToString());
                            cong.GhiChu = item["GhiChu"].ToString();
                            db.Congs.InsertOnSubmit(cong);
                            db.SubmitChanges();
                        }

                    }
                    //gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;

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
                        Cong edit = db.Congs.Where(x => x.Ma_Cong.Equals(item["Ma_Cong"].ToString())).SingleOrDefault();


                        edit.Ten_Cong = item["Ten_Cong"].ToString();
                        edit.ChucNang = item["ChucNang"].ToString();
                        edit.TinhTrang = bool.Parse(item["TinhTrang"].ToString());
                        edit.GhiChu = item["GhiChu"].ToString();
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
    }
}

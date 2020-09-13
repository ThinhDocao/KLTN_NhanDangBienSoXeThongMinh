using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiuXe
{
    public partial class frm_ThongKeViPham : Form
    {
        BindingSource list = new BindingSource();
        public frm_ThongKeViPham()
        {
            InitializeComponent();
            gridControl1.DataSource = list;
        }

        private void frm_ThongKeViPham_Load(object sender, EventArgs e)
        {
            loadGLUE();
            
        }
        DataTable dataNV;
        DataTable dataKH;

        public void loadGLUE()
        {
            
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                dataNV= new DataTable();
                dataNV.Columns.Add("MaNV");
                dataNV.Columns.Add("TenNV");
                dataNV.Columns.Add("GioiTinh");
                dataNV.Rows.Add("All", "All", "All");
                var NV= db.NhanViens.Select(x=>new { x.MaNV,x.TenNV,x.GioiTinh}).ToList();
                foreach (var item in NV)
                {
                    dataNV.Rows.Add(item.MaNV,item.TenNV,item.GioiTinh);
                }
                
                glueNV.Properties.DataSource = dataNV;
                glueNV.Properties.DisplayMember = "TenNV";
                glueNV.Properties.ValueMember = "MaNV";



                dataKH = new DataTable();
                dataKH.Columns.Add("MaKH");
                dataKH.Columns.Add("TenKH");
                dataKH.Columns.Add("SoPhong");
                dataKH.Rows.Add("All", "All", "All");
                var KH = db.KhachHangs.Select(x => new { x.MaKH, x.TenKH, x.SoPhong}).ToList();
                foreach (var item in KH)
                {
                    dataKH.Rows.Add(item.MaKH, item.TenKH, item.SoPhong);
                }
                glueKH.Properties.DataSource =dataKH;
                glueKH.Properties.DisplayMember = "TenKH";
                glueKH.Properties.ValueMember = "MaKH";
            }
                
        }

        private void glueNV_EditValueChanged(object sender, EventArgs e)
        {
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                if(glueNV.EditValue.ToString()=="All")
                {
                    var VP = (from a in db.ViPhams
                              join b in db.Xes
                              on a.MaXe equals b.MaXe
                              join c in db.KhachHangs
                              on b.MaKH equals c.MaKH
                              join d in db.VeThangs
                              on b.MaXe equals d.MaXe
                              join ee in db.NhanViens
                              on d.NhanVien equals ee.MaNV
                              select new
                              {
                                  b.MaXe,
                                  b.BienXo_Xe,
                                  c.MaKH,
                                  c.TenKH,
                                  c.SoPhong,
                                  ee.MaNV,
                                  ee.TenNV,
                                  a.ThoiGian,
                                  a.ViPham1
                              }).ToList();

                    list.DataSource = VP;
                }
                else
                {
                    var VP = (from a in db.ViPhams
                              join b in db.Xes
                              on a.MaXe equals b.MaXe
                              join c in db.KhachHangs
                              on b.MaKH equals c.MaKH
                              join d in db.VeThangs
                              on b.MaXe equals d.MaXe
                              join ee in db.NhanViens
                              on d.NhanVien equals ee.MaNV
                              where ee.MaNV == glueNV.EditValue.ToString()
                              select new
                              {
                                  b.MaXe,
                                  b.BienXo_Xe,
                                  c.MaKH,
                                  c.TenKH,
                                  c.SoPhong,
                                  ee.MaNV,
                                  ee.TenNV,
                                  a.ThoiGian,
                                  a.ViPham1
                              }).ToList();

                    list.DataSource = VP;

                }

                TenNV.GroupIndex = 0;
                gridView1.ExpandAllGroups();
                GridGroupSummaryItem item = new GridGroupSummaryItem();
                item.FieldName = TenNV.FieldName;
                item.SummaryType = DevExpress.Data.SummaryItemType.Count;
                item.DisplayFormat = " (Số lỗi VP = {0} )";
                gridView1.GroupSummary.Add(item);
                gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;

                gridView1.Columns["ViPham1"].Summary.Clear();
                gridView1.Columns["ViPham1"].Summary.Add(DevExpress.Data.SummaryItemType.Count, "ViPham1", "Tổng lỗi VP = {0}");

            }
            bindingsouce();
            gridControl1.Focus();
        }

        private void glueKH_EditValueChanged(object sender, EventArgs e)
        {
            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                if (glueKH.EditValue.ToString() == "All")
                {
                    var VP = (from a in db.KhachHangs
                              join b in db.Xes
                              on a.MaKH equals b.MaKH
                              join c in db.ViPhams
                              on b.MaXe equals c.MaXe
                              join d in db.VeThangs
                              on b.MaXe equals d.MaXe
                              join ee in db.NhanViens
                              on d.NhanVien equals ee.MaNV
                              select new
                              {
                                  b.MaXe,
                                  b.BienXo_Xe,
                                  a.MaKH,
                                  a.TenKH,
                                  a.SoPhong,
                                  ee.MaNV,
                                  ee.TenNV,
                                  c.ThoiGian,
                                  c.ViPham1
                              }).ToList();
                    list.DataSource = VP;
                }
                else
                {
                    var VP = (from a in db.KhachHangs
                              join b in db.Xes
                              on a.MaKH equals b.MaKH
                              join c in db.ViPhams
                              on b.MaXe equals c.MaXe
                              join d in db.VeThangs
                              on b.MaXe equals d.MaXe
                              join ee in db.NhanViens
                              on d.NhanVien equals ee.MaNV
                              where b.MaKH == glueKH.EditValue.ToString()
                              select new
                              {
                                  b.MaXe,
                                  b.BienXo_Xe,
                                  a.MaKH,
                                  a.TenKH,
                                  a.SoPhong,
                                  ee.MaNV,
                                  ee.TenNV,
                                  c.ThoiGian,
                                  c.ViPham1
                              }).ToList();
                    list.DataSource = VP;
                }

                TenKH.GroupIndex = 0;
                gridView1.ExpandAllGroups();
                GridGroupSummaryItem item = new GridGroupSummaryItem();
                item.FieldName = TenKH.FieldName;
                item.SummaryType = DevExpress.Data.SummaryItemType.Count;
                item.DisplayFormat = " (Số lỗi VP = {0} )";
                gridView1.GroupSummary.Add(item);
                gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;

                gridView1.Columns["ViPham1"].Summary.Clear();
                gridView1.Columns["ViPham1"].Summary.Add(DevExpress.Data.SummaryItemType.Count, "ViPham1", "Tổng lỗi VP = {0}");

            }
            bindingsouce();
            gridControl1.Focus();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
   
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Không thể nhỏ hơn ngày tìm");
                dateTimePicker2.Value=dateTimePicker1.Value.AddMonths(+1);
                return;
            }

            string TGTu = "" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year;
            DateTime dateTimeTu = DateTime.Parse(TGTu);
            
            string TGDen = "" + dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.Year;
            DateTime dateTimeDen = DateTime.Parse(TGDen);
            DataTable dataTG = new DataTable();
            dataTG.Columns.Add("MaXe");
            dataTG.Columns.Add("BienXo_Xe");
            dataTG.Columns.Add("MaKH");
            dataTG.Columns.Add("TenKH");
            dataTG.Columns.Add("SoPhong");
            dataTG.Columns.Add("MaNV");
            dataTG.Columns.Add("TenNV");
            dataTG.Columns.Add("ThoiGian");
            dataTG.Columns.Add("ViPham1");

            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                var VP = (from a in db.KhachHangs
                          join b in db.Xes
                          on a.MaKH equals b.MaKH
                          join c in db.ViPhams
                          on b.MaXe equals c.MaXe
                          join d in db.VeThangs
                          on b.MaXe equals d.MaXe
                          join ee in db.NhanViens
                          on d.NhanVien equals ee.MaNV
                          select new
                          {
                              b.MaXe,
                              b.BienXo_Xe,
                              a.MaKH,
                              a.TenKH,
                              a.SoPhong,
                              ee.MaNV,
                              ee.TenNV,
                              c.ThoiGian,
                              c.ViPham1
                          }).ToList();
                foreach (var item in VP)
                {
                    if (DateTime.Parse(item.ThoiGian) >= dateTimeTu && DateTime.Parse(item.ThoiGian) <= dateTimeDen)
                        dataTG.Rows.Add(item.MaXe, item.BienXo_Xe, item.MaKH, item.TenKH, item.SoPhong, item.MaNV, item.TenNV, item.ThoiGian, item.ViPham1);
                }
                list.DataSource = dataTG ;
            }
            TenKH.GroupIndex = -1;
            TenNV.GroupIndex = -1;
            bindingsouce();
            gridControl1.Focus();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Không thể lớn hơn ngày tìm");
                dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-1);
                return;
            }

            string TGTu = "" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year;
            DateTime dateTimeTu = DateTime.Parse(TGTu);

            string TGDen = "" + dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.Year;
            DateTime dateTimeDen = DateTime.Parse(TGDen);
            DataTable dataTG = new DataTable();
            dataTG.Columns.Add("MaXe");
            dataTG.Columns.Add("BienXo_Xe");
            dataTG.Columns.Add("MaKH");
            dataTG.Columns.Add("TenKH");
            dataTG.Columns.Add("SoPhong");
            dataTG.Columns.Add("MaNV");
            dataTG.Columns.Add("TenNV");
            dataTG.Columns.Add("ThoiGian");
            dataTG.Columns.Add("ViPham1");

            using (QL_BaiXeDataContext db = new QL_BaiXeDataContext())
            {
                var VP = (from a in db.KhachHangs
                          join b in db.Xes
                          on a.MaKH equals b.MaKH
                          join c in db.ViPhams
                          on b.MaXe equals c.MaXe
                          join d in db.VeThangs
                          on b.MaXe equals d.MaXe
                          join ee in db.NhanViens
                          on d.NhanVien equals ee.MaNV
                          select new
                          {
                              b.MaXe,
                              b.BienXo_Xe,
                              a.MaKH,
                              a.TenKH,
                              a.SoPhong,
                              ee.MaNV,
                              ee.TenNV,
                              c.ThoiGian,
                              c.ViPham1
                          }).ToList();
                foreach (var item in VP)
                {
                    if (DateTime.Parse(item.ThoiGian) >= dateTimeTu && DateTime.Parse(item.ThoiGian) <= dateTimeDen)
                        dataTG.Rows.Add(item.MaXe, item.BienXo_Xe, item.MaKH, item.TenKH, item.SoPhong, item.MaNV, item.TenNV, item.ThoiGian, item.ViPham1);
                }
                list.DataSource = dataTG;
            }
            TenKH.GroupIndex = -1;
            TenNV.GroupIndex = -1;
            bindingsouce();
            gridControl1.Focus();
        }
        private void bindingsouce()
        {
            txtVP.DataBindings.Clear();
            txtVP.DataBindings.Add(new Binding("Text", gridControl1.DataSource, "ViPham1"));





        }
    }
}

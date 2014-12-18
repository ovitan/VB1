using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLDVVTHH.REPORT;
using QLDVVTHH.BLL;
using QLDVVTHH.DTO;

namespace QLDVVTHH.UI
{
    public partial class frmXuatKetQua : Form
    {
        public frmXuatKetQua()
        {
            InitializeComponent();
        }
        public string strReport = "";
        public string strPrinter = "";
        public bool bprint = false;
        public bool bExport = false;
        public string typeExport = "";
        public string strDuongDan = "";
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        private void frmXuatKetQua_Load(object sender, EventArgs e)
        {

            rpt.SetDisplayMode(DisplayMode.PrintLayout);
            rpt.ZoomMode = ZoomMode.PageWidth;
            rpt.ZoomPercent = 100;

            components = new Container();
            Microsoft.Reporting.WinForms.ReportDataSource datasource = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpt.LocalReport.ReportPath = Application.StartupPath + "\\REPORT\\" + strReport;
            REPORT.IN ng = new REPORT.IN();
            BindingSource source = new BindingSource(this.components);
            ((ISupportInitialize)ng).BeginInit();
            ((ISupportInitialize)source).BeginInit();
            source.DataSource = ng;
            datasource.Name = "DataSet1";
            datasource.Value = source;
            rpt.LocalReport.DataSources.Add(datasource);
            SetReportParameter(ng, source);
            ((ISupportInitialize)source).EndInit();
            ((ISupportInitialize)ng).EndInit();
            if (bprint)
                Print();
            else if (bExport)
            {
                Export();
            }
            else
                this.rpt.RefreshReport();
        }
        private void Export()
        {
            byte[] bytes;
            if (typeExport == "Xuất ra file Word")
            {
                bytes = rpt.LocalReport.Render("Word");
                //typeExport = ".doc";
            }
            else if (typeExport == "Xuất ra file Excel")
            {
                bytes = rpt.LocalReport.Render("Excel");
                //typeExport = ".xls";
            }
            else
            {
                bytes = rpt.LocalReport.Render("PDF");
                //typeExport = ".pdf"; 
            }
            FileStream fs = new FileStream(strDuongDan, FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            this.Close();
        }

        private void SetReportParameter(IN ia, BindingSource source)
        {

            switch (strReport)
            {
                case "rptkhachhang.rdlc":
                    REPORT.INTableAdapters.rpt_khachhangTableAdapter ct = new REPORT.INTableAdapters.rpt_khachhangTableAdapter();
                    ct.ClearBeforeFill = true;
                    source.DataMember = "rpt_khachhang";
                    ct.Fill(ia.rpt_khachhang);
                    break;
                //case "rptnhanvien.rdlc":
                //    REPORT.INTableAdapters.rpt_nhanvienTableAdapter ct2 = new REPORT.INTableAdapters.rpt_nhanvienTableAdapter();
                //    ct2.ClearBeforeFill = true;
                //    source.DataMember = "rpt_nhanvien";
                //    ct2.Fill(ia.rpt_nhanvien);
                //    break;
                //case "rptxe.rdlc":
                //    REPORT.INTableAdapters.rpt_xeTableAdapter ct3 = new REPORT.INTableAdapters.rpt_xeTableAdapter();
                //    ct3.ClearBeforeFill = true;
                //    source.DataMember = "rpt_xe";
                //    ct3.Fill(ia.rpt_xe);
                //    break;
                //case "rpthoadon.rdlc":
                //    REPORT.INTableAdapters.rpt_hoadonTableAdapter ct4 = new REPORT.INTableAdapters.rpt_hoadonTableAdapter();
                //    ct4.ClearBeforeFill = true;
                //    source.DataMember = "rpt_hoadon";
                //    ct4.Fill(ia.rpt_hoadon);
                //    break;
                default:
                    break;
            }
        }

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);

            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            ev.Graphics.DrawImage(pageImage, adjustedRect);

            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            string deviceInfo =
              @"<DeviceInfo><OutputFormat>EMF</OutputFormat>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            rpt.LocalReport.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
            if (m_streams == null || m_streams.Count == 0)
                MessageBox.Show("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                MessageBox.Show("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrinterSettings.PrinterName = strPrinter;
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
            this.Close();
        }
    }
}

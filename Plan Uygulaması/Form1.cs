using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            trackBarYeşil = new TrackBar
            {
                Minimum = 0,
                Maximum = 255,
                TickFrequency = 5
            };
            trackBarYeşil.Scroll += trackBarYeşil_Scroll;

            ToolStripControlHost controlHost = new ToolStripControlHost(trackBarYeşil);
            toolStripMenuItemTrackBar.DropDownItems.Add(controlHost);
        }
        KisaPlanEntities3 db = new KisaPlanEntities3();

        private void trackBarYeşil_Scroll(object sender, EventArgs e)
        {
            int yeşilDegeri = trackBarYeşil.Value;
            Color yeniArkaPlanRenk = Color.FromArgb(this.BackColor.R, yeşilDegeri, this.BackColor.B);
            this.BackColor = yeniArkaPlanRenk;
        }

        private TrackBar trackBarYeşil;


        public void GuncelleFormBasligi()
        {
            //yks kalan
            DateTime bugun = DateTime.Now;
            DateTime yksTarihi = new DateTime(bugun.Year, 6, 17);

            // Eğer YKS tarihi bu yıl geride kaldıysa, gelecek yılın YKS tarihini kullanın
            if (bugun > yksTarihi)
            {
                yksTarihi = yksTarihi.AddYears(1);
            }

            TimeSpan zamanFarki = yksTarihi - bugun;
            int yksKalan = (int)zamanFarki.TotalDays;

            int konuSayisi = dgw1.RowCount;
            string bugunn = DateTime.Now.ToString("dd/MM/yyyy");
            this.Text = $"Kısa Dönem Planlayıcı                              ☼Bitirilmesi Planlanan Konu: {konuSayisi}                              ☼Güncel Tarih: {bugunn}                              ☼Yks'ye Kalan Gün: {yksKalan}";
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            var guncellenceksatir = db.plandetay.Find(int.Parse(lblid.Text));
            guncellenceksatir.ders = cmbders.Text;
            guncellenceksatir.konu = txtkonu.Text;
            db.SaveChanges();
            cmbders.Text = "";
            txtkonu.Clear();
            guncelle();
            GuncelleFormBasligi();
        }


        public void tarihguncelle()
        {
            tarih t = new tarih();
            int tarihgenelid = 1;
            var gunceltarih = db.tarih.Find(tarihgenelid);
            txttarih.Text = gunceltarih.tarih1;
        }

        public void guncelle()
        {
            dgw1.DataSource=db.plandetay.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgw1.DataSource = db.plandetay.ToList();
            dgw1.Columns["id"].Visible = false;
            dgw1.Columns[1].HeaderText = "DERS";
            dgw1.Columns[2].HeaderText = "KONU";

            txttarih.Enabled = false;
            btntarihguncelle.Enabled = false;

            GuncelleFormBasligi();
            //başlangıçta tarih çekme
            tarihguncelle();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            plandetay p = new plandetay();
            p.ders = cmbders.Text;
            p.konu = txtkonu.Text;
            db.plandetay.Add(p);
            db.SaveChanges();
            guncelle();
            cmbders.Text = "";
            txtkonu.Clear();
            GuncelleFormBasligi();
        }

        private void dgw1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgw1.SelectedCells[0].RowIndex;
            lblid.Text = dgw1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            var silinceksatir = db.plandetay.Find(int.Parse(lblid.Text));
            db.plandetay.Remove(silinceksatir);
            db.SaveChanges();
            cmbders.Text = "";
            txtkonu.Clear();
            guncelle();
            GuncelleFormBasligi();
        }

        private void dgw1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgw1.SelectedCells[0].RowIndex;
            lblid.Text = dgw1.Rows[secilen].Cells[0].Value.ToString();
            cmbders.Text = dgw1.Rows[secilen].Cells[1].Value.ToString();
            txtkonu.Text = dgw1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void bnttarihguncelle_Click(object sender, EventArgs e)
        {
            int tarihid = 1;
            var guncellenceksatir = db.tarih.Find(tarihid);
            guncellenceksatir.tarih1 = txttarih.Text;
            db.SaveChanges();
            tarihguncelle();
        }


        private void tarihDüzenlemeKilidiniKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txttarih.Enabled = true;
            btntarihguncelle.Enabled = true;
        }

        private void tarihiKilitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txttarih.Enabled = false;
            btntarihguncelle.Enabled = false;

        }
    }
}

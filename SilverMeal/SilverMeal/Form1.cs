using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverMeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        OpenFileDialog dosya = new OpenFileDialog();
        double tlp;
        List<double> TalepList = new List<double>();
        private void btnExcel_Click(object sender, EventArgs e)
        {
            dosya.Filter = "Excel Dosyası |*.xlsx";
            dosya.ShowDialog();
            string yol = dosya.FileName;
            OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + yol + "; Extended Properties = 'Excel 12.0 Xml;HDR=YES;'");
            string baslik = txtSutunAdi.Text;
            string sayfaAdi = txtSayfaAdi.Text;
            int katSayi = 0;
            try
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("select * from [" + sayfaAdi + "$]", baglan);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    string adi = oku[baslik].ToString();
                    tlp = Convert.ToDouble(adi);
                    TalepList.Add(tlp);
                    listTalep.Items.Add(tlp.ToString());
                    listPeriyot.Items.Add(katSayi.ToString());
                    katSayi++;
                }
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        double EldeBulundurmaMal, SabitSiparisMal, ToplamMaliyet, OrtalamaMaliyet;

        double[] MaliyetListesi, MiktarListesi;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            MaliyetListesi = new double[TalepList.Count];
            MiktarListesi = new double[TalepList.Count];

            SabitSiparisMal = Convert.ToDouble(txtSabitMal.Text);
            EldeBulundurmaMal = Convert.ToDouble(txtEldeBulundurmaMal.Text);

            bool olduMu = false;
            int nerdeKaldik = 0;
            while (!olduMu)
            {
                bool arttiMi = false;
                int sayi = 0;
                tlp = 0;
                while (!arttiMi)
                {
                    ToplamMaliyet = 0;
                    for (int i = 0; i <= sayi; i++)
                        ToplamMaliyet = ToplamMaliyet + ((TalepList[nerdeKaldik + i] * (i)) * EldeBulundurmaMal);
                    OrtalamaMaliyet = (SabitSiparisMal + ToplamMaliyet) / (sayi + 1);
                    MaliyetListesi[nerdeKaldik + sayi] = OrtalamaMaliyet;
                    tlp = tlp + TalepList[nerdeKaldik + sayi];
                    if (sayi > 0 && MaliyetListesi[nerdeKaldik + sayi] > MaliyetListesi[nerdeKaldik + sayi - 1])
                    {
                        MiktarListesi[nerdeKaldik] = tlp - TalepList[nerdeKaldik + sayi];
                        nerdeKaldik += sayi;
                        arttiMi = true;
                    }
                    if (!arttiMi)
                    {
                        sayi++;
                        if (nerdeKaldik + sayi == MaliyetListesi.Length)
                        {
                            olduMu = true;
                            MiktarListesi[nerdeKaldik] = tlp;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i <= MiktarListesi.Length - 1; i++)
            {
                listMiktar.Items.Add(MiktarListesi[i].ToString());
            }
        }
    }
}


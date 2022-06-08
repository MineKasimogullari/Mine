using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoxmimm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GELİŞTİCİ: MİNE NUR KASIMOĞULLARI");
        }

        int sayac;
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "X";
        }
        
        private void buttonn_Click(object sender, EventArgs e)
        {
            
            Button Mine = (Button)sender;
            if (sayac%2==0) //tuttugum sayac ciftse X yazdır
            {
                Mine.Text = "X";
                Mine.Enabled = false;
                label2.Text = "O";//sıradakı oyuncuyu yazdır
            }
            else if(sayac%2==1)
            {
                Mine.Text = "O"; 
                Mine.Enabled = false;
                label2.Text = "X"; //sıradakı oyuncuyu yazdır
            }
            else if (sayac==9)
            {
               

                    MessageBox.Show("BERABERE!");
                    yeniOyun();
                    sayac++;


            }
            sayac++; //Her seferinde sayacı arttır bi X bi O yazdır
            
            kontrol();
            




        }
        private void kontrol()
        {
           
            if (bir.Text == iki.Text && iki.Text == uc.Text&&!bir.Enabled ) // buttonların textlerini tek tek kontrol et

            { if(sayac%2==1) MessageBox.Show("Kazanan X"); // sayac oyun bitincede artacagı için tekse X kazanır.
              else MessageBox.Show("Kazanan O");
                yeniOyun(); //Her kazanma için Yeni oyunu baslat
                
               

            }
            
          
            if (bir.Text == dort.Text && dort.Text == yedi.Text && !bir.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");  
                else MessageBox.Show("Kazanan O");
                yeniOyun();
               
                

            }

           if (bir.Text == bes.Text && bes.Text == dokuz.Text && !bir.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");
                else MessageBox.Show("Kazanan O");
                yeniOyun();
               
                
            }
         

           if (iki.Text == bes.Text && bes.Text == sekiz.Text && !iki.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");
                else MessageBox.Show("Kazanan O");
                yeniOyun();
                
                
            }
   
            if (uc.Text == alti.Text && alti.Text == dokuz.Text && !uc.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");
                else MessageBox.Show("Kazanan O");
                yeniOyun();
               
                
            }
            if (bir.Text == bes.Text && bes.Text == dokuz.Text && !bir.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");
                else MessageBox.Show("Kazanan O");
                yeniOyun();
                
                
            }
            if (dort.Text == bes.Text && bes.Text == alti.Text && !dort.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");
                else MessageBox.Show("Kazanan O");
                yeniOyun();
               
            }
             
            if (yedi.Text == sekiz.Text && sekiz.Text == dokuz.Text && !yedi.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");
                else MessageBox.Show("Kazanan O");
                yeniOyun();
                
                

            }
            if (uc.Text == bes.Text && bes.Text == yedi.Text && !uc.Enabled)
            {
                if (sayac % 2 == 1) MessageBox.Show("Kazanan X");
                else MessageBox.Show("Kazanan O");
                yeniOyun();
                
                

            }
           
        }
        private void yeniOyun()
        {
         
           
        }
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniOyun();
        
        }

        
    }
}

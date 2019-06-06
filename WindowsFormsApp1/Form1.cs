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

namespace WindowsFormsApp1
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private string tmpQ = string.Empty;
      private string tmpR = string.Empty;
      int q = 0; // змінна-лічильник
      int r = 0; // змінна-лічильник 
      int numberQ = 1; // змінна-лічильник
      int countqud = 0; // змінна-лічильник
      double minVper = 0; // змінна для зберігання min значення периметру
      double averVarea = 0; // змінна для зберігання max значення площі
      string filename;

      private List<Quadrilateral> quads = new List<Quadrilateral>();
      private List<Rhombus> rhoms = new List<Rhombus>();

      private void addQuad() // метод для додавання елемента до списку
      {
         quads.Add(new Quadrilateral(
            Convert.ToDouble(ax.Text),
            Convert.ToDouble(ay.Text),
            Convert.ToDouble(bx.Text),
            Convert.ToDouble(by.Text),
            Convert.ToDouble(cx.Text),
            Convert.ToDouble(cy.Text),
            Convert.ToDouble(dx.Text),
            Convert.ToDouble(dy.Text)
            ));
      }

      private void addRhom() // метод для додавання елемента до списку
      {
         rhoms.Add(new Rhombus(
            Convert.ToDouble(ax.Text),
            Convert.ToDouble(ay.Text),
            Convert.ToDouble(bx.Text),
            Convert.ToDouble(by.Text),
            Convert.ToDouble(cx.Text),
            Convert.ToDouble(cy.Text),
            Convert.ToDouble(dx.Text),
            Convert.ToDouble(dy.Text)
            ));
      }
      
      void fs () // метод для знаходження мінімального значення переметру чотирьохкутника
      {
         minVper = quads[0].PerimetrQuad;

         for (int i=1; i<quads.Count; i++)
         {            
            if (quads[i].PerimetrQuad  < minVper)
            {
               minVper = quads[i].PerimetrQuad;
               numberQ = 1+i;
            }
         }
      }

      double  fp() // метод для обчислення середнього значення площі ромба
      {
         for (int i = 0; i < rhoms.Count; i++)
         {
            averVarea += rhoms[i].SquareQuad;
         }
         return averVarea/rhoms.Count;
      }

      void zerovalue() // метод для присвоювання нуля змінним
      {
         ax.Value = 0;
         ay.Value = 0;
         bx.Value = 0;
         by.Value = 0;
         cx.Value = 0;
         cy.Value = 0;
         dx.Value = 0;
         dy.Value = 0;
      } 

      public void Read(BinaryReader br) // метод для зчитування координат з файлу
      {
         quads.Add(new Quadrilateral(
            br.ReadDouble(),
            br.ReadDouble(),
            br.ReadDouble(),
            br.ReadDouble(),
            br.ReadDouble(),
            br.ReadDouble(),
            br.ReadDouble(),
            br.ReadDouble()
            ));
      }

      public void Write(BinaryWriter bw, int i) // метод для запису координат в файл
      {
         bw.Write(quads[i].CoordA[0]);
         bw.Write(quads[i].CoordA[1]);

         bw.Write(quads[i].CoordB[0]);
         bw.Write(quads[i].CoordB[1]);

         bw.Write(quads[i].CoordC[0]);
         bw.Write(quads[i].CoordC[1]);
                                
         bw.Write(quads[i].CoordD[0]);
         bw.Write(quads[i].CoordD[1]);
      }

      private void calculateQUAD_Click(object sender, EventArgs e) 
      {
         this.addQuad();
         quads[quads.Count - 1].Calculate();
         tmpQ += "№" + ++q + quads[quads.Count - 1].ToString();
         this.fs();
         rTB1quad.Text = tmpQ + "Мінімальне значення периметру чотирикутника №" + numberQ + "\n" + minVper;
         zerovalue();
         ++countqud;
      }

      private void calculateRHOM_Click(object sender, EventArgs e)
      {
         this.addRhom();
         rhoms[rhoms.Count - 1].Calculate();
         tmpR += "№" + ++r + rhoms[rhoms.Count - 1].ToString();
         rTBrhom.Text = tmpR + "Середнє значення площі ромбів : " + Convert.ToString(fp()) + "\nЄ ромбом : " + rhoms[rhoms.Count - 1].isRhombus(); ;

      }

      private void savebut_Click(object sender, EventArgs e)
      {
         SaveFileDialog saveFileDialog1 = new SaveFileDialog();
         saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
         if (saveFileDialog1.ShowDialog() == DialogResult.OK)
         {
          filename = saveFileDialog1.FileName;
          FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
          BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
          bw.Write(Convert.ToInt16(quads.Count));
          for (int i = 0; i < quads.Count; i++)
             Write(bw, i);
          bw.Close();
          fs.Close();
         }
      }

      private void openbut_Click(object sender, EventArgs e)
      {
         OpenFileDialog openFileDialog1 = new OpenFileDialog();
         openFileDialog1.Filter = "txt files (*.txt)|*.txt";
         openFileDialog1.ShowDialog();
         filename = openFileDialog1.FileName;
         FileStream fsR = new FileStream(filename, FileMode.Open, FileAccess.Read);
         BinaryReader br = new BinaryReader(fsR, Encoding.UTF8);
         int n=1;
         n=br.ReadInt16();
         rTB1quad.Text = Convert.ToString(n);

         for(int i=0; i<n; i++)
            Read(br);

         br.Close();
         fsR.Close();
         for(int i=countqud; i<quads.Count; i++)
         {
            quads[i].Calculate();
            tmpQ += "№" + ++q + quads[i].ToString();
            this.fs();
            rTB1quad.Text = tmpQ + "Мінімальне значення периметру чотирикутника №" + numberQ + "\n" + minVper;
         }
      }
   }
}
   


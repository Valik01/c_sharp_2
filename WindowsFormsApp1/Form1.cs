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
      double minVper = 0;
      double averVarea = 0;

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
         for (int i=0; i<quads.Count; i++)
         {
            quads[0].Calculate();
            minVper = quads[0].PerimetrQuad;
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

      private void calculateQUAD_Click(object sender, EventArgs e)
      {
         this.addQuad();
         quads[quads.Count - 1].Calculate();
         tmpQ += "№" + ++q + quads[quads.Count - 1].ToString();
         this.fs();
         rTB1quad.Text = tmpQ + "Мінімальне значення периметру чотирикутника №" + numberQ + "\n" + minVper;

         ax.Value = 0;
         ay.Value = 0;
         bx.Value = 0;
         by.Value = 0;
         cx.Value = 0;
         cy.Value = 0;
         dx.Value = 0;
         dy.Value = 0;
      }
      
      private void calculateRHOM_Click(object sender, EventArgs e)
      {
         this.addRhom();
         rhoms[rhoms.Count - 1].Calculate();
         tmpR += "№" + ++r + rhoms[rhoms.Count - 1].ToString();
         rTBrhom.Text = tmpR + "Середнє значення площі ромбів : " + Convert.ToString(fp()) + "\nЄ ромбом : " + rhoms[rhoms.Count - 1].isRhombus(); ;

         ax.Value = 0;
         ay.Value = 0;
         bx.Value = 0;
         by.Value = 0;
         cx.Value = 0;
         cy.Value = 0;
         dx.Value = 0;
         dy.Value = 0;
      }
   }
}

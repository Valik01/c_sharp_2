using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   internal class Rhombus : Quadrilateral
   {
      public Rhombus(double ax, double ay, double bx, double by, double cx, double cy, double dx, double dy) //конструктор для класа Rhombus
         : base(ax,ay,bx,by,cx,cy,dx,dy)
      {
      }
      
      public bool isRhombus() // метод, який перевіряє, чи являється фігура ромбом
      {
         base.Calculate();
         if (SideAB.Equals(SideBC.Equals(SideCD.Equals(SideAD))))
           return true;

         return false;
      }
   }
}

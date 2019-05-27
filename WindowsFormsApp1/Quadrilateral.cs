using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   internal class Quadrilateral
   {
      private double[] coordA = new double[2];
      private double[] coordB = new double[2];
      private double[] coordC = new double[2];
      private double[] coordD = new double[2];
      private double sideAB;
      private double sideBC;
      private double sideCD;
      private double sideAD;
      private double diagonaleAC;
      private double diagonaleBD;
      private double perimetrQuad;
      private double squareQuad;

      public double SideAB { get => sideAB; }
      public double SideBC { get => sideBC; }
      public double SideCD { get => sideCD; }
      public double SideAD { get => sideAD; }
      public double DiagonaleAC { get => diagonaleAC; }
      public double DiagonaleBD { get => diagonaleBD; }
      public double PerimetrQuad { get => perimetrQuad; }
      public double SquareQuad { get => squareQuad; }

      public Quadrilateral(double ax, double ay, double bx, double by, double cx, double cy, double dx, double dy) // конструктор класа Quadrilateral
      {
         this.coordA[0] = ax;
         this.coordA[1] = ay;
         this.coordB[0] = bx;
         this.coordB[1] = by;
         this.coordC[0] = cx;
         this.coordC[1] = cy;
         this.coordD[0] = dx;
         this.coordD[1] = dy;
      }
      
      public void Calculate() // метод для обчислення сторін, діагоналей, периметру, площі фігури
      {
         sideAB = Math.Pow(Math.Pow(coordB[0] - coordA[0], 2) + Math.Pow(coordB[1] - coordA[1], 2), 0.5);
         sideBC = Math.Pow(Math.Pow(coordC[0] - coordB[0], 2) + Math.Pow(coordC[1] - coordB[1], 2), 0.5);
         sideCD = Math.Pow(Math.Pow(coordD[0] - coordC[0], 2) + Math.Pow(coordD[1] - coordC[1], 2), 0.5);
         sideAD = Math.Pow(Math.Pow(coordD[0] - coordA[0], 2) + Math.Pow(coordD[1] - coordA[1], 2), 0.5);
         diagonaleAC = Math.Pow(Math.Pow(coordC[0] - coordA[0], 2) + Math.Pow(coordC[1] - coordA[1], 2), 0.5);
         diagonaleBD = Math.Pow(Math.Pow(coordB[0] - coordD[0], 2) + Math.Pow(coordB[1] - coordD[1], 2), 0.5);
         perimetrQuad = sideAB + sideBC + sideCD + sideAD;
         squareQuad = 0.5 * Math.Abs((coordA[0] - coordB[0]) * (coordA[1] + coordB[1]) + (coordB[0] - coordC[0]) * (coordB[1] + coordC[1]) + (coordC[0] - coordD[0]) * (coordC[1] + coordD[1]) + (coordD[0] - coordA[0]) * (coordD[1] + coordA[1]));
      }

      public override string ToString() // метод виведення інформації про фігуру
      {
         return "\nside AB = " + sideAB.ToString("#.##") +
             "\nside BC = " + sideBC.ToString("#.##") +
             "\nside CD = " + sideCD.ToString("#.##") +
             "\nside AD = " + sideAD.ToString("#.##") +
             "\nDiagonale AC = " + DiagonaleAC.ToString("#.##") +
             "\nDiagonale BD = " + DiagonaleBD.ToString("#.##") +
             "\nperimetr = " + perimetrQuad.ToString("#.##") +
             "\nsquare = " + squareQuad.ToString("#.##")
             + "\n____________\n\n";
      }
   }
}

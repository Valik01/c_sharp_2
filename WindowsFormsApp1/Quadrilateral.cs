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
      public double[] CoordA { get => coordA; }
      public double[] CoordB { get => coordB; }
      public double[] CoordC { get => coordC; }
      public double[] CoordD { get => coordD; }

      public Quadrilateral(double ax, double ay, double bx, double by, double cx, double cy, double dx, double dy) // конструктор класа Quadrilateral
      {
         this.CoordA[0] = ax;
         this.CoordA[1] = ay;
         this.CoordB[0] = bx;
         this.CoordB[1] = by;
         this.CoordC[0] = cx;
         this.CoordC[1] = cy;
         this.CoordD[0] = dx;
         this.CoordD[1] = dy;
      }
      
      public void Calculate() // метод для обчислення сторін, діагоналей, периметру, площі фігури
      {
         sideAB = Math.Pow(Math.Pow(CoordB[0] - CoordA[0], 2) + Math.Pow(CoordB[1] - CoordA[1], 2), 0.5);
         sideBC = Math.Pow(Math.Pow(CoordC[0] - CoordB[0], 2) + Math.Pow(CoordC[1] - CoordB[1], 2), 0.5);
         sideCD = Math.Pow(Math.Pow(CoordD[0] - CoordC[0], 2) + Math.Pow(CoordD[1] - CoordC[1], 2), 0.5);
         sideAD = Math.Pow(Math.Pow(CoordD[0] - CoordA[0], 2) + Math.Pow(CoordD[1] - CoordA[1], 2), 0.5);
         diagonaleAC = Math.Pow(Math.Pow(CoordC[0] - CoordA[0], 2) + Math.Pow(CoordC[1] - CoordA[1], 2), 0.5);
         diagonaleBD = Math.Pow(Math.Pow(CoordB[0] - CoordD[0], 2) + Math.Pow(CoordB[1] - CoordD[1], 2), 0.5);
         perimetrQuad = sideAB + sideBC + sideCD + sideAD;
         squareQuad = 0.5 * Math.Abs((CoordA[0] - CoordB[0]) * (CoordA[1] + CoordB[1]) + (CoordB[0] - CoordC[0]) * (CoordB[1] + CoordC[1]) + (CoordC[0] - CoordD[0]) * (CoordC[1] + CoordD[1]) + (CoordD[0] - CoordA[0]) * (CoordD[1] + CoordA[1]));
      }


      public override string ToString() // метод виведення інформації про фігуру
      {
         return "\nside AB = " + (sideAB != 0 ? sideAB.ToString("#.##") : "0") +
             "\nside BC = " + (sideBC != 0 ? sideBC.ToString("#.##") : "0") +
             "\nside CD = " + (sideCD != 0 ? sideCD.ToString("#.##") : "0") +
             "\nside AD = " + (sideAD != 0 ? sideAD.ToString("#.##") : "0") +
             "\nDiagonale AC = " + (DiagonaleAC !=0 ? DiagonaleAC.ToString("#.##") : "0") +
             "\nDiagonale BD = " +(DiagonaleBD !=0 ? DiagonaleBD.ToString("#.##") : "0")+
             "\nperimetr = " +(perimetrQuad !=0 ? perimetrQuad.ToString("#.##") : "0") +
             "\nsquare = " + (squareQuad !=0 ?  squareQuad.ToString("#.##") : "0")
             + "\n____________\n\n";
      }
   }
}

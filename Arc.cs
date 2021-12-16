// File:    Arc.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 15:07:11
// Purpose: Definition of Class Arc

using System;
using System.Collections.Generic;

public class Arc : IPrimitive
{
   private double radius;
   private double startAngle;
   private double endAngle;
   private double sweepAngle;
   private Point point1;
   private Point point2;
   private Point originalPoint;
   private Point middlePoint;
   
   private IArc iArc;
   
   public double StartAngle
   {
      get
      {
         return startAngle;
      }
      set
      {
         this.startAngle = value;
      }
   }
   
   public double EndAngle
   {
      get
      {
         return endAngle;
      }
      set
      {
         this.endAngle = value;
      }
   }
   
   public double SweepAngle
   {
      get
      {
         return sweepAngle;
      }
      set
      {
         this.sweepAngle = value;
      }
   }
   
   public double Radius
   {
      get
      {
         return radius;
      }
      set
      {
         this.radius = value;
      }
   }
   
   public Point Point1
   {
      get
      {
         return point1;
      }
      set
      {
         this.point1 = value;
      }
   }
   
   public Point Point2
   {
      get
      {
         return point2;
      }
      set
      {
         this.point2 = value;
      }
   }
   
   public Point OriginalPoint
   {
      get
      {
         return originalPoint;
      }
      set
      {
         this.originalPoint = value;
      }
   }
   
   public Point MiddlePoint
   {
      get
      {
         return middlePoint;
      }
      set
      {
         this.middlePoint = value;
      }
   }
   
   public Arc()
   {
   }
   
   public Arc(IArc iArc)
   {
           this.iArc = iArc;
           this.originalPoint = this.iArc.GetOriginalPoint();
           this.radius = this.iArc.GetRadius();
           this.startAngle = this.iArc.GetStartAngle();
           this.endAngle = this.iArc.GetEndAngle() < this.startAngle ? this.iArc.GetEndAngle() + 360 : this.iArc.GetEndAngle();
           this.sweepAngle = this.iArc.GetSweepAngle();
           this.point1 = this.iArc.GetStartPoint();
           this.point2 = this.iArc.GetEndPoint();
           this.middlePoint = this.GetMiddlePoint();
   }
   
   public Point[] GetExtremums()
   {
      List<Point> extremums = new List<Point>();
           if ((this.startAngle < 0 && this.endAngle >= 0) || (this.startAngle < 360 && this.endAngle >= 360))
               extremums.Add(new Point { X = this.originalPoint.X + this.radius, Y = this.originalPoint.Y });
           if (this.startAngle < 90 && this.endAngle >= 90)
               extremums.Add(new Point { X = this.originalPoint.X, Y = this.originalPoint.Y + this.radius });
           if (this.startAngle < 180 && this.endAngle >= 180)
               extremums.Add(new Point { X = this.originalPoint.X - this.radius, Y = this.originalPoint.Y });
           if (this.startAngle < 270 && this.endAngle >= 270)
               extremums.Add(new Point { X = this.originalPoint.X, Y = this.originalPoint.Y - this.radius });
           return extremums.ToArray();
   }
   
   public Point GetMiddlePoint()
   {
      double middleAngle = (this.startAngle + this.endAngle) / 2;
           return new Point
           {
               X = this.originalPoint.X + this.radius * Math.Cos(middleAngle * Math.PI / 180),
               Y = this.originalPoint.Y + this.radius * Math.Sin(middleAngle * Math.PI / 180)
           };
   }
   
   public Point GetStartPoint()
   {
      return this.point1;
   }
   
   public Point GetEndPoint()
   {
      return this.point2;
   }

}
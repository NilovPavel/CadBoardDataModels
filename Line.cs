// File:    Line.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 15:07:12
// Purpose: Definition of Class Line

using System;
using System.Collections.Generic;

public class Line : IPrimitive
{
   private Point point1;
   private Point point2;
   private Point middlePoint;
   
   private ILine iLine;
   
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
   
   public Line()
   {
   }
   
   public Line(ILine iLine)
   {
           this.iLine = iLine;
           this.point1 = this.iLine.GetStartPoint();
           this.point2 = this.iLine.GetEndPoint();
           this.middlePoint = this.GetMiddlePoint();
   }
   
   public Point[] GetExtremums()
   {
      List<Point> points = new List<Point>();
           points.Add(this.point1);
           points.Add(this.point2);
           return points.ToArray();
   }
   
   public Point GetMiddlePoint()
   {
      return new Point
         {
             X = (this.Point1.X + this.Point2.X) / 2,
             Y = (this.Point1.Y + this.Point2.Y) / 2
         };
   }
   
   public double GetTiltAngle()
   {
           double alpha = Math.Atan2((this.Point2.Y - this.Point1.Y), (this.Point2.X - this.Point1.X));
           double deg_alpha = alpha * 180 / Math.PI;
           return deg_alpha;
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
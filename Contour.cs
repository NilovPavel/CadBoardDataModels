// File:    Contour.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 11:03:15
// Purpose: Definition of Class Contour

using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public class Contour
{
   private Point[] contourPoints;
   
   private System.Collections.Generic.List<Line> line;
   
   /// <summary>
   /// Property for collection of Line
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Line> Line
   {
      get
      {
         if (line == null)
            line = new System.Collections.Generic.List<Line>();
         return line;
      }
      set
      {
         RemoveAllLine();
         if (value != null)
         {
            foreach (Line oLine in value)
               AddLine(oLine);
         }
      }
   }
   
   /// <summary>
   /// Add a new Line in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddLine(Line newLine)
   {
      if (newLine == null)
         return;
      if (this.line == null)
         this.line = new System.Collections.Generic.List<Line>();
      if (!this.line.Contains(newLine))
         this.line.Add(newLine);
   }
   
   /// <summary>
   /// Remove an existing Line from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveLine(Line oldLine)
   {
      if (oldLine == null)
         return;
      if (this.line != null)
         if (this.line.Contains(oldLine))
            this.line.Remove(oldLine);
   }
   
   /// <summary>
   /// Remove all instances of Line from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllLine()
   {
      if (line != null)
         line.Clear();
   }
   private System.Collections.Generic.List<Arc> arc;
   
   /// <summary>
   /// Property for collection of Arc
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Arc> Arc
   {
      get
      {
         if (arc == null)
            arc = new System.Collections.Generic.List<Arc>();
         return arc;
      }
      set
      {
         RemoveAllArc();
         if (value != null)
         {
            foreach (Arc oArc in value)
               AddArc(oArc);
         }
      }
   }
   
   /// <summary>
   /// Add a new Arc in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddArc(Arc newArc)
   {
      if (newArc == null)
         return;
      if (this.arc == null)
         this.arc = new System.Collections.Generic.List<Arc>();
      if (!this.arc.Contains(newArc))
         this.arc.Add(newArc);
   }
   
   /// <summary>
   /// Remove an existing Arc from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveArc(Arc oldArc)
   {
      if (oldArc == null)
         return;
      if (this.arc != null)
         if (this.arc.Contains(oldArc))
            this.arc.Remove(oldArc);
   }
   
   /// <summary>
   /// Remove all instances of Arc from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllArc()
   {
      if (arc != null)
         arc.Clear();
   }
   private IContour iContour;
   private ContourNexus contourNexus;
   
   public Contour()
   {
   }
   
   public Contour(IContour iContour)
   {
      this.iContour = iContour;
      foreach (ILine iline in this.iContour.GetILines())
               this.AddLine(new Line(iline));
               foreach (IArc iarc in this.iContour.GetIArcs())
               this.AddArc(new Arc(iarc));
   }
   
   public void GetExtremums(ref double minX, ref double minY, ref double maxX, ref double maxY)
   {
           List<Point> all_points = new List<Point>();
           this.Line.ForEach(x => all_points.AddRange(x.GetExtremums()));
           this.Arc.ForEach(x => all_points.AddRange(x.GetExtremums()));
           minX = all_points.Select(item => item.X).Min();
           minY = all_points.Select(item => item.Y).Min();
           maxX = all_points.Select(item => item.X).Max();
           maxY = all_points.Select(item => item.Y).Max();
   }
   
   public bool CheckClosedContour()
   {
      this.contourNexus = new ContourNexus(this);
      this.contourPoints = this.contourNexus.GetPoints();
      return this.contourNexus.GetIsClosed();
   }
   
   public bool CheckSelfIntersecting()
   {
      throw new NotImplementedException();
   }
   
   public bool PointInContour(Point destPoint)
   {
           double num = 0.0;
           double x = destPoint.X;
           double y = destPoint.Y;
           for (int i = 0; i < this.contourPoints.Length - 1; i++)
           {
               double x2 = this.contourPoints[i].X;
               double x3 = this.contourPoints[i + 1].X;
               double y2 = this.contourPoints[i].Y;
               double y3 = this.contourPoints[i + 1].Y;
               double value = (x3 - x2) * (y2 - y) - (x2 - x) * (y3 - y2);
               double num2 = (double)Math.Sign(value) * (Math.Atan(((x3 - x2) * (x2 - x) + (y3 - y2) * (y2 - y) + (x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2)) / Math.Abs(value)) - Math.Atan(((x3 - x2) * (x2 - x) + (y3 - y2) * (y2 - y)) / Math.Abs(value)));
               num += num2;
           }
           num = Math.Round(num);
           return Math.Ceiling(num) != 0.0;
   }

}
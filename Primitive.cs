// File:    Primitive.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 15:12:43
// Purpose: Definition of Class Primitive

using System;

[Serializable]
public abstract class Primitive
{
   private int type;
   
   protected double x0;
   protected double y0;
   
   public System.Collections.Generic.List<Point> point;
   
   /// <summary>
   /// Property for collection of Point
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Point> Point
   {
      get
      {
         if (point == null)
            point = new System.Collections.Generic.List<Point>();
         return point;
      }
      set
      {
         RemoveAllPoint();
         if (value != null)
         {
            foreach (Point oPoint in value)
               AddPoint(oPoint);
         }
      }
   }
   
   /// <summary>
   /// Add a new Point in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddPoint(Point newPoint)
   {
      if (newPoint == null)
         return;
      if (this.point == null)
         this.point = new System.Collections.Generic.List<Point>();
      if (!this.point.Contains(newPoint))
         this.point.Add(newPoint);
   }
   
   /// <summary>
   /// Remove an existing Point from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemovePoint(Point oldPoint)
   {
      if (oldPoint == null)
         return;
      if (this.point != null)
         if (this.point.Contains(oldPoint))
            this.point.Remove(oldPoint);
   }
   
   /// <summary>
   /// Remove all instances of Point from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllPoint()
   {
      if (point != null)
         point.Clear();
   }

}
// File:    ContourNexus.cs
// Author:  nilov_pg
// Created: 18 февраля 2019 г. 8:26:54
// Purpose: Definition of Class ContourNexus

using System;
using System.Collections.Generic;
using System.Linq;

public class ContourNexus
{
   private IPrimitive[] nexusPrimitives;
   private Contour contour;
   private List<IPrimitive> unSortPrimitives;
   
   private void Initialization()
   {
           this.unSortPrimitives = new List<IPrimitive>();
           this.unSortPrimitives.AddRange(this.contour.Arc);
           this.unSortPrimitives.AddRange(this.contour.Line);
   }
   
   private List<IPrimitive> CreateNexus()
   {
           List<IPrimitive> primitives = new List<IPrimitive>();
           IPrimitive firstPrimitive = this.unSortPrimitives.First();
           IPrimitive currentPrimitive = firstPrimitive;
           do
           {
               primitives.Add(currentPrimitive);
               //Поскольку очередность в примитивах может быть нарушена, то нужно проверить начальные и конечные точки, а также проверить по средней точке, не один и тот же ли это примитив
               currentPrimitive = this.unSortPrimitives.Where(item => ((item.GetStartPoint().X == currentPrimitive.GetEndPoint().X && item.GetStartPoint().Y == currentPrimitive.GetEndPoint().Y)
                                                                           || (item.GetEndPoint().X == currentPrimitive.GetEndPoint().X && item.GetEndPoint().Y == currentPrimitive.GetEndPoint().Y)
                                                                           || (item.GetStartPoint().X == currentPrimitive.GetStartPoint().X && item.GetStartPoint().Y == currentPrimitive.GetStartPoint().Y))
                                                                           && !item.Equals(currentPrimitive) && !primitives.Exists(y => y.Equals(item))
                                                                           ).FirstOrDefault();
   
               if (currentPrimitive == null)
                   break;
           }
           while (!currentPrimitive.Equals(firstPrimitive));
           return primitives;
   }
   
   public IPrimitive[] NexusPrimitives
   {
      get
      {
         return nexusPrimitives;
      }
      set
      {
         this.nexusPrimitives = value;
      }
   }
   
   public ContourNexus(Contour contour)
   {
      this.contour = contour;
      this.Initialization();
      this.nexusPrimitives = this.CreateNexus().ToArray();
   }
   
   public bool GetIsClosed()
   {
      return this.nexusPrimitives.Count() == this.unSortPrimitives.Count;
   }
   
   public Point[] GetPoints()
   {
           List<Point> points = new List<Point>();
           foreach (IPrimitive primitive in nexusPrimitives)
               points.Add(primitive.GetStartPoint());
           points.Add(points.First());
           return points.ToArray();
   }

}
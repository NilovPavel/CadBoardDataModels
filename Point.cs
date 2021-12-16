// File:    Point.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 9:26:13
// Purpose: Definition of Class Point

using System;

public class Point
{
   private double x;
   private double y;
   
   public double X
   {
      get
      {
         return x;
      }
      set
      {
         this.x = value;
      }
   }
   
   public double Y
   {
      get
      {
         return y;
      }
      set
      {
         this.y = value;
      }
   }

}
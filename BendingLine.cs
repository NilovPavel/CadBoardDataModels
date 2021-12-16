// File:    BendingLine.cs
// Author:  nilov_pg
// Created: 11 января 2019 г. 16:11:16
// Purpose: Definition of Class BendingLine

using System;

public class BendingLine
{
   private double radius;
   private Line line;
   private double angle;
   private short foldIndex;
   
   private IBendingLine iBendingLine;
   
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
   
   public Line Line
   {
      get
      {
         return line;
      }
      set
      {
         this.line = value;
      }
   }
   
   public double Angle
   {
      get
      {
         return angle;
      }
      set
      {
         this.angle = value;
      }
   }
   
   public short FoldIndex
   {
      get
      {
         return foldIndex;
      }
      set
      {
         this.foldIndex = value;
      }
   }
   
   public BendingLine()
   {}
   
   public BendingLine(IBendingLine iBendingLine)
   {
      this.iBendingLine = iBendingLine;
      this.angle = this.iBendingLine.GetAngle();
      this.radius = this.iBendingLine.GetBendRadius();
      this.line = this.iBendingLine.GetLine();
      this.foldIndex = this.iBendingLine.GetFoldIndex();
   }

}
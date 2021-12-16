// File:    Cute.cs
// Author:  nilov_pg
// Created: 24 ноября 2018 г. 11:48:28
// Purpose: Definition of Class Cute

using System;

public class Cute
{
   private ICute iCute;
   private IContour iContour;
   
   public Cute()
   {
   }
   
   public Cute(ICute iCute)
   {
      this.iCute = iCute;
      this.iContour = this.iCute.GetIContour();
      this.contour = new Contour(this.iContour);
   }
   
   public Contour contour;

}
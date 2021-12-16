// File:    HolePad.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 11:38:58
// Purpose: Definition of Class HolePad

using System;

public class HolePad
{
   private IHolePad iHolePad;
   private IContour iContour;
   
   public Contour contour;
   
   public HolePad()
   {
   }
   
   public HolePad(IHolePad iHolePad)
   {
      this.iHolePad = iHolePad;
      this.iContour = this.iHolePad.GetIContour();
      this.contour = new Contour(this.iContour);
   }

}
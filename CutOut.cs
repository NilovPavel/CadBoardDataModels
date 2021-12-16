// File:    CutOut.cs
// Author:  nilov_pg
// Created: 24 ноября 2018 г. 11:48:28
// Purpose: Definition of Class CutOut

using System;

public class CutOut
{
   private ICutOut iCutOut;
   private IContour iContour;
   
   public Contour contour;
   
   public CutOut()
   {
   }
   
   public CutOut(ICutOut iCutOut)
   {
      this.iCutOut = iCutOut;
      this.iContour = this.iCutOut.GetIContour();
      this.contour = new Contour(this.iContour);
   }

}
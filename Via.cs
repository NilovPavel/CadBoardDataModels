// File:    Via.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 12:01:35
// Purpose: Definition of Class Via

using System;

[Serializable]
public class Via
{
   private IVia iVia;
   private IContour iContour;
   
   public Contour contour;
   
   public Via()
   {
   }
   
   public Via(IVia iVia)
   {
           this.iVia = iVia;
           this.iContour = this.iVia.GetIContour();
           this.contour = new Contour(this.iContour);
   }

}
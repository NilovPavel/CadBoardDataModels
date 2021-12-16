// File:    Pad.cs
// Author:  Павел
// Created: 17 апреля 2020 г. 20:31:12
// Purpose: Definition of Class Pad

using System;

public class Pad
{
   private IPad iPad;
   
   public Contour contour;
   public Hole hole;
   
   public Pad()
   {
   }
   
   public Pad(IPad iPad)
   {
      this.iPad = iPad;
      this.contour = new Contour(this.iPad.GetContour());
   }

}
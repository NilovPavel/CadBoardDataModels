// File:    Tracks.cs
// Author:  Павел
// Created: 29 марта 2020 г. 22:04:25
// Purpose: Definition of Class Tracks

using System;

public class Tracks
{
   private ITracks iTracks;
   
   public double width;
   
   public Contour contour;
   
   public Tracks()
   {
   }
   
   public Tracks(ITracks iTracks)
   {
      this.iTracks = iTracks;
      this.width = this.iTracks.GetWidth();
      this.contour = new Contour(this.iTracks.GetIContour());
   }

}
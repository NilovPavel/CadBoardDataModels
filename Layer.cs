// File:    Layer.cs
// Author:  Павел
// Created: 29 марта 2020 г. 21:57:21
// Purpose: Definition of Class Layer

using System;

public class Layer
{
   private ILayer iLayer;
   
   public string layerName;
   public double thickness;
   public int layerNumber;
   
   public Paint paint;
   
   public Layer()
   {
   }
   
   public Layer(ILayer iLayer)
   {
      this.iLayer = iLayer;
      this.layerName = this.iLayer.GetLayerName();
      this.layerNumber = this.iLayer.GetLayerNumber();
      this.thickness = this.iLayer.GetThickness();
      this.paint = new Paint(this.iLayer.GetPaint());
   }

}
// File:    ILayer.cs
// Author:  Павел
// Created: 29 марта 2020 г. 22:00:11
// Purpose: Definition of Interface ILayer

using System;

public interface ILayer
{
   string GetLayerName();
   
   double GetThickness();
   
   int GetLayerNumber();
   
   IPaint GetPaint();

}
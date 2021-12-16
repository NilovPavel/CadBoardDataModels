// File:    ILayerStack.cs
// Author:  nilov_pg
// Created: 23 ноября 2018 г. 9:32:35
// Purpose: Definition of Interface ILayerStack

using System;

public interface ILayerStack
{
   ILayer[] GetILayers();
   
   bool GetIsFlex();
   
   string GetName();
   
   double GetHeight();
   
   double GetHeightFirstLayer();
   
   string GetID();

}
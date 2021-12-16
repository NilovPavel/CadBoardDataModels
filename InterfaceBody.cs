// File:    InterfaceBody.cs
// Author:  nilov_pg
// Created: 23 ноября 2018 г. 14:04:20
// Purpose: Definition of Interface InterfaceBody

using System;

public interface InterfaceBody
{
   bool GetIsFlex();
   
   double GetHeightFirstLayer();
   
   double GetTotalHeight();
   
   IContour GetIContour();

}
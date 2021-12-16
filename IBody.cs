// File:    IBody.cs
// Author:  nilov_pg
// Created: 23 ноября 2018 г. 14:04:20
// Purpose: Definition of Interface IBody

using System;

public interface IBody
{
   bool GetIsFlex();
   
   double GetHeightFirstLayer();
   
   double GetTotalHeight();
   
   IContour GetIContour();
   
   IBendingLine[] GetBendingLines();

}
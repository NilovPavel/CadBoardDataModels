// File:    IArc.cs
// Author:  nilov_pg
// Created: 24 ноября 2018 г. 11:11:49
// Purpose: Definition of Interface IArc

using System;

public interface IArc
{
   double GetRadius();
   
   double GetStartAngle();
   
   double GetEndAngle();
   
   double GetSweepAngle();
   
   Point GetOriginalPoint();
   
   Point GetStartPoint();
   
   Point GetEndPoint();

}
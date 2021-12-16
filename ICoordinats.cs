// File:    ICoordinats.cs
// Author:  nilov_pg
// Created: 21 декабря 2018 г. 11:59:01
// Purpose: Definition of Interface ICoordinats

using System;

public interface ICoordinats
{
   double GetX();
   
   double GetY();
   
   double GetZ();
   
   double GetAngle();
   
   double[] GetQuaternion();

}
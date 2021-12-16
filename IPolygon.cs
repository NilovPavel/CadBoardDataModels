// File:    IPolygon.cs
// Author:  Павел
// Created: 8 апреля 2020 г. 19:53:56
// Purpose: Definition of Interface IPolygon

using System;

public interface IPolygon
{
   IHatch GetIHatch();
   
   IContour GetIContour();

}
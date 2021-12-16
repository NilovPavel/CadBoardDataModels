// File:    IContour.cs
// Author:  nilov_pg
// Created: 24 ноября 2018 г. 10:39:31
// Purpose: Definition of Interface IContour

using System;

public interface IContour
{
   ILine[] GetILines();
   
   IArc[] GetIArcs();

}
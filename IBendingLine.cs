// File:    IBendingLine.cs
// Author:  nilov_pg
// Created: 11 января 2019 г. 16:59:53
// Purpose: Definition of Interface IBendingLine

using System;

public interface IBendingLine
{
   double GetBendRadius();
   
   Line GetLine();
   
   double GetAngle();
   
   short GetFoldIndex();

}
// File:    IPrimitive.cs
// Author:  nilov_pg
// Created: 15 января 2019 г. 14:25:28
// Purpose: Definition of Interface IPrimitive

using System;

public interface IPrimitive
{
   Point[] GetExtremums();
   
   Point GetMiddlePoint();
   
   Point GetStartPoint();
   
   Point GetEndPoint();

}
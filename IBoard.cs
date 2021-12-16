// File:    IBoard.cs
// Author:  nilov_pg
// Created: 23 ноября 2018 г. 14:45:21
// Purpose: Definition of Interface IBoard

using System;

public interface IBoard
{
   IBody[] GetBodies();
   
   Point GetOrigin();
   
   ICutOut[] GetCutouts();
   
   IVia[] GetVias();
   
   IHolePad[] GetHolePads();

}
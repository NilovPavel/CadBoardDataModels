// File:    IBoardCAD.cs
// Author:  nilov_pg
// Created: 23 ноября 2018 г. 14:45:21
// Purpose: Definition of Interface IBoardCAD

using System;

public interface IBoardCAD
{
   IBody[] GetBodies();
   
   Point GetOrigin();
   
   ICutOut[] GetCutouts();
   
   IVia[] GetVias();
   
   IHolePad[] GetHolePads();
   
   ILayer[] GetLayers();

}
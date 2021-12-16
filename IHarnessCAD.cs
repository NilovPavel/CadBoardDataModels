// File:    IHarnessCAD.cs
// Author:  Павел
// Created: 31 марта 2020 г. 10:48:34
// Purpose: Definition of Interface IHarnessCAD

using System;

public interface IHarnessCAD
{
   IWire[] GetIWires();
   
   ICable[] GetICables();

}
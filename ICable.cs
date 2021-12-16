// File:    ICable.cs
// Author:  Павел
// Created: 31 марта 2020 г. 10:48:34
// Purpose: Definition of Interface ICable

using System;

public interface ICable : INet
{
   IWire[] GetIWires();

}
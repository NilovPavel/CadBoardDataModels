// File:    IVariant.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 12:30:25
// Purpose: Definition of Interface IVariant

using System;

public interface IVariant
{
   string GetVariantName();
   
   IComponentCAD[] GetCollection();

}
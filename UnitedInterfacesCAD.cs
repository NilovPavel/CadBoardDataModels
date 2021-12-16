// File:    UnitedInterfacesCAD.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 12:34:24
// Purpose: Definition of Class UnitedInterfacesCAD

using System;

public abstract class UnitedInterfacesCAD
{
   protected abstract void Initialization();
   
   public ICadAsseblyInterFace iCadAsseblyInterFace;
   public INotesCAD iNotesCAD;
   public IVariantCAD iVariantCAD;
   public IBoardCAD iBoardCAD;
   public IHierarchyCAD iHierarchyCAD;
   public IProjectPropertiesCAD iProjectPropertiesCAD;

}
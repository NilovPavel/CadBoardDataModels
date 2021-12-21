// File:    IAssemblyCAD.cs
// Author:  nilov_pg
// Created: 24 января 2019 г. 16:02:59
// Purpose: Definition of Interface IAssemblyCAD

using System;

public interface IAssemblyCAD
{
   IProjectPropertiesCAD GetIProjectPropertiesCAD();
   
   IBoardCAD GetIBoardCAD();
   
   IVariantCAD GetIVariantCAD();
   
   IHarnessCAD GetIHarnessCAD();

}
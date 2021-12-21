// File:    BoardAssembly.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 10:57:34
// Purpose: Definition of Class BoardAssembly

using System;
using System.Xml.Serialization;

[Serializable]
public class Assembly
{
   private IAssemblyCAD iAssemblyCAD;
   
   public ProjectProperties projectProperties;
   public Board board;
   public VariantCAD variantCAD;
   public Harness harness;
   
   public Assembly(IAssemblyCAD iAssemblyCAD)
   {
         this.iAssemblyCAD = iAssemblyCAD;
         this.projectProperties = new ProjectProperties(this.iAssemblyCAD.GetIProjectPropertiesCAD());
         this.board = new Board(this.iAssemblyCAD.GetIBoardCAD());
         this.variantCAD = new VariantCAD(this.iAssemblyCAD.GetIVariantCAD());
         this.harness = new Harness(this.iAssemblyCAD.GetIHarnessCAD());
   }
   
   public Assembly()
   {
   }

}
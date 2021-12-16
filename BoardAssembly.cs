// File:    BoardAssembly.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 10:57:34
// Purpose: Definition of Class BoardAssembly

using System;
using System.Xml.Serialization;

[Serializable]
public class BoardAssembly
{
   private IAssemblyCAD iAssemblyCAD;
   
   public BoardAssembly(IAssemblyCAD iAssemblyCAD)
   {
      this.iAssemblyCAD = iAssemblyCAD;
      this.projectProperties = new ProjectProperties(this.iAssemblyCAD.iProjectPropertiesCAD);
      if (this.iAssemblyCAD.iBoard!=null)
           this.board = new Board(this.iAssemblyCAD.iBoard);
      if (this.iAssemblyCAD.iHierarchy!=null)
           this.hierarchy = new Hierarchy(this.iAssemblyCAD.iHierarchy);
      this.notes = new Notes[this.iAssemblyCAD.iNotesCAD.GetRazdelNames().Length];
      for (int i = 0; i < this.iAssemblyCAD.iNotesCAD.GetRazdelNames().Length; i++)
           this.notes[i] = new Notes(this.iAssemblyCAD.iNotesCAD.GetRazdelNames()[i], this.iAssemblyCAD.iNotesCAD);
      this.variantCAD = new VariantCAD(this.iAssemblyCAD.iVariantCAD);
   }
   
   public BoardAssembly()
   {
   }
   
   public ProjectProperties projectProperties;
   public Board board;
   public Hierarchy hierarchy;
   public Notes[] notes;
   public VariantCAD variantCAD;

}
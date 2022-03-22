// File:    Hierarchy.cs
// Author:  nilov_pg
// Created: 11 декабря 2018 г. 12:50:18
// Purpose: Definition of Class Hierarchy

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public class Hierarchy
{
   private IHierarchyCAD iHierarchyCAD;
   
   public AssemblyComponentID assemblyComponentID;
   
   public Hierarchy()
   {}
   
   public Hierarchy(IHierarchyCAD iHierarchyCAD)
   {
      this.iHierarchyCAD = iHierarchyCAD;
      if (this.iHierarchyCAD == null)
               return;
      this.assemblyComponentID = this.iHierarchyCAD.BuildTree();
   }

}
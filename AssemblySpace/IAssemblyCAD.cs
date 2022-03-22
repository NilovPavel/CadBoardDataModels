// File:    IAssemblyCAD.cs
// Author:  nilov_pg
// Created: 24 января 2019 г. 16:02:59
// Purpose: Definition of Interface IAssemblyCAD

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public interface IAssemblyCAD
{
   IProjectPropertiesCAD GetIProjectPropertiesCAD();
   
   IHierarchyCAD GetIHierarchyCAD();
   
   INotesCAD GetINotesCAD();
   
   IVariantCAD GetIVariantCAD();
   
}
// File:    IComponentCAD.cs
// Author:  nilov_pg
// Created: 20 декабря 2018 г. 10:24:38
// Purpose: Definition of Interface IComponentCAD

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public interface IComponentCAD
{
   string GetUniqueID();
   
   string GetLogicalDesignator();
   
   string GetConfiguration();
   
   bool GetFitted();
   
   void SetFitted(bool isFitted);
   
   IDataESKD GetIComponentData();
   
   IComponentCAD Clone();

   string GetPhysicalDesignator();
}
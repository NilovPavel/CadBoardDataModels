// File:    IProjectPropertiesCAD.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 12:08:51
// Purpose: Definition of Interface IProjectPropertiesCAD

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public interface IProjectPropertiesCAD
{
   void ReadProperties();
   
   string GetParameterValue(string parameterName);
   
   void WriteProperties();
   
   void WriteValue(string parameterName, string parameterValue);
   
   string[] GetPropertieNames();

}
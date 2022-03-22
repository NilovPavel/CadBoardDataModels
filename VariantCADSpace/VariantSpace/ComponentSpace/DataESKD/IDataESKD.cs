// File: IDataESKD.cs
// Author: nilov_pg
// Created: 21 января 2019 г. 17:28:27
// Purpose: Definition of Interface IDataESKD

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public interface IDataESKD
{
    string GetFormat();
    string GetName();
    string GetObozn();
    //string GetPartNumber();
    string GetRazdelSP();
    EskdSpecificationType GetSpecificationType();
    void SetSpecificationType(EskdSpecificationType eskdSpecificationType);
    string GetPrimechPE3();
    string GetPrimechSP();
    string GetPrimechVP();
    string GetOKP();
    string GetDeliveryObozn();
    string GetManufacture();
    string GetCountry();
}
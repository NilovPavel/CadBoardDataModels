// File:    SpecificationDataCAD.cs
// Author:  nilov_pg
// Created: 9 августа 2019 г. 15:53:18
// Purpose: Definition of Class SpecificationDataCAD

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public class SpecificationDataCAD : IAssemblyCAD
{
    private IAssemblyCAD iAssembly;

    IHierarchyCAD IAssemblyCAD.GetIHierarchyCAD()
    {
        return default(IHierarchyCAD);
    }

    INotesCAD IAssemblyCAD.GetINotesCAD()
    {
        return this.iAssembly.GetINotesCAD();
    }

    IProjectPropertiesCAD IAssemblyCAD.GetIProjectPropertiesCAD()
    {
        return this.iAssembly.GetIProjectPropertiesCAD();
    }

    IVariantCAD IAssemblyCAD.GetIVariantCAD()
    {
        return this.iAssembly.GetIVariantCAD();
    }

    public SpecificationDataCAD(IAssemblyCAD iAssembly)
    {
        this.iAssembly = iAssembly;
    }
}
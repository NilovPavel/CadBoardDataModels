using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public class NotesCAD : IAssemblyCAD
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

    public NotesCAD(IAssemblyCAD iAssembly)
    {
        this.iAssembly = iAssembly;
    }
}

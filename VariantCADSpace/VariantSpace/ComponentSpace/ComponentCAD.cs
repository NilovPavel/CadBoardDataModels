// File:    ComponentCAD.cs
// Author:  nilov_pg
// Created: 20 декабря 2018 г. 10:10:08
// Purpose: Definition of Class ComponentCAD

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public class ComponentCAD
{
    private string uniqueID;
    private string configuration;
    private string logicalDesignator;
    private string physicalDesignator;
    private bool fitted;

    private IComponentCAD iComponentCAD;

    public DataESKD dataESKD;

    public string UniqueID
    {
        get
        {
            return uniqueID;
        }
        set
        {
            this.uniqueID = value;
        }
    }

    public string Configuration
    {
        get
        {
            return configuration;
        }
        set
        {
            this.configuration = value;
        }
    }

    public string LogicalDesignator
    {
        get
        {
            return logicalDesignator;
        }
        set
        {
            this.logicalDesignator = value;
        }
    }

    public string PhysicalDesignator
    {
        get
        {
            return physicalDesignator;
        }
        set
        {
            this.physicalDesignator = value;
        }
    }

    public bool Fitted
    {
        get
        {
            return fitted;
        }
        set
        {
            this.fitted = value;
        }
    }

    public ComponentCAD()
    { }

    public ComponentCAD(IComponentCAD iComponentCAD)
    {
        this.iComponentCAD = iComponentCAD;
        this.logicalDesignator = this.iComponentCAD.GetLogicalDesignator();
        this.physicalDesignator = this.iComponentCAD.GetPhysicalDesignator();
        this.uniqueID = this.iComponentCAD.GetUniqueID();
        this.fitted = this.iComponentCAD.GetFitted();
        this.configuration = this.iComponentCAD.GetConfiguration();
        this.dataESKD = new DataESKD(this.iComponentCAD.GetIComponentData());
    }

}
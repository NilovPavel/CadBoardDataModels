// File:    DataESKD.cs
// Author:  nilov_pg
// Created: 22 января 2019 г. 8:15:15
// Purpose: Definition of Class DataESKD

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public class DataESKD
{
    private string наименование;
    private string обозначение;
    private string разделСп;
    private EskdSpecificationType specificationFlag;
    private string формат;
    private int позиция;
    private string примечаниеПЭ3;
    private string примечаниеСП;
    private string примечаниеВП;
    private string окп;
    private string обозначениеНаПоставку;
    private string производитель;
    private string страна;


    private IDataESKD iDataESKD;

    public string Наименование
    {
        get
        {
            return наименование;
        }
        set
        {
            this.наименование = value;
        }
    }

    public string Обозначение
    {
        get
        {
            return обозначение;
        }
        set
        {
            this.обозначение = value;
        }
    }

    public string РазделСп
    {
        get
        {
            return разделСп;
        }
        set
        {
            this.разделСп = value;
        }
    }

    public EskdSpecificationType SpecificationFlag
    {
        get
        {
            return specificationFlag;
        }
        set
        {
            this.specificationFlag = value;
        }
    }

    public string Формат
    {
        get
        {
            return формат;
        }
        set
        {
            this.формат = value;
        }
    }

    public int Позиция
    {
        get
        {
            return позиция;
        }
        set
        {
            this.позиция = value;
        }
    }

    public string ПримечаниеПЭ3
    {
        get
        {
            return примечаниеПЭ3;
        }
        set
        {
            this.примечаниеПЭ3 = value;
        }
    }

    public string ПримечаниеСП
    {
        get
        {
            return примечаниеСП;
        }
        set
        {
            this.примечаниеСП = value;
        }
    }

    public string ПримечаниеВП
    {
        get
        {
            return примечаниеВП;
        }
        set
        {
            this.примечаниеВП = value;
        }
    }

    public string Окпд
    {
        get
        {
            return окп;
        }
        set
        {
            this.окп = value;
        }
    }

    public string ОбозначениеНаПоставку
    {
        get
        {
            return обозначениеНаПоставку;
        }
        set
        {
            this.обозначениеНаПоставку = value;
        }
    }

    public string Производитель
    {
        get
        {
            return производитель;
        }
        set
        {
            this.производитель = value;
        }
    }

    public string Страна
    {
        get
        {
            return страна;
        }
        set
        {
            this.страна = value;
        }
    }

    public DataESKD()
    {
    }

    public DataESKD(IDataESKD iDataESKD)
    {
        this.iDataESKD = iDataESKD;
        this.формат = this.iDataESKD.GetFormat();
        this.обозначение = this.iDataESKD.GetObozn();
        this.наименование = this.iDataESKD.GetName();
        this.разделСп = this.iDataESKD.GetRazdelSP();
        this.примечаниеПЭ3 = this.iDataESKD.GetPrimechPE3();
        this.примечаниеСП = this.iDataESKD.GetPrimechSP();
        this.примечаниеВП = this.iDataESKD.GetPrimechVP();
        this.окп = this.iDataESKD.GetOKP();
        this.обозначениеНаПоставку = this.iDataESKD.GetDeliveryObozn();
        this.производитель = this.iDataESKD.GetManufacture();
        this.страна = this.iDataESKD.GetCountry();
    }
}
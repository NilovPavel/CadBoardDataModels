// File:    Propertie.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 9:28:31
// Purpose: Definition of Class Propertie

using System;
using System.Xml.Serialization;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

public class Propertie
{
   private string name;
   private string value;
   
   [XmlElement(Order = 1)]
   public string Name
   {
      get
      {
         return name;
      }
      set
      {
         this.name = value;
      }
   }
   
   [XmlElement(Order = 2)]
   public string Value
   {
      get
      {
         return value;
      }
      set
      {
         this.value = value;
      }
   }
   
   public Propertie(string name, string value)
   {
      this.name = name;
      this.value = value;
   }
   
   public Propertie()
   {
   }

}
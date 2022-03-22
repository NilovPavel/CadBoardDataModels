// File:    Notes.cs
// Author:  nilov_pg
// Created: 22 октября 2018 г. 10:08:24
// Purpose: Definition of Class Notes

using System;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.LayoutRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.SpacingRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.ReadabilityRules", "*", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.OrderingRules", "*", Justification = "Reviewed.")]

[Serializable]
public class Notes
{
   private string razdelName;
   private string[] razdelNotesCollection;
   
   private INotesCAD iNotesCAD;
   
   public string RazdelName
   {
      get
      {
         return razdelName;
      }
      set
      {
         this.razdelName = value;
      }
   }
   
   public string[] RazdelNotesCollection
   {
      get
      {
         return razdelNotesCollection;
      }
      set
      {
         this.razdelNotesCollection = value;
      }
   }
   
   public Notes()
   {
   }
   
   public Notes(string razdelName, INotesCAD iNotesCAD)
   {
      this.razdelName = razdelName;
      this.iNotesCAD = iNotesCAD;
      this.razdelNotesCollection = this.iNotesCAD.ReadRazdelNotes(this.razdelName);
   }

}
// File:    ProjectProperties.cs
// Author:  nilov_pg
// Created: 24 октября 2018 г. 10:28:23
// Purpose: Definition of Class ProjectProperties

using System;
using System.Xml.Serialization;
using System.Linq;

[Serializable]
public class ProjectProperties
{
   private System.Collections.Generic.List<Propertie> propertie;
   
   /// <summary>
   /// Property for collection of Propertie
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Propertie> Propertie
   {
      get
      {
         if (propertie == null)
            propertie = new System.Collections.Generic.List<Propertie>();
         return propertie;
      }
      set
      {
         RemoveAllPropertie();
         if (value != null)
         {
            foreach (Propertie oPropertie in value)
               AddPropertie(oPropertie);
         }
      }
   }
   
   /// <summary>
   /// Add a new Propertie in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddPropertie(Propertie newPropertie)
   {
      if (newPropertie == null)
         return;
      if (this.propertie == null)
         this.propertie = new System.Collections.Generic.List<Propertie>();
      if (!this.propertie.Contains(newPropertie))
         this.propertie.Add(newPropertie);
   }
   
   /// <summary>
   /// Remove an existing Propertie from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemovePropertie(Propertie oldPropertie)
   {
      if (oldPropertie == null)
         return;
      if (this.propertie != null)
         if (this.propertie.Contains(oldPropertie))
            this.propertie.Remove(oldPropertie);
   }
   
   /// <summary>
   /// Remove all instances of Propertie from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllPropertie()
   {
      if (propertie != null)
         propertie.Clear();
   }
   private IProjectPropertiesCAD iProjectPropertiesCAD;
   
   public ProjectProperties(IProjectPropertiesCAD iProjectPropertiesCAD)
   {
      this.iProjectPropertiesCAD = iProjectPropertiesCAD;
           this.iProjectPropertiesCAD.ReadProperties();
           foreach (string propertie_name in this.iProjectPropertiesCAD.GetPropertieNames())
               this.AddPropertie(new Propertie(propertie_name, this.iProjectPropertiesCAD.GetParameterValue(propertie_name)));
   }
   
   public ProjectProperties()
   {
   }
   
   public string GetPropertyByName(string propertyName)
   {
      Propertie currentPropertie = this.propertie.Where(onePropertie => onePropertie.Name.Equals(propertyName)).FirstOrDefault();
      string currentPropertieValue = currentPropertie != null ? currentPropertie.Value : string.Empty;
      return currentPropertieValue;
   }

}
// File:    Variant.cs
// Author:  nilov_pg
// Created: 18 октября 2018 г. 14:42:27
// Purpose: Definition of Class Variant

using System;
using System.Xml.Serialization;

[Serializable]
public class Variant
{
   private string variantName;
   
   private IVariant iVariant;
   private System.Collections.Generic.List<ComponentCAD> componentCAD;
   
   /// <summary>
   /// Property for collection of ComponentCAD
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<ComponentCAD> ComponentCAD
   {
      get
      {
         if (componentCAD == null)
            componentCAD = new System.Collections.Generic.List<ComponentCAD>();
         return componentCAD;
      }
      set
      {
         RemoveAllComponentCAD();
         if (value != null)
         {
            foreach (ComponentCAD oComponentCAD in value)
               AddComponentCAD(oComponentCAD);
         }
      }
   }
   
   /// <summary>
   /// Add a new ComponentCAD in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddComponentCAD(ComponentCAD newComponentCAD)
   {
      if (newComponentCAD == null)
         return;
      if (this.componentCAD == null)
         this.componentCAD = new System.Collections.Generic.List<ComponentCAD>();
      if (!this.componentCAD.Contains(newComponentCAD))
         this.componentCAD.Add(newComponentCAD);
   }
   
   /// <summary>
   /// Remove an existing ComponentCAD from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveComponentCAD(ComponentCAD oldComponentCAD)
   {
      if (oldComponentCAD == null)
         return;
      if (this.componentCAD != null)
         if (this.componentCAD.Contains(oldComponentCAD))
            this.componentCAD.Remove(oldComponentCAD);
   }
   
   /// <summary>
   /// Remove all instances of ComponentCAD from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllComponentCAD()
   {
      if (componentCAD != null)
         componentCAD.Clear();
   }
   
   public string VariantName
   {
      get
      {
         return variantName;
      }
      set
      {
         this.variantName = value;
      }
   }
   
   public Variant()
   {}
   
   public Variant(IVariant iVariant)
   {
      this.iVariant = iVariant;
      this.VariantName = this.iVariant.GetVariantName();
      for (int i = 0; i < this.iVariant.GetCollection().Length; i++)
               this.AddComponentCAD(new ComponentCAD(this.iVariant.GetCollection()[i]));
   }

}
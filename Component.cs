// File:    Component.cs
// Author:  nilov_pg
// Created: 18 октября 2018 г. 9:07:23
// Purpose: Definition of Class Component

using System;

[Serializable]
public class Component
{
   private double x;
   private double y;
   private double z;
   private double[] transformMatrix;
   private double[] rotateMatrix;
   private double[] normalVector;
   private double angle;
   private double[] quaternion;
   
   public void Transform()
   {
      throw new NotImplementedException();
   }
   
   public void GetData()
   {
      throw new NotImplementedException();
   }
   
   public void GetGeometry()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.Generic.List<Coordinats> coordinats;
   
   /// <summary>
   /// Property for collection of Coordinats
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Coordinats> Coordinats
   {
      get
      {
         if (coordinats == null)
            coordinats = new System.Collections.Generic.List<Coordinats>();
         return coordinats;
      }
      set
      {
         RemoveAllCoordinats();
         if (value != null)
         {
            foreach (Coordinats oCoordinats in value)
               AddCoordinats(oCoordinats);
         }
      }
   }
   
   /// <summary>
   /// Add a new Coordinats in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCoordinats(Coordinats newCoordinats)
   {
      if (newCoordinats == null)
         return;
      if (this.coordinats == null)
         this.coordinats = new System.Collections.Generic.List<Coordinats>();
      if (!this.coordinats.Contains(newCoordinats))
         this.coordinats.Add(newCoordinats);
   }
   
   /// <summary>
   /// Remove an existing Coordinats from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCoordinats(Coordinats oldCoordinats)
   {
      if (oldCoordinats == null)
         return;
      if (this.coordinats != null)
         if (this.coordinats.Contains(oldCoordinats))
            this.coordinats.Remove(oldCoordinats);
   }
   
   /// <summary>
   /// Remove all instances of Coordinats from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCoordinats()
   {
      if (coordinats != null)
         coordinats.Clear();
   }

}
// File:    LayerStacker.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 11:39:37
// Purpose: Definition of Class LayerStacker

using System;

public abstract class LayerStacker
{
   private int isFlex;
   
   protected abstract void Initialization();
   
   protected abstract void GetLayersFromStack();
   
   public string name;
   public string id;
   
   public System.Collections.Generic.List<Layer> layer;
   
   /// <summary>
   /// Property for collection of Layer
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Layer> Layer
   {
      get
      {
         if (layer == null)
            layer = new System.Collections.Generic.List<Layer>();
         return layer;
      }
      set
      {
         RemoveAllLayer();
         if (value != null)
         {
            foreach (Layer oLayer in value)
               AddLayer(oLayer);
         }
      }
   }
   
   /// <summary>
   /// Add a new Layer in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddLayer(Layer newLayer)
   {
      if (newLayer == null)
         return;
      if (this.layer == null)
         this.layer = new System.Collections.Generic.List<Layer>();
      if (!this.layer.Contains(newLayer))
         this.layer.Add(newLayer);
   }
   
   /// <summary>
   /// Remove an existing Layer from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveLayer(Layer oldLayer)
   {
      if (oldLayer == null)
         return;
      if (this.layer != null)
         if (this.layer.Contains(oldLayer))
            this.layer.Remove(oldLayer);
   }
   
   /// <summary>
   /// Remove all instances of Layer from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllLayer()
   {
      if (layer != null)
         layer.Clear();
   }

}
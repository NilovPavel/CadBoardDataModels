// File:    BoardData.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 10:57:34
// Purpose: Definition of Class BoardData

using System;

public abstract class BoardData
{
   protected abstract void Initialization();
   
   protected abstract void GetLayerStacks();
   
   public System.Collections.Generic.List<LayerStack> layerStack;
   
   /// <summary>
   /// Property for collection of LayerStack
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<LayerStack> LayerStack
   {
      get
      {
         if (layerStack == null)
            layerStack = new System.Collections.Generic.List<LayerStack>();
         return layerStack;
      }
      set
      {
         RemoveAllLayerStack();
         if (value != null)
         {
            foreach (LayerStack oLayerStack in value)
               AddLayerStack(oLayerStack);
         }
      }
   }
   
   /// <summary>
   /// Add a new LayerStack in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddLayerStack(LayerStack newLayerStack)
   {
      if (newLayerStack == null)
         return;
      if (this.layerStack == null)
         this.layerStack = new System.Collections.Generic.List<LayerStack>();
      if (!this.layerStack.Contains(newLayerStack))
         this.layerStack.Add(newLayerStack);
   }
   
   /// <summary>
   /// Remove an existing LayerStack from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveLayerStack(LayerStack oldLayerStack)
   {
      if (oldLayerStack == null)
         return;
      if (this.layerStack != null)
         if (this.layerStack.Contains(oldLayerStack))
            this.layerStack.Remove(oldLayerStack);
   }
   
   /// <summary>
   /// Remove all instances of LayerStack from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllLayerStack()
   {
      if (layerStack != null)
         layerStack.Clear();
   }
   public IBoard iBoard;

}
// File:    Harness.cs
// Author:  Павел
// Created: 31 марта 2020 г. 10:48:34
// Purpose: Definition of Class Harness

using System;

public class Harness
{
   private IHarnessCAD iHarnessCAD;
   
   public System.Collections.Generic.List<Wire> wire;
   
   /// <summary>
   /// Property for collection of Wire
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Wire> Wire
   {
      get
      {
         if (wire == null)
            wire = new System.Collections.Generic.List<Wire>();
         return wire;
      }
      set
      {
         RemoveAllWire();
         if (value != null)
         {
            foreach (Wire oWire in value)
               AddWire(oWire);
         }
      }
   }
   
   /// <summary>
   /// Add a new Wire in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddWire(Wire newWire)
   {
      if (newWire == null)
         return;
      if (this.wire == null)
         this.wire = new System.Collections.Generic.List<Wire>();
      if (!this.wire.Contains(newWire))
         this.wire.Add(newWire);
   }
   
   /// <summary>
   /// Remove an existing Wire from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveWire(Wire oldWire)
   {
      if (oldWire == null)
         return;
      if (this.wire != null)
         if (this.wire.Contains(oldWire))
            this.wire.Remove(oldWire);
   }
   
   /// <summary>
   /// Remove all instances of Wire from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllWire()
   {
      if (wire != null)
         wire.Clear();
   }
   public System.Collections.Generic.List<Cable> cable;
   
   /// <summary>
   /// Property for collection of Cable
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Cable> Cable
   {
      get
      {
         if (cable == null)
            cable = new System.Collections.Generic.List<Cable>();
         return cable;
      }
      set
      {
         RemoveAllCable();
         if (value != null)
         {
            foreach (Cable oCable in value)
               AddCable(oCable);
         }
      }
   }
   
   /// <summary>
   /// Add a new Cable in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCable(Cable newCable)
   {
      if (newCable == null)
         return;
      if (this.cable == null)
         this.cable = new System.Collections.Generic.List<Cable>();
      if (!this.cable.Contains(newCable))
         this.cable.Add(newCable);
   }
   
   /// <summary>
   /// Remove an existing Cable from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCable(Cable oldCable)
   {
      if (oldCable == null)
         return;
      if (this.cable != null)
         if (this.cable.Contains(oldCable))
            this.cable.Remove(oldCable);
   }
   
   /// <summary>
   /// Remove all instances of Cable from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCable()
   {
      if (cable != null)
         cable.Clear();
   }
   
   public Harness()
   {}
   
   public Harness(IHarnessCAD iHarnessCAD)
   {
       this.iHarnessCAD = iHarnessCAD;
       if (this.iHarnessCAD == null)
         return;
       foreach (ICable iCable in this.iHarnessCAD.GetICables())
         this.AddCable(new Cable(iCable));
       foreach (IWire iWire in this.iHarnessCAD.GetIWires())
         this.AddWire(new Wire(iWire));
   }

}
// File:    AssemblyComponentID.cs
// Author:  nilov_pg
// Created: 11 декабря 2018 г. 12:56:15
// Purpose: Definition of Class AssemblyComponentID

using System;

public class AssemblyComponentID : ComponentID
{
   private string обозначение;
   private string наименование;
   
   private System.Collections.Generic.List<ElementaryComponentID> elementaryComponentID;
   
   /// <summary>
   /// Property for collection of ElementaryComponentID
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<ElementaryComponentID> ElementaryComponentID
   {
      get
      {
         if (elementaryComponentID == null)
            elementaryComponentID = new System.Collections.Generic.List<ElementaryComponentID>();
         return elementaryComponentID;
      }
      set
      {
         RemoveAllElementaryComponentID();
         if (value != null)
         {
            foreach (ElementaryComponentID oElementaryComponentID in value)
               AddElementaryComponentID(oElementaryComponentID);
         }
      }
   }
   
   /// <summary>
   /// Add a new ElementaryComponentID in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddElementaryComponentID(ElementaryComponentID newElementaryComponentID)
   {
      if (newElementaryComponentID == null)
         return;
      if (this.elementaryComponentID == null)
         this.elementaryComponentID = new System.Collections.Generic.List<ElementaryComponentID>();
      if (!this.elementaryComponentID.Contains(newElementaryComponentID))
         this.elementaryComponentID.Add(newElementaryComponentID);
   }
   
   /// <summary>
   /// Remove an existing ElementaryComponentID from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveElementaryComponentID(ElementaryComponentID oldElementaryComponentID)
   {
      if (oldElementaryComponentID == null)
         return;
      if (this.elementaryComponentID != null)
         if (this.elementaryComponentID.Contains(oldElementaryComponentID))
            this.elementaryComponentID.Remove(oldElementaryComponentID);
   }
   
   /// <summary>
   /// Remove all instances of ElementaryComponentID from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllElementaryComponentID()
   {
      if (elementaryComponentID != null)
         elementaryComponentID.Clear();
   }
   private System.Collections.Generic.List<AssemblyComponentID> assemblyComponentIDB;
   
   /// <summary>
   /// Property for collection of AssemblyComponentID
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<AssemblyComponentID> AssemblyComponentIDB
   {
      get
      {
         if (assemblyComponentIDB == null)
            assemblyComponentIDB = new System.Collections.Generic.List<AssemblyComponentID>();
         return assemblyComponentIDB;
      }
      set
      {
         RemoveAllAssemblyComponentIDB();
         if (value != null)
         {
            foreach (AssemblyComponentID oAssemblyComponentID in value)
               AddAssemblyComponentIDB(oAssemblyComponentID);
         }
      }
   }
   
   /// <summary>
   /// Add a new AssemblyComponentID in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddAssemblyComponentIDB(AssemblyComponentID newAssemblyComponentID)
   {
      if (newAssemblyComponentID == null)
         return;
      if (this.assemblyComponentIDB == null)
         this.assemblyComponentIDB = new System.Collections.Generic.List<AssemblyComponentID>();
      if (!this.assemblyComponentIDB.Contains(newAssemblyComponentID))
         this.assemblyComponentIDB.Add(newAssemblyComponentID);
   }
   
   /// <summary>
   /// Remove an existing AssemblyComponentID from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveAssemblyComponentIDB(AssemblyComponentID oldAssemblyComponentID)
   {
      if (oldAssemblyComponentID == null)
         return;
      if (this.assemblyComponentIDB != null)
         if (this.assemblyComponentIDB.Contains(oldAssemblyComponentID))
            this.assemblyComponentIDB.Remove(oldAssemblyComponentID);
   }
   
   /// <summary>
   /// Remove all instances of AssemblyComponentID from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllAssemblyComponentIDB()
   {
      if (assemblyComponentIDB != null)
         assemblyComponentIDB.Clear();
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

}
// File:    ComponentID.cs
// Author:  nilov_pg
// Created: 12 декабря 2018 г. 10:45:00
// Purpose: Definition of Class ComponentID

using System;
using System.Xml.Serialization;

public abstract class ComponentID
{
   private string uniqueID;
   private string designator;
   private string parentID;
   
   private IComponentID iComponentID;
   
   [XmlAttribute]
   public string UniqueID
   {
      get
      {
         return uniqueID;
      }
      set
      {
         this.uniqueID = value;
      }
   }
   
   [XmlAttribute]
   public string Designator
   {
      get
      {
         return designator;
      }
      set
      {
         this.designator = value;
      }
   }
   
   [XmlIgnore]
   public string ParentID
   {
      get
      {
         return parentID;
      }
      set
      {
         this.parentID = value;
      }
   }
   
   public ComponentID()
   {
   }
   
   public ComponentID(IComponentID iComponentID)
   {
      this.iComponentID = iComponentID;
      this.uniqueID = this.iComponentID.GetUniqueID();
      this.designator = this.iComponentID.GetDesignator();
      this.parentID = this.iComponentID.GetParentID();
   }

}
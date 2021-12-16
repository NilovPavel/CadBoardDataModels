// File:    ComponentIdentificator.cs
// Author:  nilov_pg
// Created: 12 декабря 2018 г. 10:45:00
// Purpose: Definition of Class ComponentIdentificator

using System;

public abstract class ComponentIdentificator
{
   private string uniqueID;
   private string designator;
   private string parentID;
   
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

}
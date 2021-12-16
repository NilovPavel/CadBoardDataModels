// File:    ComponentCAD.cs
// Author:  nilov_pg
// Created: 20 декабря 2018 г. 10:10:08
// Purpose: Definition of Class ComponentCAD

using System;

public class ComponentCAD
{
   private string uniqueID;
   private string configuration;
   private string designator;
   /// это временное поле от которого нужно избавиться в самое кратчайшее время, когда оно не станет нужно Жене
   private string logicalDesignator;
   private bool fitted;
   
   private IComponentCAD iComponentCAD;
   
   public Coordinats coordinats;
   public DataESKD dataESKD;
   
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
   
   public string Configuration
   {
      get
      {
         return configuration;
      }
      set
      {
         this.configuration = value;
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
   
   public string LogicalDesignator
   {
      get
      {
         return logicalDesignator;
      }
      set
      {
         this.logicalDesignator = value;
      }
   }
   
   public bool Fitted
   {
      get
      {
         return fitted;
      }
      set
      {
         this.fitted = value;
      }
   }
   
   public ComponentCAD()
   {}
   
   public ComponentCAD(IComponentCAD iComponentCAD)
   {
           this.iComponentCAD = iComponentCAD;
           this.designator = this.iComponentCAD.GetDesignator();
           this.logicalDesignator = this.iComponentCAD.GetLogicalDesignator();
           this.uniqueID = this.iComponentCAD.GetUniqueID();
           this.fitted = this.iComponentCAD.GetFitted();
           this.configuration = this.iComponentCAD.GetConfiguration();
           this.coordinats = new Coordinats(this.iComponentCAD.GetICoordinats());
           this.dataESKD = new DataESKD(this.iComponentCAD.GetIComponentData());
   }

}
// File:    ComponentData.cs
// Author:  nilov_pg
// Created: 22 января 2019 г. 8:15:15
// Purpose: Definition of Class ComponentData

using System;

public class ComponentData
{
   private string наименование;
   private string обозначение;
   private string разделСп;
   private string partNumber;
   private Propertie[] properties;
   
   private IComponentData iComponentData;
   
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
   
   public string РазделСп
   {
      get
      {
         return разделСп;
      }
      set
      {
         this.разделСп = value;
      }
   }
   
   public string PartNumber
   {
      get
      {
         return partNumber;
      }
      set
      {
         this.partNumber = value;
      }
   }
   
   public Propertie[] Properties
   {
      get
      {
         return properties;
      }
      set
      {
         this.properties = value;
      }
   }
   
   public ComponentData()
   {
   }
   
   public ComponentData(IComponentData iComponentData)
   {
            this.iComponentData = iComponentData;
            this.наименование = this.iComponentData.GetName();
            this.обозначение = this.iComponentData.GetObozn();
            this.разделСп = this.iComponentData.GetRazdelSP();
            this.partNumber = this.iComponentData.GetPartNumber();
   }

}
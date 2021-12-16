// File:    DataESKD.cs
// Author:  nilov_pg
// Created: 22 января 2019 г. 8:15:15
// Purpose: Definition of Class DataESKD

using System;

public class DataESKD
{
   private string наименование;
   private string обозначение;
   private string разделСп;
   private string partNumber;
   private Propertie[] properties;
   private EskdSpecificationType specificationFlag;
   private string формат;
   private int позиция;
   
   private IDataESKD iDataESKD;
   
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
   
   public EskdSpecificationType SpecificationFlag
   {
      get
      {
         return specificationFlag;
      }
      set
      {
         this.specificationFlag = value;
      }
   }
   
   public string Формат
   {
      get
      {
         return формат;
      }
      set
      {
         this.формат = value;
      }
   }
   
   public int Позиция
   {
      get
      {
         return позиция;
      }
      set
      {
         this.позиция = value;
      }
   }
   
   public DataESKD()
   {
   }
   
   public DataESKD(IDataESKD iDataESKD)
   {
            this.iDataESKD = iDataESKD;
            this.наименование = this.iDataESKD.GetName();
            this.обозначение = this.iDataESKD.GetObozn();
            this.разделСп = this.iDataESKD.GetRazdelSP();
            this.partNumber = this.iDataESKD.GetPartNumber();
   }

}
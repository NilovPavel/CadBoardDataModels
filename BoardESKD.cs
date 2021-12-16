// File:    BoardESKD.cs
// Author:  nilov_pg
// Created: 22 июля 2019 г. 10:16:18
// Purpose: Definition of Class BoardESKD

using System;

public class BoardESKD
{
   private string формат;
   private string обозначение;
   private string наименование;
   private string разделСп;
   private string примечание;
   
   private IDataESKD iDataESKD;
   
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
   
   public string Примечание
   {
      get
      {
         return примечание;
      }
      set
      {
         this.примечание = value;
      }
   }
   
   public BoardESKD(IDataESKD iDataESKD)
   {
      this.iDataESKD = iDataESKD;
      if (this.iDataESKD == null)
         return;
      this.формат = this.iDataESKD.GetFormat();
      this.обозначение = this.iDataESKD.GetObozn();
      this.наименование = this.iDataESKD.GetName();
      this.разделСп = this.iDataESKD.GetRazdelSP();
      this.примечание = this.iDataESKD.GetPrimechanie();
   }
   
   public BoardESKD()
   {
   }

}
// File:    Data.cs
// Author:  pavel
// Created: 16 декабря 2021 г. 22:30:25
// Purpose: Definition of Class Data

using System;

public class Data
{
   private string partNumber;
   
   private IData iData;
   
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
   
   public Data()
   {
      throw new NotImplementedException();
   }
   
   public Data(IData iData)
   {
      this.iData = iData;
      this.partNumber = this.iData.GetPartNumber();
   }

}
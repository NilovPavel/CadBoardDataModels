// File:    Wire.cs
// Author:  Павел
// Created: 31 марта 2020 г. 10:48:34
// Purpose: Definition of Class Wire

using System;

public class Wire
{
   private string sourceConnectorDesignator;
   private string sourceConnectorPin;
   private string destinationConnectorDesignator;
   private string destinationConnectorPin;
   private double length;
   private string material;
   private double diameter;
   private IWire iWire;
   
   public string SourceConnectorDesignator
   {
      get
      {
         return sourceConnectorDesignator;
      }
      set
      {
         this.sourceConnectorDesignator = value;
      }
   }
   
   public string SourceConnectorPin
   {
      get
      {
         return sourceConnectorPin;
      }
      set
      {
         this.sourceConnectorPin = value;
      }
   }
   
   public string DestinationConnectorDesignator
   {
      get
      {
         return destinationConnectorDesignator;
      }
      set
      {
         this.destinationConnectorDesignator = value;
      }
   }
   
   public string DestinationConnectorPin
   {
      get
      {
         return destinationConnectorPin;
      }
      set
      {
         this.destinationConnectorPin = value;
      }
   }
   
   public double Length
   {
      get
      {
         return length;
      }
      set
      {
         this.length = value;
      }
   }
   
   public string Material
   {
      get
      {
         return material;
      }
      set
      {
         this.material = value;
      }
   }
   
   public double Diameter
   {
      get
      {
         return diameter;
      }
      set
      {
         this.diameter = value;
      }
   }
   
   public Wire(IWire iWire)
   {
      this.iWire = iWire;
      this.sourceConnectorDesignator = this.iWire.GetSourceConnectorDesignator();
      this.sourceConnectorPin = this.iWire.GetSourceConnectorPin();
      this.destinationConnectorDesignator = this.iWire.GetDestinationConnectorDesignator();
      this.destinationConnectorPin = this.iWire.GetDestinationConnectorPin();
      this.length = this.iWire.GetLength();
      this.diameter = this.iWire.GetDiameter();
      this.material = this.iWire.GetMaterial();
   }
   
   public Wire()
   {}

}
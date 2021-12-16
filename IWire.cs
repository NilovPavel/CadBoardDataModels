// File:    IWire.cs
// Author:  Павел
// Created: 31 марта 2020 г. 10:48:34
// Purpose: Definition of Interface IWire

using System;

public interface IWire : INet
{
   string GetSourceConnectorDesignator();
   
   string GetSourceConnectorPin();
   
   string GetDestinationConnectorDesignator();
   
   string GetDestinationConnectorPin();

}
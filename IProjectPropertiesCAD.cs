// File:    IProjectPropertiesCAD.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 12:08:51
// Purpose: Definition of Interface IProjectPropertiesCAD

using System;

public interface IProjectPropertiesCAD
{
   void ReadProperties();
   
   string GetParameterValue(string parameterName);
   
   void WriteProperties();
   
   void WriteValue(string parameterName, string parameterValue);
   
   string[] GetPropertieNames();

}
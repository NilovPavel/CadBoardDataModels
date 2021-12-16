// File:    IComponentID.cs
// Author:  nilov_pg
// Created: 11 декабря 2018 г. 16:18:59
// Purpose: Definition of Interface IComponentID

using System;

public interface IComponentID
{
   string GetUniqueID();
   
   string GetParentID();
   
   string GetDesignator();

}
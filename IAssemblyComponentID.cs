// File:    IAssemblyComponentID.cs
// Author:  nilov_pg
// Created: 11 декабря 2018 г. 16:20:51
// Purpose: Definition of Interface IAssemblyComponentID

using System;

public interface IAssemblyComponentID
{
   string GetUniqueID();
   
   string GetParentID();
   
   string GetDesignator();
   
   IElementaryComponentID[] GetChildren();

}
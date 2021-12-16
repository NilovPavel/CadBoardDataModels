// File:    IElementaryComponentID.cs
// Author:  nilov_pg
// Created: 11 декабря 2018 г. 16:18:59
// Purpose: Definition of Interface IElementaryComponentID

using System;

public interface IElementaryComponentID
{
   string GetUniqueID();
   
   string GetParentID();
   
   string GetDesignator();

}
// File:    IAssemblyBuilder.cs
// Author:  nilov_pg
// Created: 30 января 2019 г. 14:02:30
// Purpose: Definition of Class IAssemblyBuilder

using System;

public abstract class IAssemblyBuilder
{
   private Assembly assembly;
   
   public IBoardBuilder iBoardBuilder;
   public IProjectPropertiesBuilder iProjectPropertiesBuilder;
   
   public IAssemblyBuilder(Assembly assembly)
   {
      this.assembly = assembly;
   }

}
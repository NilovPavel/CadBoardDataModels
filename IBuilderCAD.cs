// File:    IBuilderCAD.cs
// Author:  nilov_pg
// Created: 30 января 2019 г. 14:02:30
// Purpose: Definition of Class IBuilderCAD

using System;
using System.IO;
using System.Xml.Serialization;

public abstract class IBuilderCAD
{
   private void ReadAssembly()
   {
         XmlSerializer formatter = new XmlSerializer(typeof(Assembly));
   
         using (FileStream fs = new FileStream(this.pathXml, FileMode.OpenOrCreate))
         { this.assembly = (Assembly)formatter.Deserialize(fs); }
   }
   
   protected string pathXml;
   protected Assembly assembly;
   
   protected abstract IAssemblyBuilder InitializeAssemblyBuilderCAD();
   
   public IAssemblyBuilder iAssemblyBuilder;
   
   public IBuilderCAD(string pathXml)
   {
      this.pathXml = pathXml;
      this.ReadAssembly();
      this.iAssemblyBuilder = this.InitializeAssemblyBuilderCAD();
   }

}
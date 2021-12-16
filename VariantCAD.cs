// File:    VariantCAD.cs
// Author:  nilov_pg
// Created: 20 декабря 2018 г. 10:36:44
// Purpose: Definition of Class VariantCAD

using System;

public class VariantCAD
{
   private IVariantCAD iVariantCAD;
   
   public Variant[] variant;
   
   public VariantCAD()
   {}
   
   public VariantCAD(IVariantCAD iVariantCAD)
   {
      this.iVariantCAD = iVariantCAD;
      this.iVariantCAD = iVariantCAD;
      this.variant = new Variant[this.iVariantCAD.GetIVariants().Length];
      for (int i = 0; i < this.variant.Length; i++)
         this.variant[i] = new Variant(this.iVariantCAD.GetIVariants()[i]);
   }

}
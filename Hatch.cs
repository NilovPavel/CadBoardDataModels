// File:    Hatch.cs
// Author:  Павел
// Created: 29 марта 2020 г. 22:03:37
// Purpose: Definition of Class Hatch

using System;

public class Hatch
{
   private IHatch iHatch;
   
   public TypeHatch typeHatch;
   public double stepHatch;
   public double widthHatch;
   
   public Hatch()
   {
   }
   
   public Hatch(IHatch iHatch)
   {
      this.iHatch = iHatch;
   }

}
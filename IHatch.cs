// File:    IHatch.cs
// Author:  Павел
// Created: 8 апреля 2020 г. 19:52:50
// Purpose: Definition of Interface IHatch

using System;

public interface IHatch
{
   TypeHatch GetTypeHatch();
   
   double GetStepHatch();
   
   double GetWidthHatch();

}
// File:    IText.cs
// Author:  Павел
// Created: 8 апреля 2020 г. 19:27:48
// Purpose: Definition of Interface IText

using System;

public interface IText
{
   string GetValue();
   
   double GetX();
   
   double GetY();
   
   double GetAngle();
   
   double GetSize();
   
   string GetFontName();
   
   TypeJust GetJustification();
   
   double GetWidth();
   
   double GetHeight();

}
// File:    IPaint.cs
// Author:  Павел
// Created: 8 апреля 2020 г. 19:27:34
// Purpose: Definition of Interface IPaint

using System;

public interface IPaint
{
   IText[] GetTexts();
   
   IPolygon[] GetPolygons();
   
   ITracks[] GetTracks();
   
   IPad[] GetPads();

}
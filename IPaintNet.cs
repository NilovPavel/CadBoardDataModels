// File:    IPaintNet.cs
// Author:  Павел
// Created: 8 апреля 2020 г. 19:29:52
// Purpose: Definition of Interface IPaintNet

using System;

public interface IPaintNet
{
   double GetWidth();
   
   IContour GetIContour();

}
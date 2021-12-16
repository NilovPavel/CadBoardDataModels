// File:    IComponentCAD.cs
// Author:  nilov_pg
// Created: 20 декабря 2018 г. 10:24:38
// Purpose: Definition of Interface IComponentCAD

using System;

public interface IComponentCAD
{
   string GetUniqueID();
   
   string GetDesignator();
   
   /// Это временный метод, от которого нужно будет избавиться как можно скорее, когда он не станет нужен Жене для анализа
   string GetLogicalDesignator();
   
   string GetConfiguration();
   
   bool GetFitted();
   
   void SetFitted(bool isFitted);
   
   ICoordinats GetICoordinats();
   
   IDataESKD GetIComponentData();
   
   IComponentCAD Clone();

}
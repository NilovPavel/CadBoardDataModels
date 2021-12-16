// File:    BoardRegion.cs
// Author:  nilov_pg
// Created: 12 сентября 2018 г. 15:01:23
// Purpose: Definition of Class BoardRegion

using System;

public class BoardRegion
{
   public System.Collections.Generic.List<Line> line;
   
   /// <summary>
   /// Property for collection of Line
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Line> Line
   {
      get
      {
         if (line == null)
            line = new System.Collections.Generic.List<Line>();
         return line;
      }
      set
      {
         RemoveAllLine();
         if (value != null)
         {
            foreach (Line oLine in value)
               AddLine(oLine);
         }
      }
   }
   
   /// <summary>
   /// Add a new Line in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddLine(Line newLine)
   {
      if (newLine == null)
         return;
      if (this.line == null)
         this.line = new System.Collections.Generic.List<Line>();
      if (!this.line.Contains(newLine))
         this.line.Add(newLine);
   }
   
   /// <summary>
   /// Remove an existing Line from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveLine(Line oldLine)
   {
      if (oldLine == null)
         return;
      if (this.line != null)
         if (this.line.Contains(oldLine))
            this.line.Remove(oldLine);
   }
   
   /// <summary>
   /// Remove all instances of Line from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllLine()
   {
      if (line != null)
         line.Clear();
   }
   public System.Collections.Generic.List<Outline> outline;
   
   /// <summary>
   /// Property for collection of Outline
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Outline> Outline
   {
      get
      {
         if (outline == null)
            outline = new System.Collections.Generic.List<Outline>();
         return outline;
      }
      set
      {
         RemoveAllOutline();
         if (value != null)
         {
            foreach (Outline oOutline in value)
               AddOutline(oOutline);
         }
      }
   }
   
   /// <summary>
   /// Add a new Outline in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddOutline(Outline newOutline)
   {
      if (newOutline == null)
         return;
      if (this.outline == null)
         this.outline = new System.Collections.Generic.List<Outline>();
      if (!this.outline.Contains(newOutline))
         this.outline.Add(newOutline);
   }
   
   /// <summary>
   /// Remove an existing Outline from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveOutline(Outline oldOutline)
   {
      if (oldOutline == null)
         return;
      if (this.outline != null)
         if (this.outline.Contains(oldOutline))
            this.outline.Remove(oldOutline);
   }
   
   /// <summary>
   /// Remove all instances of Outline from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllOutline()
   {
      if (outline != null)
         outline.Clear();
   }

}
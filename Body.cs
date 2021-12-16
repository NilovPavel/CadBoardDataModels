// File:    Body.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 9:01:39
// Purpose: Definition of Class Body

using System;

[Serializable]
public class Body
{
   private IBody iBody;
   private IContour iContour;
   private System.Collections.Generic.List<BendingLine> bendingLine;
   
   /// <summary>
   /// Property for collection of BendingLine
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<BendingLine> BendingLine
   {
      get
      {
         if (bendingLine == null)
            bendingLine = new System.Collections.Generic.List<BendingLine>();
         return bendingLine;
      }
      set
      {
         RemoveAllBendingLine();
         if (value != null)
         {
            foreach (BendingLine oBendingLine in value)
               AddBendingLine(oBendingLine);
         }
      }
   }
   
   /// <summary>
   /// Add a new BendingLine in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddBendingLine(BendingLine newBendingLine)
   {
      if (newBendingLine == null)
         return;
      if (this.bendingLine == null)
         this.bendingLine = new System.Collections.Generic.List<BendingLine>();
      if (!this.bendingLine.Contains(newBendingLine))
         this.bendingLine.Add(newBendingLine);
   }
   
   /// <summary>
   /// Remove an existing BendingLine from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveBendingLine(BendingLine oldBendingLine)
   {
      if (oldBendingLine == null)
         return;
      if (this.bendingLine != null)
         if (this.bendingLine.Contains(oldBendingLine))
            this.bendingLine.Remove(oldBendingLine);
   }
   
   /// <summary>
   /// Remove all instances of BendingLine from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllBendingLine()
   {
      if (bendingLine != null)
         bendingLine.Clear();
   }
   
   public bool isFlex;
   public double totalHeight;
   public double originHeight;
   
   public Contour contour;
   
   public Body()
   {
   }
   
   public Body(IBody iBody)
   {
         this.iBody = iBody;
         this.isFlex = this.iBody.GetIsFlex();
         this.totalHeight = this.iBody.GetTotalHeight();
         this.originHeight = this.iBody.GetHeightFirstLayer();
         this.iContour = this.iBody.GetIContour();
         this.contour = new Contour(this.iContour);
         foreach (IBendingLine iBendingLine in this.iBody.GetBendingLines())
               this.AddBendingLine(new BendingLine(iBendingLine));
   }

}
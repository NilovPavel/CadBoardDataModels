// File:    Board.cs
// Author:  nilov_pg
// Created: 14 сентября 2018 г. 14:20:34
// Purpose: Definition of Class Board

using System;

[Serializable]
public class Board
{
   private Point originalPoint;
   
   private System.Collections.Generic.List<Body> body;
   
   /// <summary>
   /// Property for collection of Body
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Body> Body
   {
      get
      {
         if (body == null)
            body = new System.Collections.Generic.List<Body>();
         return body;
      }
      set
      {
         RemoveAllBody();
         if (value != null)
         {
            foreach (Body oBody in value)
               AddBody(oBody);
         }
      }
   }
   
   /// <summary>
   /// Add a new Body in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddBody(Body newBody)
   {
      if (newBody == null)
         return;
      if (this.body == null)
         this.body = new System.Collections.Generic.List<Body>();
      if (!this.body.Contains(newBody))
         this.body.Add(newBody);
   }
   
   /// <summary>
   /// Remove an existing Body from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveBody(Body oldBody)
   {
      if (oldBody == null)
         return;
      if (this.body != null)
         if (this.body.Contains(oldBody))
            this.body.Remove(oldBody);
   }
   
   /// <summary>
   /// Remove all instances of Body from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllBody()
   {
      if (body != null)
         body.Clear();
   }
   private IBoardCAD iBoardCAD;
   private System.Collections.Generic.List<CutOut> cutOut;
   
   /// <summary>
   /// Property for collection of CutOut
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<CutOut> CutOut
   {
      get
      {
         if (cutOut == null)
            cutOut = new System.Collections.Generic.List<CutOut>();
         return cutOut;
      }
      set
      {
         RemoveAllCutOut();
         if (value != null)
         {
            foreach (CutOut oCutOut in value)
               AddCutOut(oCutOut);
         }
      }
   }
   
   /// <summary>
   /// Add a new CutOut in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCutOut(CutOut newCutOut)
   {
      if (newCutOut == null)
         return;
      if (this.cutOut == null)
         this.cutOut = new System.Collections.Generic.List<CutOut>();
      if (!this.cutOut.Contains(newCutOut))
         this.cutOut.Add(newCutOut);
   }
   
   /// <summary>
   /// Remove an existing CutOut from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCutOut(CutOut oldCutOut)
   {
      if (oldCutOut == null)
         return;
      if (this.cutOut != null)
         if (this.cutOut.Contains(oldCutOut))
            this.cutOut.Remove(oldCutOut);
   }
   
   /// <summary>
   /// Remove all instances of CutOut from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCutOut()
   {
      if (cutOut != null)
         cutOut.Clear();
   }
   private System.Collections.Generic.List<Via> via;
   
   /// <summary>
   /// Property for collection of Via
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Via> Via
   {
      get
      {
         if (via == null)
            via = new System.Collections.Generic.List<Via>();
         return via;
      }
      set
      {
         RemoveAllVia();
         if (value != null)
         {
            foreach (Via oVia in value)
               AddVia(oVia);
         }
      }
   }
   
   /// <summary>
   /// Add a new Via in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddVia(Via newVia)
   {
      if (newVia == null)
         return;
      if (this.via == null)
         this.via = new System.Collections.Generic.List<Via>();
      if (!this.via.Contains(newVia))
         this.via.Add(newVia);
   }
   
   /// <summary>
   /// Remove an existing Via from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveVia(Via oldVia)
   {
      if (oldVia == null)
         return;
      if (this.via != null)
         if (this.via.Contains(oldVia))
            this.via.Remove(oldVia);
   }
   
   /// <summary>
   /// Remove all instances of Via from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllVia()
   {
      if (via != null)
         via.Clear();
   }
   private System.Collections.Generic.List<HolePad> holePad;
   
   /// <summary>
   /// Property for collection of HolePad
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<HolePad> HolePad
   {
      get
      {
         if (holePad == null)
            holePad = new System.Collections.Generic.List<HolePad>();
         return holePad;
      }
      set
      {
         RemoveAllHolePad();
         if (value != null)
         {
            foreach (HolePad oHolePad in value)
               AddHolePad(oHolePad);
         }
      }
   }
   
   /// <summary>
   /// Add a new HolePad in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddHolePad(HolePad newHolePad)
   {
      if (newHolePad == null)
         return;
      if (this.holePad == null)
         this.holePad = new System.Collections.Generic.List<HolePad>();
      if (!this.holePad.Contains(newHolePad))
         this.holePad.Add(newHolePad);
   }
   
   /// <summary>
   /// Remove an existing HolePad from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveHolePad(HolePad oldHolePad)
   {
      if (oldHolePad == null)
         return;
      if (this.holePad != null)
         if (this.holePad.Contains(oldHolePad))
            this.holePad.Remove(oldHolePad);
   }
   
   /// <summary>
   /// Remove all instances of HolePad from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllHolePad()
   {
      if (holePad != null)
         holePad.Clear();
   }
   private System.Collections.Generic.List<Layer> layer;
   
   /// <summary>
   /// Property for collection of Layer
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Layer> Layer
   {
      get
      {
         if (layer == null)
            layer = new System.Collections.Generic.List<Layer>();
         return layer;
      }
      set
      {
         RemoveAllLayer();
         if (value != null)
         {
            foreach (Layer oLayer in value)
               AddLayer(oLayer);
         }
      }
   }
   
   /// <summary>
   /// Add a new Layer in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddLayer(Layer newLayer)
   {
      if (newLayer == null)
         return;
      if (this.layer == null)
         this.layer = new System.Collections.Generic.List<Layer>();
      if (!this.layer.Contains(newLayer))
         this.layer.Add(newLayer);
   }
   
   /// <summary>
   /// Remove an existing Layer from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveLayer(Layer oldLayer)
   {
      if (oldLayer == null)
         return;
      if (this.layer != null)
         if (this.layer.Contains(oldLayer))
            this.layer.Remove(oldLayer);
   }
   
   /// <summary>
   /// Remove all instances of Layer from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllLayer()
   {
      if (layer != null)
         layer.Clear();
   }
   
   public Point OriginalPoint
   {
      get
      {
         return originalPoint;
      }
      set
      {
         this.originalPoint = value;
      }
   }
   
   public Board()
   {
   }
   
   public Board(IBoardCAD iBoardCAD)
   {
      this.iBoardCAD = iBoardCAD;
         if (this.iBoardCAD == null) return;
         this.originalPoint = this.iBoardCAD.GetOrigin();
              foreach (IBody one_body in this.iBoardCAD.GetBodies())
                  this.AddBody(new Body(one_body));
              foreach (ICutOut one_cutout in this.iBoardCAD.GetCutouts())
                     this.AddCutOut(new CutOut(one_cutout));
              foreach (IVia one_via in this.iBoardCAD.GetVias())
                  this.AddVia(new Via(one_via));
              foreach (IHolePad one_holePad in this.iBoardCAD.GetHolePads())
                  this.AddHolePad(new HolePad(one_holePad));
              foreach (ILayer one_Layer in this.iBoardCAD.GetLayers())
                  this.AddLayer(new Layer(one_Layer));
   }

}
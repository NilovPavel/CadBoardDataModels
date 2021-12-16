// File:    Coordinats.cs
// Author:  nilov_pg
// Created: 18 октября 2018 г. 9:07:23
// Purpose: Definition of Class Coordinats

using System;

[Serializable]
public class Coordinats
{
   private double x;
   private double y;
   private double z;
   private double[] transformMatrix;
   private double angle;
   private double[] quaternion;
   
   private ICoordinats iCoordinats;
   
   public double X
   {
      get
      {
         return x;
      }
      set
      {
         this.x = value;
      }
   }
   
   public double Y
   {
      get
      {
         return y;
      }
      set
      {
         this.y = value;
      }
   }
   
   public double Z
   {
      get
      {
         return z;
      }
      set
      {
         this.z = value;
      }
   }
   
   public double[] Quaternion
   {
      get
      {
         return quaternion;
      }
      set
      {
         this.quaternion = value;
      }
   }
   
   public double Angle
   {
      get
      {
         return angle;
      }
      set
      {
         this.angle = value;
      }
   }
   
   public void Transform()
   {
      throw new NotImplementedException();
   }
   
   public void GetData()
   {
      throw new NotImplementedException();
   }
   
   public void GetGeometry()
   {
      throw new NotImplementedException();
   }
   
   public Coordinats()
   {}
   
   public Coordinats(ICoordinats iCoordinats)
   {
              this.iCoordinats = iCoordinats;
              this.x = this.iCoordinats.GetX();
              this.y = this.iCoordinats.GetY();
              this.z = this.iCoordinats.GetZ();
              this.angle = this.iCoordinats.GetAngle();
              this.quaternion = this.iCoordinats.GetQuaternion();
   }

}
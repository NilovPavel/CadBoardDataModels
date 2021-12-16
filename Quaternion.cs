// File:    Quaternion.cs
// Author:  nilov_pg
// Created: 12 марта 2019 г. 11:25:07
// Purpose: Definition of Class Quaternion

using System;

public class Quaternion
{
   private double[] quaternionArray;
   
   public double[] QuaternionArray
   {
      get
      {
         return quaternionArray;
      }
      set
      {
         this.quaternionArray = value;
      }
   }
   
   public Quaternion Multiplication(Quaternion quaternion)
   {
              double aw = quaternion.QuaternionArray[0], ax = quaternion.QuaternionArray[1], ay = quaternion.QuaternionArray[2], az = quaternion.QuaternionArray[3];
              double bw = this.QuaternionArray[0], bx = this.QuaternionArray[1], by = this.QuaternionArray[2], bz = this.QuaternionArray[3];
              double cw, cx, cy, cz;
   
              cw = aw * bw - ax * bx - ay * by - az * bz;
              cx = aw * bx + ax * bw + ay * bz - az * by;
              cy = aw * by - ax * bz + ay * bw + az * bx;
              cz = aw * bz + ax * by - ay * bx + az * bw;
      
              return new Quaternion(new double[] { cw, cx, cy, cz });
   }
   
   public double[] GetRotationMatrix()
   {
           double[] rotationMatrix = new double[9];
           double w = QuaternionArray[0], x = QuaternionArray[1], y = QuaternionArray[2], z = QuaternionArray[3];
   
           /*Классическая матрица поворота*/
           rotationMatrix[0] = 1 - 2 * y * y - 2 * z * z; rotationMatrix[1] = 2 * x * y - 2 * z * w; rotationMatrix[2] = 2 * x * z + 2 * y * w;
      
           rotationMatrix[3] = 2 * x * y + 2 * z * w; rotationMatrix[4] = 1 - 2 * x * x - 2 * z * z; rotationMatrix[5] = 2 * y * z - 2 * x * w;
      
           rotationMatrix[6] = 2 * x * z - 2 * y * w; rotationMatrix[7] = 2 * y * z + 2 * x * w; rotationMatrix[8] = 1 - 2 * x * x - 2 * y * y;
   
           return rotationMatrix;
   }

    /*public double[] GetKompasRotationMatrix()
    {

    }*/
   
   public Quaternion(double[] quaternionArray)
   {
      this.QuaternionArray = quaternionArray;
   }

}
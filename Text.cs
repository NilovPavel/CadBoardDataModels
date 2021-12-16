// File:    Text.cs
// Author:  Павел
// Created: 9 апреля 2020 г. 22:38:57
// Purpose: Definition of Class Text

using System;

public class Text
{
   private TypeJust justification;
   
   private IText iText;
   
   public string value;
   public double x;
   public double y;
   public double angle;
   public double size;
   public string fontName;
   public double height;
   public double width;
   
   public Text()
   {
   }
   
   public Text(IText iText)
   {
      this.iText = iText;
      this.value = this.iText.GetValue();
      this.x = this.iText.GetX();
      this.y = this.iText.GetY();
      this.angle = this.iText.GetAngle();
      this.size = this.iText.GetSize();
      this.fontName = this.iText.GetFontName();
   }

}
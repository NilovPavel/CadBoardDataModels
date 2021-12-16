// File:    INotesCAD.cs
// Author:  nilov_pg
// Created: 29 октября 2018 г. 12:09:29
// Purpose: Definition of Interface INotesCAD

using System;

public interface INotesCAD
{
   string[] ReadRazdelNotes(string razdelName);
   
   string[] GetRazdelNames();
   
   void WriteNotes(Notes notes);

}
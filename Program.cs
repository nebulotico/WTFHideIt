using System.IO;

string filePath = Console.ReadLine();
File.SetAttributes(filePath, FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly);
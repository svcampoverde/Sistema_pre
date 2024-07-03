using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;
using Datos.Models;
using System.Reflection;
using System;
using System.Diagnostics;

public static class ExcelLoader
{
    public static List<Provincia> LoadProvinciasFromExcel(string filePath)
    {
        var provincias = new List<Provincia>();
        string baseDirectory = Directory.GetCurrentDirectory();
        string excelFilePath = Path.Combine(baseDirectory, filePath);

        if (!File.Exists(excelFilePath))
        {
            throw new FileNotFoundException($"El archivo Excel no se encuentra en la ruta especificada: {excelFilePath}");
        }

        using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
        {
            var sheet = package.Workbook.Worksheets["Provincias"];
            if (sheet == null)
            {
                throw new InvalidOperationException("La hoja 'Provincias' no se encuentra en el archivo Excel.");
            }

            int id = 0; // Usar IDs negativos para evitar colisiones
            for (int row = 2; row <= sheet.Dimension?.Rows; row++)
            {
                provincias.Add(new Provincia
                {
                    Id = id++,
                    Nombre = sheet.Cells[row, 2].Text
                });
            }
        }

        return provincias;
    }

    public static List<Ciudad> LoadCiudadesFromExcel(string filePath)
    {
        var ciudades = new List<Ciudad>();
        string baseDirectory = Directory.GetCurrentDirectory();
        string excelFilePath = Path.Combine(baseDirectory, filePath);

        if (!File.Exists(excelFilePath))
        {
            throw new FileNotFoundException($"El archivo Excel no se encuentra en la ruta especificada: {excelFilePath}");
        }

        using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
        {
            var sheet = package.Workbook.Worksheets["Ciudades"];
            if (sheet == null)
            {
                throw new InvalidOperationException("La hoja 'Ciudades' no se encuentra en el archivo Excel.");
            }

            int id = 0; // Usar IDs negativos para evitar colisiones
            for (int row = 2; row <= sheet.Dimension?.Rows; row++)
            {
                ciudades.Add(new Ciudad
                {
                    Id = id++,
                    Nombre = sheet.Cells[row, 2].Text,
                    IdProvincia = int.Parse(sheet.Cells[row, 3].Text),
                    //FechaCreacionUTC = DateTime.UtcNow,
                    //Activo = true

                });
            }
        }

        return ciudades;
    }

}

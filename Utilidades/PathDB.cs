﻿
namespace ClinicaVet.Utilidades
{
    public static class PathDB
    {
        public static string GetPath(string nameDB)
        {
            string pathDbSqlite = string.Empty;
            pathDbSqlite = Path.Combine(FileSystem.AppDataDirectory, nameDB);
            
            return pathDbSqlite;
        }
    }
}
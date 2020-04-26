using Indexer2.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer2.DB
{
    static class SQLITE_DAL
    {
        static SQLiteConnection sqlite_conn;
        static SQLiteCommand sqlite_cmd;
        static Random rnd = new Random();
        static byte researchNumberReference;

        public static bool Initialize()
        {
            ConsoleWriter.WriteNotification("INITIALIZING CONNECTION -----------------------------------------------------------");
            try
            {
                researchNumberReference = Convert.ToByte(rnd.Next(128));
                sqlite_conn = CreateConnection();
                CreateTables();

                return true;
            }
            catch (Exception e)
            {
                ConsoleWriter.WriteWarning(e.Message);

                return false;
            }

        }

        static SQLiteConnection CreateConnection()
        {

            // Create a new database connection:
            sqlite_conn = new SQLiteConnection
            (
            @"Data Source=database.db; 
            Version = 3; 
            New = True; 
            Compress = True; "
            );

            // Open the connection:
            try
            {
                sqlite_conn.Open();
                ConsoleWriter.WriteNotification("CONNECTION STABLISHED-----------------------------------------------------------");

            }
            catch (Exception e)
            {
                ConsoleWriter.WriteWarning(e.Message);
            }

            return sqlite_conn;
        }

        public static void CloseConnection()
        {

            // Open the connection:
            try
            {
                sqlite_conn.Close();
                sqlite_conn = null;
                ConsoleWriter.WriteNotification("CONNECTION CLOSED-----------------------------------------------------------");

            }
            catch (Exception e)
            {
                ConsoleWriter.WriteWarning(e.Message);
            }
        }

        const string fileTable =
            @"CREATE TABLE IF NOT EXISTS t_file(

                idFile INTEGER PRIMARY KEY AUTOINCREMENT,
                filePath TEXT  NOT NULL,
                fileName TEXT  NOT NULL,
                fileAuthor TEXT  NULL,
                fileDate TEXT NULL,
                fileModificationDate TEXT NULL,
                referenceNumber REAL NOT NULL

            )";

        const string sourceTable =
            @"CREATE TABLE IF NOT EXISTS t_source(

                idSource INTEGER PRIMARY KEY AUTOINCREMENT,
                sourceName TEXT NOT NULL

            )";

        const string fileSourceBindTable =
            @"CREATE TABLE IF NOT EXISTS t_fileSourceBind(

                idSource INTEGER NOT NULL,
                idFile INTEGER NOT NULL

            )";

        //TODO T_words, fileWordsBind, t_imgs, fileImgsBind

        static void CreateTables()
        {
            ConsoleWriter.WriteNotification("BUILDING TABLES-----------------------------------------------------------");

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = fileTable;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = sourceTable;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = fileSourceBindTable;
            sqlite_cmd.ExecuteNonQuery();

        }


        public static void InsertDFile(FileExtract fE)
        {
            ConsoleWriter.WriteNotification($"INSERTING FILE {fE.Name} DATA-----------------------------------------------------------");

            string dataExtracted =
            $"INSERT INTO t_file " +

            $"(" +
            $"filePath, " +
            $"fileName, " +
            $"fileAuthor, " +
            $"fileDate, " +
            $"fileModificationDate,  " +
            $"referenceNumber " +
            $")" +

            $"VALUES" +
            $"( " +
            $"\"{fE.Path}\", " +
            $"\"{fE.Name}\", " +
            $"\"{fE.Author}\", " +
            $"\"{Convert.ToString(fE.Date)}\", " +
            $"\"{Convert.ToString(fE.LastModifiedDate)}\", " +
            $"\"{researchNumberReference}\" " +
            $")";


            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = dataExtracted;
            sqlite_cmd.ExecuteNonQuery();

            Sanitize(researchNumberReference);
        }

        static void InsertData(FileExtract fE, Source src)
        {

            string dataExtracted =
            $"INSERT INTO t_file " +
            $"( " +
            $"{fE.Path}, " +
            $"{fE.Name}, " +
            $"{fE.Author}, " +
            $"{fE.Date}, " +
            $"{fE.LastModifiedDate}, " +
            $"{researchNumberReference}, " +
            $"{src.Name}, " +
            $"(SELECT idSource FROM t_source WHERE {src.Name} = t_source.sourceName), " +
            $"(SELECT idFile FROM t_file WHERE {fE.Path} = t_source.filePath) " +
            $")" +

            $"SELECT " +

            $"filePath, " +
            $"fileName, " +
            $"fileAuthor, " +
            $"fileDate, " +
            $"fileModificationDate,  " +
            $"referenceNumber," +
            $"t_source.sourceName, " +
            $"t_fileSourceBind.idSource, " +
            $"t_fileSourceBind.idFile" +

            $"FROM t_file" +

            $"INNER JOIN t_fileSourceBind ON t_file.idFile  = t_fileSourceBind.idFile" +
            $"INNER JOIN t_source ON t_fileSourceBind.idSource = t_source.idSource)";
        }



        public static void Sanitize(byte referenceNumber)
        {
            //Eliminitates old entries that might not exist anymore
            string deleteUnexistentEntries =
            $"DELETE FROM t_file WHERE referenceNumber != \"{referenceNumber}\" ";

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = deleteUnexistentEntries;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void Sanitize2(byte referenceNumber)
        {
            //Eliminitates old entries that might not exist anymore
            string deleteUnexistentEntries =
            $"DELETE FROM t_file WHERE referenceNumber != \"{referenceNumber}\" IN" +
            $"(" +
            $"SELECT " +

            $"filePath, " +
            $"fileName, " +
            $"fileAuthor, " +
            $"fileDate, " +
            $"fileModificationDate,  " +
            $"referenceNumber," +
            $"t_source.sourceName, " +
            $"t_fileSourceBind.idSource, " +
            $"t_fileSourceBind.idFile," +

            $"FROM t_file" +

            $"INNER JOIN t_fileSourceBind ON t_file.idFile  = t_fileSourceBind.idFile" +
            $"INNER JOIN t_source ON t_fileSourceBind.idSource = t_source.idSource";

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = deleteUnexistentEntries;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void ReadData()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM t_file";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            ConsoleWriter.WriteNotification("ReadingData -----------------------------------------------------------");
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(2);
                Console.WriteLine(myreader);

            }
            ConsoleWriter.WriteNotification("Reading Ended -----------------------------------------------------------");

            sqlite_conn.Close();
        }
    }
}

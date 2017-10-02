using System.Data;

namespace Flepper.Tests.Integration.Infra.Extensions
{
    public static class DbConnectionExtensions
    {

        public static IDbConnection CreateProfileTable(this IDbConnection dbConnection)
        {
            dbConnection.Open();
            var command = dbConnection.CreateCommand();
            command.CommandText = @"CREATE TABLE IF NOT EXISTS `Profile` (
	                                `Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                                `Name`	INTEGER NOT NULL UNIQUE);";


            command.ExecuteNonQuery();
            dbConnection.Close();
            return dbConnection;
        }

        public static IDbConnection CreateUserTable(this IDbConnection dbConnection)
        {
            dbConnection.Open();
            var command = dbConnection.CreateCommand();

            command.CommandText = @"CREATE TABLE IF NOT EXISTS `User` (
	                                    `Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                                    `Name`	TEXT NOT NULL,
	                                    `Email`	TEXT NOT NULL UNIQUE,
                                        `ProfileId`	INTEGER,
                                        FOREIGN KEY(ProfileId) REFERENCES Profile(Id));";

            command.ExecuteNonQuery();
            dbConnection.Close();
            return dbConnection;
        }


        public static IDbConnection LoadProfileTable(this IDbConnection dbConnection)
        {
            dbConnection.Open();
            var command = dbConnection.CreateCommand();
            command.CommandText = @"INSERT INTO Profile (Name) VALUES ('Admin');
                                    INSERT INTO Profile (Name) VALUES ('User');";

            command.ExecuteNonQuery();
            dbConnection.Close();
            return dbConnection;
        }

        public static IDbConnection LoadUserTable(this IDbConnection dbConnection)
        {
            dbConnection.Open();
            var command = dbConnection.CreateCommand();
            command.CommandText = @"INSERT INTO User (Name, Email, ProfileId) VALUES ('Nicolas','nicolas@flepper.com', 2);
                                    INSERT INTO User (Name, Email, ProfileId) VALUES ('Gustavo','gustavo@flepper.com', 1);
                                    INSERT INTO User (Name, Email, ProfileId) VALUES ('Alberto','alberto@flepper.com', 1);";

            command.ExecuteNonQuery();
            dbConnection.Close();
            return dbConnection;
        }

        public static IDbConnection ResetProfileTable(this IDbConnection dbConnection)
        {
            dbConnection.Open();
            var command = dbConnection.CreateCommand();
            command.CommandText = @"delete from Profile;    
                                    delete from sqlite_sequence where name='Profile';";

            command.ExecuteNonQuery();
            dbConnection.Close();
            return dbConnection;
        }

        public static IDbConnection ResetUserTable(this IDbConnection dbConnection)
        {
            dbConnection.Open();
            var command = dbConnection.CreateCommand();
            command.CommandText = @"delete from User;    
                                    delete from sqlite_sequence where name='User';";

            command.ExecuteNonQuery();
            dbConnection.Close();
            return dbConnection;
        }
    }
}

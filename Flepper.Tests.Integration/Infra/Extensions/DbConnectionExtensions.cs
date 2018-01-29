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
	                                `Name`	Text NOT NULL UNIQUE);";


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
                                        `Nickname`	TEXT NULL,
                                        `ProfileId`	INTEGER,
                                        `Active` INTEGER,
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
            command.CommandText = @"INSERT INTO User (Name, Email, ProfileId, Active) VALUES ('Nicolas','nicolas@flepper.com', 2, 1);
                                    INSERT INTO User (Name, Email, ProfileId, Active) VALUES ('Gustavo','gustavo@flepper.com', 1, 1);
                                    INSERT INTO User (Name, Email, ProfileId, Active) VALUES ('Alberto','alberto@flepper.com', 1, 1);";

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

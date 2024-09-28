using SQLite;

namespace SRC_system_of_registration_of_conscripts_.Database
{
    public class DatabaseAcess
    {
        SQLiteAsyncConnection Database;

        public DatabaseAcess()
        {
            
        }

        public async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(DatabaseConstants.DatabasePath, DatabaseConstants.Flags);
            var result = await Database.CreateTableAsync<DatabaseTemplate>();
        }
    }
}

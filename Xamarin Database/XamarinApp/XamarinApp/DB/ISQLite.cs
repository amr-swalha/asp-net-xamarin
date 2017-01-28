using SQLite;

namespace XamarinApp.DB
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
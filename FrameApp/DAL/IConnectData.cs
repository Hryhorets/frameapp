namespace FrameApp.DAL
{
    interface IConnectData<T> where T: System.Data.Common.DbConnection
    {
        string ConnectionString { get; }
        T SetConnection();
    }
}

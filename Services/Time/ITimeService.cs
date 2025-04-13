namespace WebApplication3.Services.Time
{
    public interface ITimeService
    {
        long GetCurrentDateTimestamp();
        string GetCurrentDateSqlFormat();
        long ParseSqlFormatToTimestamp(string sqlFormat);
    }
}

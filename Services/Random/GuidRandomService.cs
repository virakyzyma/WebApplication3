namespace WebApplication3.Services.Random
{
    public class GuidRandomService : IRandomService
    {
        public string FileName()
        {
            return Guid.NewGuid().ToString();
        }
    }
}

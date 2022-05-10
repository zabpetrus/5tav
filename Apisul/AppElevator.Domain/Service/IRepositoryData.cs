using Newtonsoft.Json.Linq;

namespace AppElevator.Domain.Service
{
    public interface IRepositoryData
    {
        public JArray GetData();
        
    }
}

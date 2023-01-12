using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    internal class VirtualTemperatureSensor : ITemperatureSensorInterface, ISensorInterface
    {
        private readonly Random Random;

        public VirtualTemperatureSensor()
        {
            Random = new Random();
        }

        public int Temperature()
        {
            return new Temperature(Random.Next(-100, 100)).Value;
        }
        public string ToJson()
        {
            return JsonSerializer.Serialize(Temperature());
        }
        public string GetSlug()
        {
            return "temperature";
        }
    }
}

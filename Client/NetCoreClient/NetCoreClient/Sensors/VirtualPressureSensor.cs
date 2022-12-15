using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    internal class VirtualPressureSensor : IPressureSensorInterface, ISensorInterface
    {
        private readonly Random Random;

        public VirtualPressureSensor()
        {
            Random = new Random();
        }

        public int Pressure()
        {
            return new Pressure(Random.Next(100)).Value;
        }
        public string ToJson()
        {
            return JsonSerializer.Serialize(Pressure());
        }
    }
}

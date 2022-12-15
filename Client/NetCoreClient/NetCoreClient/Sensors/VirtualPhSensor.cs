using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    internal class VirtualPhSensor : ISensorInterface, IPhSensorInterface
    {
        private readonly Random Random;

        public VirtualPhSensor()
        {
            Random = new Random();
        }

        public float Ph()
        {
            return new Ph(Random.Next(0, 14)).Value;
        }
        public string ToJson()
        {
            return JsonSerializer.Serialize(Ph());
        }
    }
}

using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

// define sensors
List<ISensorInterface> sensors = new();
sensors.Add(new VirtualLevelSensor());
sensors.Add(new VirtualPhSensor());
sensors.Add(new VirtualTemperatureSensor());
sensors.Add(new VirtualPressureSensor());

// define protocol
//ProtocolInterface protocol = new Http("http://localhost:8011/silos/123");
IProtocolInterface protocol = new Mqtt("test.mosquitto.org");

var s = 0;
// send data to server
while (true)
{
    foreach (ISensorInterface sensor in sensors)
    {
        if (s < 4)
        {
            s += 1;
        }
        else
        {
            s = 1;
        }

        var sensorValue = sensor.ToJson();

        protocol.Send(sensorValue, sensor.GetSlug());

        Console.WriteLine($"{s} Data sent: " + sensorValue);

        Thread.Sleep(1000);
    }

}
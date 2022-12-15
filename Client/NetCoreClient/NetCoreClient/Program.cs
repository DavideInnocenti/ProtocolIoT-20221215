using NetCoreClient.Sensors;
using NetCoreClient.Protocols;

// define sensors
List<ISensorInterface> sensors = new();
sensors.Add(new VirtualLevelSensor());
sensors.Add(new VirtualPhSensor());
sensors.Add(new VirtualTemperatureSensor());
sensors.Add(new VirtualPressureSensor());

// define protocol
ProtocolInterface protocol = new Http("http://localhost:8011/silos/123");

Console.WriteLine("LEGENDA");
Console.WriteLine("1=Level Sensor \n2=Ph Sensor \n3=Temperature Sensor \n4=Pressure Sensor");
Console.WriteLine("");
// send data to server
  var s = 0; 
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

        protocol.Send(sensorValue);

        Console.WriteLine($"{s} Data sent: " + sensorValue);

        Thread.Sleep(1000);
    }
    Console.WriteLine("");

}
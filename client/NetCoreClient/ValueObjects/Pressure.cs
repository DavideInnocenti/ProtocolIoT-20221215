namespace NetCoreClient.ValueObjects
{
    internal class Pressure
    {
            public int Value { get; private set; }

            public Pressure(int value)
            {
                this.Value = value;
            }
    }
}

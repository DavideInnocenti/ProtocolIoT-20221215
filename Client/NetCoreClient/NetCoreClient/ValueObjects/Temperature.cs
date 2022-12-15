namespace NetCoreClient.ValueObjects
{
    internal class Temperature
    {
            public int Value { get; private set; }

            public Temperature(int value)
            {
                this.Value = value;
            }
    }
}

namespace Ex6
{
    class Data
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Data(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public double Media(Data[] list)
        {
            double avg = 0.0;
            for (int i = 0; i < list.Length; i++)
            {
                avg += list[i].Value;
            }
            return avg / list.Length;
        }
    }
}

namespace RESTtemperatureConsumer
{
    class Temp
    {
        public int Id { get; set; }
        public string Temperatur { get; set; }

        public override string ToString()
        {
            return Id + " " + Temperatur;
        }
    }
}

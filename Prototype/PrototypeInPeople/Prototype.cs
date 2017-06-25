namespace PrototypeInPeople
{
    class Prototype
    {
        public string Class { get; set; }
        public string State { get; set; }
        public Prototype Clone()
        {
            return MemberwiseClone() as Prototype;
        }
    }
}

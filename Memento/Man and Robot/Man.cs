namespace Man_and_Robot
{
    internal class Man
    {
        public string Clothes { get; internal set; }

        public Backpack Undress()
        {
            return new Backpack(Clothes);
        }

        public void Dress(Backpack backpack)
        {
            Clothes = backpack.Contents;
        }
    }
}
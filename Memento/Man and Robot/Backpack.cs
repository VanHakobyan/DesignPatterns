namespace Man_and_Robot
{
    public class Backpack
    {
        public Backpack(string contents)
        {
            Contents = contents;
        }

        public string Contents { get; internal set; }
    }
}
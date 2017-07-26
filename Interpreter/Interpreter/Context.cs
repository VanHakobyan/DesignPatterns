namespace Interpreter
{
    internal class Context
    {
        public string Source { get; set; }
        public char Vocabulary { get; set; }
        public bool Result { get; internal set; }
        public int Position { get; set; }
    }
}
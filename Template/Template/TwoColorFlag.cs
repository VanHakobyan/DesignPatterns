namespace Template
{
    abstract class TwoColorFlag
    {
        public void Draw()
        {
            DrawTopPart();
            DrawBottomPart();
        }
        protected abstract void DrawBottomPart();
        protected abstract void DrawTopPart();
    }
}

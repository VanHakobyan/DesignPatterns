using System;

namespace Template
{
    abstract class TreeColorFlag
    {
        public void Draw()
        {
            DrawName();
            DrawFirstPart();
            DrawSecondPart();
            DrawThirdPart();
        }

        protected abstract void DrawName();
        protected abstract void DrawFirstPart();
        protected abstract void DrawSecondPart();
        protected abstract void DrawThirdPart();
    }
}

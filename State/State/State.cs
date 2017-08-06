namespace State
{
    abstract class State
    {
        internal abstract void Handle(Context context);
    }
}

namespace ConsoleApp1
{
    public class BaseClass
    {
        public virtual int publicUye { get; set; }
        protected virtual int protectedUye { get; set; }
        internal virtual int internalUye { get; set; }
        protected virtual internal int protectedInternalUye { get; set; }
        private int privateUye { get; set; }
    }
}

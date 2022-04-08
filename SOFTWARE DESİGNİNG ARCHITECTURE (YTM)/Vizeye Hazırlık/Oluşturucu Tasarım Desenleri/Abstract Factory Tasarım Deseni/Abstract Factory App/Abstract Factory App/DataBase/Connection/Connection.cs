namespace Abstract_Factory_App
{
    public abstract class Connection
    {
        public abstract void Connect();
        protected string connString;

        public abstract string ConnString { get;set; }
    }
}

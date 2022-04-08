namespace Abstract_Factory_App
{
    public abstract class Command
    {
        public abstract void Execute();
        protected string query;
        public abstract string Query { get; set; }
    }
}

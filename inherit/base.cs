namespace inherit
{

    public class Base
    {
        public string basestring;

        public Base()
        {
            this.basestring = "here we are in the base.cs";
        }

        public virtual void ripit()
        {
            Console.WriteLine("Hello from the methods in base.cs");
        }

    }

}
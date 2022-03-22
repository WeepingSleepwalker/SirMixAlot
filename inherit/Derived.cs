namespace inherit
{
    public class Derived : Base
    {
        public string derivedString;

        public Derived()
        {
            this.derivedString = "hello from the derived constructor";
        }

        public override void ripit()
        {
            Console.WriteLine("This is an extension ");
        }
    }
}
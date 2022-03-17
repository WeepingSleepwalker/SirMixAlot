namespace FileInteraction
{
    
    class Person
    {
        public string name;
        public double height;
        public int age;

        public Person( string PersonName, double PersonHeight, int PersonAge) 
        {
            this.name = PersonName;
            this.height = PersonHeight;
            this.age = PersonAge;

        }

        public int GrowUp()
        {
            this.age++;
            return this.age;
        }
    }
}
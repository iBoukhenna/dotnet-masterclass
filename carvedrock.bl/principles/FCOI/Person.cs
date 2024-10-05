namespace carvedrock.bl.principles.FCOI
{
    class Person
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(String title, String name, int age)
        {
            Title = title;
            Name = name;
            Age = age;
        }
    }
}

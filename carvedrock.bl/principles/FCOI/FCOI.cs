namespace carvedrock.bl.principles.FCOI
{
    public class FCOI
    {
        public FCOI()
        {
            string title = "Architect";
            string name = "John Doe";
            int age = 35;
            Person person = new(title, name, age);
            int salary = 1500;
            Employee employee = new(person, salary);
        }
    }
}

namespace Test.Models.Entities
{
    public class Students
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Groups? Groups { get; set; }
    }
}

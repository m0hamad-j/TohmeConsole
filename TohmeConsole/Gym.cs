namespace TohmeConsole
{
    class Gym
    {
        public int Id { get; set; }
        public string? Customer { get; set; }
        public string? Machine { get; set; }
        public string? Protein { get; set; }
        public string? Dumbbells { get; set; }

        public Gym(int id, string? customer, string? machine, string? protein, string? dumbbells)

        {
            Id = id;
            Customer = customer;
            Machine = machine;
            Protein = protein;
            Dumbbells = dumbbells;

        }
        public void Update(string? customer, string? machine, string? protein, string? dumbbells)

        {
            Customer = customer;
            Machine = machine;
            Protein = protein;
            Dumbbells = dumbbells;
        }

        public override string ToString()
        {
            return Id + " " + Customer + " " + Machine + " " + Protein + " " + Dumbbells;
        }
    }
}
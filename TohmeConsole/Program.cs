using TohmeConsole;

List<Gym> gyms = new();
while (true)
{

    Console.WriteLine("press 1  to add");
    Console.WriteLine("press 2 to read");
    Console.WriteLine("press 3  to update ");
    Console.WriteLine("press 4  to delete ");
    Console.WriteLine("press 5  to exit ");
    int process = Convert.ToInt32(Console.ReadLine());
    switch (process)
    {
        case 1:
            Create();
            break;
        case 2:
            Read();
            break;

        case 3:
            Update();
            break;
        case 4:
            Delete();
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("you entered a wrong number ");
            break;
    }
}


void Create()
{
    var id = gyms.Any() ? gyms.Max(g => g.Id) + 1 : 1;
    Console.WriteLine("enter the new customer");
    var customer = Console.ReadLine();
    Console.WriteLine("enter the new machine");
    var machine = Console.ReadLine();
    Console.WriteLine("enter the new protein item");
    var proteins = Console.ReadLine();
    Console.WriteLine("enter the new dumbbells");
    var dumbbells = Console.ReadLine();
    var gym = new Gym(id, customer, machine, proteins, dumbbells);
    gyms.Add(gym);
}
void Read()
{
    foreach (var gym in gyms)
    {
        Console.WriteLine(gym.Id + " " + gym.Customer + " " + gym.Machine + " " + gym.Protein + " " + gym.Dumbbells);
    }

    gyms.ForEach(gym => Console.WriteLine(gym.Id + " " + gym.Customer + " " + gym.Machine + " " + gym.Protein + " " + gym.Dumbbells));
    for (int i = 0; i < gyms.Count; i++)
    {
        Console.WriteLine(gyms[i].Id + " " + gyms[i].Customer + " " + gyms[i].Machine + " " + gyms[i].Protein + " " + gyms[i].Dumbbells);
    }
    gyms.WriteList();
}
void Update()
{
    try
    {

        Console.WriteLine("Enter the id of the gym you want to update");
        var idInput = Console.ReadLine();
        while (string.IsNullOrEmpty(idInput))
        {
            Console.WriteLine("Invalid id please provide a valid format");
            idInput = Console.ReadLine();
        }
        var id = Convert.ToInt32(idInput);
        var gym = gyms.FirstOrDefault(gym => gym.Id == id) ?? throw new Exception("Invalid gym");

        Console.WriteLine("enter the new customer");
        var customer = Console.ReadLine();
        Console.WriteLine("enter the updated machine");
        var machine = Console.ReadLine();
        Console.WriteLine("enter the new protein item");
        var proteins = Console.ReadLine();
        Console.WriteLine("enter the updated dumbbells");
        var dumbbells = Console.ReadLine();

        gym.Update(customer, machine, proteins, dumbbells);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}
void Delete()
{
    try
    {
        Console.WriteLine("Enter the id of the gym you want to update");
        var idInput = Console.ReadLine();
        while (string.IsNullOrEmpty(idInput))
        {
            Console.WriteLine("Invalid id please provide a valid format");
            idInput = Console.ReadLine();
        }
        var id = Convert.ToInt32(idInput);
        var gym = gyms.FirstOrDefault(gym => gym.Id == id) ?? throw new Exception("Invalid gym");
        gyms.Remove(gym);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

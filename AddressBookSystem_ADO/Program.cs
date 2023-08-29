using AddressBookSystem_ADO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-------: AddressBookSystem :-----");
        AddressBookOperation Operation = new AddressBookOperation();
        //Operation.CreateDatabase();
       // Operation.CreateTable();
        AddressModel data = new AddressModel()
        {
            FirstName = "hello",
            LastName = "world",
            Address = "cpu",
            City = "processor",
            State = "Hardware",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "shrey@gmail.com",

        };
        Operation.exuctedorNot(Operation.AddEmployee(data));
    }
}
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
        AddressModel edit = new AddressModel()
        {
            FirstName = "hello",
            LastName = "world",
            Address = "cpu",
            City = "updatedata",
            State = "update",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "shrey@gmail.com",

        };
        AddressModel delete = new AddressModel()
        {
            FirstName = "hello",
        };
        // Operation.exuctedorNot(Operation.InsertData(data));
        //Operation.exuctedorNot(Operation.EditData(data));
        // Operation.exuctedorNot(Operation.DeleteDatat(data));
        string city = "Chennai";
        Operation.GetAllEmployeeDetailsByCity(city);
        Operation.DisplayAllData(city);
        
    }
}
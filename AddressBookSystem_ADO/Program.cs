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
            Relation = "Friends"

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
            Relation = "Others"

        };
        AddressModel delete = new AddressModel()
        {
            FirstName = "hello",
        };
         //Operation.exuctedorNot(Operation.InsertData(data));
        //Operation.exuctedorNot(Operation.EditData(data));
        // Operation.exuctedorNot(Operation.DeleteDatat(data));
        string citysearch = "processor";
        string statesearch = "Hardware";
        //Operation.GetAllEmployeeDetailsByCity(citysearch);
        //Operation.DisplayAllDataByCity(citysearch);
        // Operation.GetAllEmployeeDetailsByState(statesearch);
        //Operation.DisplayAllDataByState(statesearch);
        // Operation.SizeByCity();
        //Operation.SizeByState();
        //Operation.GetPeopleInCitySortedByName("processor");
        // Operation.CountByType();
        ///Operation.PersonAsTwoRelation("kanha", "Profession");


        //MultiThreading concept
        List<AddressModel> list = new List<AddressModel>();
        list.Add(new AddressModel()
        {
            FirstName = "a",
            LastName = "a",
            Address = "cpu",
            City = "processor",
            State = "Hardware",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "shrey@gmail.com",
            Relation = "Others"
        });
        list.Add(new AddressModel()
        {
            FirstName = "b",
            LastName = "world",
            Address = "cpu",
            City = "processor",
            State = "Hardware",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "shrey@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "c",
            LastName = "world",
            Address = "cpu",
            City = "processor",
            State = "Hardware",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "shrey@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "d",
            LastName = "world",
            Address = "cpu",
            City = "processor",
            State = "Hardware",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "shrey@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "e",
            LastName = "world",
            Address = "cpu",
            City = "processor",
            State = "Hardware",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "shrey@gmail.com",
            Relation = "Others"
        });

        WithAndWithOutThread thread = new WithAndWithOutThread();
        thread.UsingWithThread(list);
        thread.UsingWithThread(list);


    }
}
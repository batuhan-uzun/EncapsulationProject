using EncapsulationProject;

Car car1 = new Car(); // Created car1 object using car class
Console.WriteLine("Arabanın markasını giriniz");
car1.Brand = Console.ReadLine();
Console.WriteLine("Arabanın modelini giriniz");
car1.Model = Console.ReadLine();
Console.WriteLine("Arabanın rengini giriniz");
car1.Color = Console.ReadLine();
Console.WriteLine("Arabanın kapı sayısını giriniz");
car1.NumberOfDoors = Convert.ToInt32(Console.ReadLine());

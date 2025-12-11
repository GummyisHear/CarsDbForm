namespace WinFormsApp1.Models;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string RegistrationNumber { get; set; }
    public int OwnerId { get; set; }
    public Owner Owner { get; set; }
    public List<CarService> CarServices { get; set; }
    public byte[]? Picture { get; set; }

    public string DisplayName => $"{Brand} {Model} ({RegistrationNumber})";

    public override string ToString()
    {
        return $"{Brand} {Model} ({RegistrationNumber})";
    }

    public bool Match(string filter)
    {
        return Brand.Contains(filter) || Model.Contains(filter) || RegistrationNumber.Contains(filter);
    } 
}

public class Owner
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public List<Car> Cars { get; set; }

    public override string ToString()
    {
        return $"{FullName}";
    }

    public bool Match(string filter)
    {
        return FullName.Contains(filter) || Phone.Contains(filter);
    }
}

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public List<CarService> CarServices { get; set; }

    public bool Match(string filter)
    {
        return Name.Contains(filter);
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}

public class CarService
{
    public int CarId { get; set; }
    public int ServiceId { get; set; }
    public DateTime DateOfService { get; set; }
    public bool Paid { get; set; }
    public float PaidPrice { get; set; }
    public Car Car { get; set; }
    public Service Service { get; set; }

    public bool Match(string filter)
    {
        return Car.Match(filter) || Service.Match(filter) || DateOfService.ToString().Contains(filter);
    }
}
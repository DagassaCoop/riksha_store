public class Order {
    public int Id {get; set;}

    public string Name {get; set;}

    public string Phone {get; set;}

    public bool IsDelivery {get; set;}

    //can be null
    public DateTime TimeToDelivery {get; set;}

    public string Address {get; set;}

    public string NumberHouse {get; set;}

    //can be null
    public string NumberEntrence {get; set;}

    //can be null
    public string NumberFloor {get; set;}

    //can be null
    public string NumberApartment {get; set;}

    //TO-DO: make other fields

}
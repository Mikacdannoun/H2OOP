internal class Phone
{
    public string Brand { get; set; }
    public int Price { get; set; }

    public Phone(string brand, int price)
    {
        Brand = brand;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Brand}, costs {Price} kr.";
    }
}

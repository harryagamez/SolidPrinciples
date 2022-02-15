

/*
 * All classes that derives from T (S) can replace T.
 */

SaleWithTaxes sale = new LocalSale(100, "Harry", 0.16m);
sale.CalculateTaxes();
sale.Generate();
sale = new SaleInvoice(100, "Hector", 0.16m);
sale.CalculateTaxes();
sale.Generate();

AbstractSale sale2 = new ForeignSale(200, "Pepe");
sale2.Generate();

public abstract class AbstractSale // T
{
    protected decimal amount;
    protected string customer;    

    public abstract void Generate();    
}

public abstract class SaleWithTaxes : AbstractSale
{
    protected decimal taxes;
    public abstract void CalculateTaxes();
}

public class LocalSale : SaleWithTaxes
{
    public LocalSale(decimal amount, string costumer, decimal taxes)
    {
        this.amount = amount;
        this.customer = costumer;
        this.taxes = taxes;
    }

    public override void Generate()
    {
        Console.WriteLine("Se genera la venta");
    }
    public override void CalculateTaxes()
    {
        Console.WriteLine("Se calculan los impuestos");
    }

}

public class SaleInvoice : SaleWithTaxes
{
    public SaleInvoice(decimal amount, string customer, decimal taxes)
    {
        this.amount = amount;
        this.customer = customer;
        this.taxes = taxes;
    }

    public override void CalculateTaxes()
    {
        Console.WriteLine("Se calculan los impuestos");
    }

    public override void Generate()
    {
        Console.WriteLine("Se calculan los impuestos");
    }

    public void XML()
    {
        Console.WriteLine("Se genera el xml de la factura");
    }
}


public class ForeignSale : AbstractSale
{
    public ForeignSale(decimal amount, string costumer)
    {
        this.amount = amount;
        this.customer = costumer;        
    }

    public override void Generate()
    {
        Console.WriteLine("Se genera la venta");
    } 
}
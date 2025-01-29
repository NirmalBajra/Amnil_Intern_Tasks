using System;

public interface IPayment{
    void ProcessPayment();
}
public class CreditCardPayment : IPayment{
    public void ProcessPayment(){
        Console.WriteLine("Processing Payment Through CreditCard.");
    }
} 
public class PayPalPayment : IPayment{
    public void ProcessPayment(){
        Console.WriteLine("Processing Payment through PayPal.");
    }
}
class Program{
    static void Main(string[] args){
        IPayment creditCardPayment = new CreditCardPayment();
        IPayment payPalPayment = new PayPalPayment();

        creditCardPayment.ProcessPayment();
        payPalPayment.ProcessPayment();
    }
}
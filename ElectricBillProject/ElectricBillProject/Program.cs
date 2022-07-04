// See https://aka.ms/new-console-template for more information
using ElectricBillProject;

Console.WriteLine("Hello, World!");
var junaid = new User();
junaid.getElectricBill(50, "residential");
junaid.getElectricBill(150, "residential");
junaid.getElectricBill(300, "residential");
junaid.getElectricBill(505, "residential");
junaid.getElectricBill(50, "commercial");
junaid.getElectricBill(150, "commercial");
junaid.getElectricBill(300, "commercial");
junaid.getElectricBill(850, "commercial");
namespace ClassLibrary;

public class Calculator
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }

    public int Add() => FirstNumber + SecondNumber;
    public int Subtract() => FirstNumber - SecondNumber;
}
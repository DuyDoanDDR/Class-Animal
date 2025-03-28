﻿public abstract class Animal
{
    protected string weight { get; set; }
    protected string height { get; set; } //Tu khoa protected nghia la property nay chi co the duoc truy cap bven trong class do, va cac class ke thua no
                                          //Chi co the truy cap tu ben ngoai thong qua phuong thuc get/set
    public Animal()
    {
    }
    public Animal (string weight, string height)
    {
        this.weight = weight;
        this.height = height;
    }
    public abstract void PrintInfo(); //abstact method la phuong thuc khong co phan than, chi duoc khai bao nhung khong duoc dinh nghia ben trong abstract class
                                      //No bat buoc phai duoc override trong cac lop con (derived class)
}
class Cat : Animal //Class Cat ke thua cac thuoc tinh cua class Animal
{
    private string Name { get; set; } //Property rieng ten la Name, chi duoc truy cap ben trong class cat
    public Cat(string weight, string height, string name) //Phuong thuc khoi tao cho Class Cat, 
    : base(weight, height) //Tham chieu den phuong thuc khoi tao cua Class Animal va truyen weight va height len no
    {
        this.Name = name;
    }

    public override void PrintInfo() //Ghi de len phuong thuc PrintInfo
    {
       Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + "Name: {2}", this.weight, this.height, this.Name); //Noi dung ghi de va thuoc tinh se duoc ghi len
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("20 kg", "1.5", "Kitty");
        cat.PrintInfo();
    }
}

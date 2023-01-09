using SolidHomeWork.Concrete;

Console.WriteLine("Hoşgeldiniz!");

CEO boss = new CEO();

decimal result = boss.MaasHesapla(50);
Console.WriteLine(result);
boss.SendReport();

Manager mng = new Manager();

decimal result2 = mng.MaasHesapla(30);
Console.WriteLine(result2);
mng.SendReport();

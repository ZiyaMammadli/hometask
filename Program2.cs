#region ATM task

Console.WriteLine("username daxil edin :"); string username = Convert.ToString(Console.ReadLine());
Console.WriteLine("password daxil edin :"); string password = Convert.ToString(Console.ReadLine());
string username1 = "ziya";
string password1 = "040";
int balance = 100;

if (username1 == username && password1 == password)
{
    while (balance >= 0)
    {
        Console.WriteLine("Hər vaxtınız xeyir xoş gəlmişsiniz Müəllim..");
        Console.WriteLine("1) Balansı artır");
        Console.WriteLine("2) Balansdan pul çək");
        Console.WriteLine("3) Cari balans");
        Console.WriteLine("4) Çıxış et");
        Console.WriteLine("Zəhmət olmasa reallaşdıracağımız prosesin nömrəsini daxil edin.."); int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            Console.WriteLine("Nə qədər artırmaq istəyirsiniz?"); int num2 = Convert.ToInt32(Console.ReadLine());
            balance = balance + num2;
            Console.WriteLine("cari balans  :" + balance);
        }
        else if (num == 2)
        {
            Console.WriteLine("Nə qədər pul çəkmək istəyirsiniz?"); int num3 = Convert.ToInt32(Console.ReadLine());
            balance = balance - num3;
            Console.WriteLine("cari balans  :" + balance);
        }
        else if (num == 3)
        {
            Console.WriteLine("cari balans  :" + balance);
        }
        else if (num == 4)
        {
            Console.WriteLine("Bizi seçdiyiniz üçün təşəkkürlər");
            break;
        }
    }
}

#endregion
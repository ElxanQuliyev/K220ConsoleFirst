//Console.WriteLine("Adin nedi?");
//var adi=Console.ReadLine();
//Console.WriteLine("Necenci ilsen?");
//var yas = Console.ReadLine();

//Console.WriteLine("Salam " + adi + " " + yas + "-ci ilsen");

//25.55
//


//for (int i = 0; i < message.Length; i++)
//{
//    if (message[i] == '1')
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);

//string[] adlar = new[] { "Melik","Nahid"};



//object a = 'c';

//2^32
//bool success = true;

//while (success)
//{
//    try
//    {

//        Console.Write("reqem: ");
//        string test = Console.ReadLine();
//        decimal reqem = Convert.ToDecimal(test);
//        Console.WriteLine(reqem + 5);
//        success = false;
//    }
//    catch (Exception)
//    {

//        Console.WriteLine("Reqem daxil et!!");
//    }
//}

//int say = 40;
//switch (say)
//{
//    case 10:
//        Console.WriteLine("asdas");
//        break;
//    default:
//        Console.WriteLine(say);
//        break;
//}
//string balInput = "";
//while (balInput!="exit")
//{
//    try
//    {
//        Console.Write("Balinizi daxil edin:");
//        balInput = Console.ReadLine();
//        if (balInput != "exit")
//        {
//            int bal = Convert.ToInt32(balInput);
//            if (bal >= 51 && bal < 61)
//            {
//                Console.WriteLine("Kafi");
//            }
//            else if (bal >= 61 && bal < 71)
//            {
//                Console.WriteLine("Yaxsı");
//            }
//        }
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Düzgün bal edin");
//    }
//}

using K220ConsoleFirst;
using K220ConsoleFirst.models;

//while (true)
//{

//Console.Write("ad daxil et:");
//string ad=Console.ReadLine();

//Console.Write("yas daxil et:");
//string yas = Console.ReadLine();


//Person person = new Person();
//person.name = ad;
//person.age = Convert.ToByte(yas);
//Console.WriteLine("ad: "+person.name+"yas: "+person.age);
//    Console.WriteLine(person.GetType());
//}


//Category category = new Category();

//reference type/ value type

//int a = 5;
//int b = a;
//a = 25;
//Console.WriteLine(a+","+b);

//int[] arr1 = new[] { 1, 2, 3, 4, 5 };

//int[] arr2 = new[] { 30, 50, 60, 70, 80 };

//arr1= arr2;

//arr1[0]=1000;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//boxing,unboxing

//object reqem = 20;
//int r = (int)reqem;
////unboxing
//Console.WriteLine(r);

//int req2 = 40;
//object obj1 = req2; //boxing

//Person.name = "Arzu";
//Person.age = 40;


//Console.WriteLine(Person.ShowPersonInfo());


//Console.WriteLine("Sirket proqramina xos gelmisiniz");
//Console.WriteLine("Sirketinizde ne masini olsun isteyersiniz?");
//Console.WriteLine("marka: ");
//string mrk=Console.ReadLine();

//Console.WriteLine("model: ");
//string model = Console.ReadLine();

//Console.WriteLine("FuelEff: ");
//string fuelEff = Console.ReadLine();


//Car.AddCar(mrk, model, Convert.ToDecimal(fuelEff));

string input = "";
Car cr = new Car();
cr.Marka = "Bmw";
cr.Model = "F10";
cr.FuelEff = 15;
cr.CurrentFuel = 55;
cr.MaxFuel = 80;
do
{
    Console.WriteLine("1.GO");
    Console.WriteLine("2.Top Up");
    Console.WriteLine("3.Stop");
    Console.WriteLine("4.Exit");
    Console.Write(">>>>>");
    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            cr.GO();
            break;
        case "2":
            Console.WriteLine("Benzini vurdum");
            break;
        case "3":
            Console.WriteLine("Masin bu qeder getdi");
            break;
        case "4":
            Console.WriteLine("Yaxsi yol!");
            break;
        default:
            Console.WriteLine("Yuxaridaki reqemlerden birini daxil et😘");
            break;
    }

} while (input != "4");

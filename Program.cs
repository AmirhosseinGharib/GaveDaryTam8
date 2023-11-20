
//moarefy 10 cow dar in projeh
//tamrin 8 (Gave Dari)
 


using System.Reflection;

Animal cow1 = new Animal() 
{
    name = "cow 1",
    type = "pestandar",
    gender = "nar",
    maximumage = 7,
    age = 3,
    vazn = 860,
    VaznCharby= 150,
    MadfoeRozaneh = 2,
    ModelGhaza = "yonje",
    HajmGhaza = 2,
    Bimary= "not bimari",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",Vahed="kilogram",gheymat = 480000 }

    }
};

Animal cow2 = new Animal()
{
    name = "cow 2",
    type = "pestandar",
    gender = "madeh",
    maximumage = 7,
    age = 4,
    vazn = 750,
    VaznCharby = 65,
    MadfoeRozaneh = 3,
    ModelGhaza = "yonje",
    HajmGhaza = 2,
    Bimary = "bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",Vahed="litr",gheymat = 20000,MeghdarRoozaneh=1 }

    }
};

Animal cow3 = new Animal()
{

    name = "cow 3",
    type = "pestandar",
    gender = "madeh",
    maximumage = 7,
    age = 5,
    vazn = 790,
    VaznCharby = 153,
    MadfoeRozaneh = 2.5,
    ModelGhaza = "yonje",
    HajmGhaza = 3,
    Bimary = "bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",Vahed="litr",gheymat = 20000,MeghdarRoozaneh=1 }

    }

};
Animal cow4 = new Animal()
{

    name = "cow 4",
    type = "pestandar",
    gender = "madeh",
    maximumage = 7,
    age = 5,
    vazn = 840,
    VaznCharby = 194,
    MadfoeRozaneh = 3.5,
    ModelGhaza = "alaf",
    HajmGhaza = 5,
    Bimary = " not bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",Vahed="litr",gheymat = 20000,MeghdarRoozaneh=2 }

    }

};
Animal cow5 = new Animal()
{

    name = "cow 5",
    type = "pestandar",
    gender = "nar",
    maximumage = 7,
    age = 6,
    vazn = 851,
    VaznCharby = 110,
    MadfoeRozaneh = 2.5,
    ModelGhaza = "alaf",
    HajmGhaza = 3,
    Bimary = " not bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",Vahed="kilogram",gheymat = 480000, }

    }



};


Animal cow6 = new Animal()
{

    name = "cow 6",
    type = "pestandar",
    gender = "madeh",
    maximumage = 7,
    age = 5,
    vazn = 1001,
    VaznCharby = 222,
    MadfoeRozaneh = 4,
    ModelGhaza = "yonje",
    HajmGhaza = 4,
    Bimary = " not bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",Vahed="litr",gheymat = 20000,MeghdarRoozaneh=2 }

    }


};
Animal cow7 = new Animal()
{

    name = "cow 7",
    type = "pestandar",
    gender = "madeh",
    maximumage = 7,
    age = 6,
    vazn = 1110,
    VaznCharby = 215,
    MadfoeRozaneh = 5,
    ModelGhaza = "yonje",
    HajmGhaza = 5,
    Bimary = "bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",Vahed="litr",gheymat = 20000,MeghdarRoozaneh=2 }

    }


};

Animal cow8 = new Animal()
{

    name = "cow 8",
    type = "pestandar",
    gender = "nar",
    maximumage = 7,
    age = 7,
    vazn = 650,
    VaznCharby = 99,
    MadfoeRozaneh = 3,
    ModelGhaza = "yonje",
    HajmGhaza = 5,
    Bimary = " not bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",Vahed="kilogram",gheymat = 480000 }

    }

};
Animal cow9 = new Animal()
{

    name = "cow 9",
    type = "pestandar",
    gender = "nar",
    maximumage = 7,
    age = 4,
    vazn = 766,
    VaznCharby = 97,
    MadfoeRozaneh = 2,
    ModelGhaza = "yonje",
    HajmGhaza = 4,
    Bimary = "bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",Vahed="kilogram",gheymat = 480000 }

    }


};
Animal cow10 = new Animal()
{

    name = "cow 10",
    type = "pestandar",
    gender = "madeh",
    maximumage = 7,
    age = 3,
    vazn = 888,
    VaznCharby = 116,
    MadfoeRozaneh = 4,
    ModelGhaza = "yonje",
    HajmGhaza = 2,
    Bimary = " not bimar",
    ModelPoost = "charm",
    products = new List<Product>()
    {
        new Product(){name = "milk",Vahed="litr",gheymat = 20000,MeghdarRoozaneh=2 }

    }

};


Console.WriteLine("which part do you want to see?");
Console.WriteLine(" 1 = moshakhasat gave ha \n 2 = sood goosht gave nar \n 3 = sood rozane gave madeh \n 4 = daramad rozane madfo \n 5 = mizan hazine rozane \n 6 = takhmin baravord maly har gave ta akhare omr \n 7 = mohasebeh takhmin sood GaveDary dar n sal ayandeh be tartib sal ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1)

{

    Console.WriteLine(cow1.name + "=" + "type:" + cow1.type + ",gender:" + cow1.gender + ",maximumage:" + cow1.age + ",age:" + cow1.age + ",vazn:" + cow1.vazn + ",Vazn Charby:" + cow1.VaznCharby + ",Madfoe Rozaneh:" + cow1.MadfoeRozaneh + ",Model Ghaza:" + cow1.ModelGhaza + ",Hajm Ghaza:" + cow1.HajmGhaza + ", Bimary:" + cow1.Bimary + ",Model Poost:" + cow1.ModelPoost);
    Console.WriteLine(cow2.name + "=" + "type:" + cow2.type + ",gender:" + cow2.gender + ",maximumage:" + cow2.age + ",age:" + cow2.age + ",vazn:" + cow2.vazn + ",Vazn Charby:" + cow2.VaznCharby + ",Madfoe Rozaneh:" + cow2.MadfoeRozaneh + ",Model Ghaza:" + cow2.ModelGhaza + ",Hajm Ghaza:" + cow1.HajmGhaza + ", Bimary:" + cow2.Bimary + ",Model Poost:" + cow2.ModelPoost);
    Console.WriteLine(cow3.name + "=" + "type:" + cow3.type + ",gender:" + cow3.gender + ",maximumage:" + cow3.age + ",age:" + cow3.age + ",vazn:" + cow3.vazn + ",Vazn Charby:" + cow3.VaznCharby + ",Madfoe Rozaneh:" + cow3.MadfoeRozaneh + ",Model Ghaza:" + cow3.ModelGhaza + ",Hajm Ghaza:" + cow3.HajmGhaza + ", Bimary:" + cow3.Bimary + ",Model Poost:" + cow3.ModelPoost);
    Console.WriteLine(cow4.name + "=" + "type:" + cow4.type + ",gender:" + cow4.gender + ",maximumage:" + cow4.age + ",age:" + cow4.age + ",vazn:" + cow4.vazn + ",Vazn Charby:" + cow4.VaznCharby + ",Madfoe Rozaneh:" + cow4.MadfoeRozaneh + ",Model Ghaza:" + cow4.ModelGhaza + ",Hajm Ghaza:" + cow4.HajmGhaza + ", Bimary:" + cow4.Bimary + ",Model Poost:" + cow4.ModelPoost);
    Console.WriteLine(cow5.name + "=" + "type:" + cow5.type + ",gender:" + cow5.gender + ",maximumage:" + cow5.age + ",age:" + cow5.age + ",vazn:" + cow5.vazn + ",Vazn Charby:" + cow5.VaznCharby + ",Madfoe Rozaneh:" + cow5.MadfoeRozaneh + ",Model Ghaza:" + cow5.ModelGhaza + ",Hajm Ghaza:" + cow5.HajmGhaza + ", Bimary:" + cow5.Bimary + ",Model Poost:" + cow5.ModelPoost);
    Console.WriteLine(cow6.name + "=" + "type:" + cow6.type + ",gender:" + cow6.gender + ",maximumage:" + cow6.age + ",age:" + cow6.age + ",vazn:" + cow6.vazn + ",Vazn Charby:" + cow6.VaznCharby + ",Madfoe Rozaneh:" + cow6.MadfoeRozaneh + ",Model Ghaza:" + cow6.ModelGhaza + ",Hajm Ghaza:" + cow6.HajmGhaza + ", Bimary:" + cow6.Bimary + ",Model Poost:" + cow6.ModelPoost);
    Console.WriteLine(cow7.name + "=" + "type:" + cow7.type + ",gender:" + cow7.gender + ",maximumage:" + cow7.age + ",age:" + cow7.age + ",vazn:" + cow7.vazn + ",Vazn Charby:" + cow7.VaznCharby + ",Madfoe Rozaneh:" + cow7.MadfoeRozaneh + ",Model Ghaza:" + cow7.ModelGhaza + ",Hajm Ghaza:" + cow7.HajmGhaza + ", Bimary:" + cow7.Bimary + ",Model Poost:" + cow7.ModelPoost);
    Console.WriteLine(cow8.name + "=" + "type:" + cow8.type + ",gender:" + cow8.gender + ",maximumage:" + cow8.age + ",age:" + cow8.age + ",vazn:" + cow8.vazn + ",Vazn Charby:" + cow8.VaznCharby + ",Madfoe Rozaneh:" + cow8.MadfoeRozaneh + ",Model Ghaza:" + cow8.ModelGhaza + ",Hajm Ghaza:" + cow8.HajmGhaza + ", Bimary:" + cow8.Bimary + ",Model Poost:" + cow8.ModelPoost);
    Console.WriteLine(cow9.name + "=" + "type:" + cow9.type + ",gender:" + cow9.gender + ",maximumage:" + cow9.age + ",age:" + cow9.age + ",vazn:" + cow9.vazn + ",Vazn Charby:" + cow9.VaznCharby + ",Madfoe Rozaneh:" + cow9.MadfoeRozaneh + ",Model Ghaza:" + cow9.ModelGhaza + ",Hajm Ghaza:" + cow9.HajmGhaza + ", Bimary:" + cow9.Bimary + ",Model Poost:" + cow9.ModelPoost);
    Console.WriteLine(cow10.name + "=" + "type:" + cow10.type + ",gender:" + cow10.gender + ",maximumage:" + cow10.age + ",age:" + cow10.age + ",vazn:" + cow10.vazn + ",Vazn Charby:" + cow10.VaznCharby + ",Madfoe Rozaneh:" + cow10.MadfoeRozaneh + ",Model Ghaza:" + cow10.ModelGhaza + ",Hajm Ghaza:" + cow10.HajmGhaza + ", Bimary:" + cow10.Bimary + ",Model Poost:" + cow10.ModelPoost);
}

if (x == 2)
{

    Console.WriteLine("sood in gav=" + cow1.name + ":" + ((cow1.vazn - cow1.VaznCharby) * 480000));
    Console.WriteLine("sood in gav=" + cow5.name + ":" + ((cow5.vazn - cow5.VaznCharby) * 480000));
    Console.WriteLine("sood in gav=" + cow8.name + ":" + ((cow8.vazn - cow8.VaznCharby) * 480000));
    Console.WriteLine("sood in gav=" + cow9.name + ":" + ((cow9.vazn - cow9.VaznCharby) * 480000));

}

if (x == 3)
{
    Console.WriteLine(cow2.name + ":" + (1 * 20000));
    Console.WriteLine(cow3.name + ":" + (1 * 20000));
    Console.WriteLine(cow4.name + ":" + (2 * 20000));
    Console.WriteLine(cow6.name + ":" + (2 * 20000));
    Console.WriteLine(cow7.name + ":" + (2 * 20000));
    Console.WriteLine(cow10.name + ":" + (2 * 20000));
}
if (x == 4)
{

    Console.WriteLine(cow1.name + ":" + (cow1.MadfoeRozaneh * 2000));
    Console.WriteLine(cow2.name + ":" + (cow2.MadfoeRozaneh * 2000));
    Console.WriteLine(cow3.name + ":" + (cow3.MadfoeRozaneh * 2000));
    Console.WriteLine(cow4.name + ":" + (cow4.MadfoeRozaneh * 2000));
    Console.WriteLine(cow5.name + ":" + (cow5.MadfoeRozaneh * 2000));
    Console.WriteLine(cow6.name + ":" + (cow6.MadfoeRozaneh * 2000));
    Console.WriteLine(cow7.name + ":" + (cow7.MadfoeRozaneh * 2000));
    Console.WriteLine(cow8.name + ":" + (cow8.MadfoeRozaneh * 2000));
    Console.WriteLine(cow9.name + ":" + (cow9.MadfoeRozaneh * 2000));
    Console.WriteLine(cow10.name + ":" + (cow10.MadfoeRozaneh * 2000));



}
if (x == 5)
{

    Console.WriteLine(cow1.name + ":" + (cow1.HajmGhaza * 12000));
    Console.WriteLine(cow2.name + ":" + (cow2.HajmGhaza * 12000));
    Console.WriteLine(cow3.name + ":" + (cow3.HajmGhaza * 12000));
    Console.WriteLine(cow4.name + ":" + (cow4.HajmGhaza * 12000));
    Console.WriteLine(cow5.name + ":" + (cow5.HajmGhaza * 12000));
    Console.WriteLine(cow6.name + ":" + (cow6.HajmGhaza * 12000));
    Console.WriteLine(cow7.name + ":" + (cow7.HajmGhaza * 12000));
    Console.WriteLine(cow8.name + ":" + (cow8.HajmGhaza * 12000));
    Console.WriteLine(cow9.name + ":" + (cow9.HajmGhaza * 12000));
    Console.WriteLine(cow10.name + ":" + (cow10.HajmGhaza * 12000));



}
if(x==6)
{

    Console.WriteLine(cow1.name + ":" + (((cow1.MadfoeRozaneh * 2000)) * 365 * 5));
    Console.WriteLine(cow2.name + ":" + (((cow2.MadfoeRozaneh * 2000) + (1 * 20000))*365* 4 ));
    Console.WriteLine(cow3.name + ":" + (((cow3.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 * 3));
    Console.WriteLine(cow4.name + ":" + (((cow4.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 3));
    Console.WriteLine(cow5.name + ":" + (((cow5.MadfoeRozaneh * 2000)) * 365 * 2));
    Console.WriteLine(cow6.name + ":" + (((cow6.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 3));
    Console.WriteLine(cow7.name + ":" + (((cow7.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 2));
    Console.WriteLine(cow8.name + ":" + (((cow8.MadfoeRozaneh * 2000)) * 365 ));
    Console.WriteLine(cow9.name + ":" + (((cow9.MadfoeRozaneh * 2000)) * 365 * 4));
    Console.WriteLine(cow10.name + ":" + (((cow10.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 5));

}
if(x==7)
{
    Console.WriteLine("takhmin sal aval1 gave ha==>"
        + "Cow1:" + (((cow1.MadfoeRozaneh * 2000))*365) 
        + "////" +"Cow2:"+((cow2.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 
        + "////" + "Cow3:" + ((cow3.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 
        + "////" + "Cow4:" + ((cow4.MadfoeRozaneh * 2000) + (2 * 20000)) * 365
        + "////" + "Cow5:" + (((cow5.MadfoeRozaneh * 2000))*365 
        + "////" + "Cow6:" + ((cow6.MadfoeRozaneh * 2000) + (2 * 20000)) * 365
        + "////" + "Cow7:" + ((cow7.MadfoeRozaneh * 2000) + (2 * 20000)) * 365
        + "////" + "Cow8:" + (((cow8.MadfoeRozaneh * 2000)) * 365
        + "////" + "Cow9:" + (((cow9.MadfoeRozaneh * 2000)) * 365
        + "////" + "Cow10:" + ((cow10.MadfoeRozaneh * 2000) + (2 * 20000)) * 365))));

    Console.WriteLine("takhmin sal dovom2 gave ha==>"
        + "Cow1:" + (((cow1.MadfoeRozaneh * 2000)) * 365 * 2)
        + "////" + "Cow2:" + ((cow2.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 * 2
        + "////" + "Cow3:" + ((cow3.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 * 2
        + "////" + "Cow4:" + ((cow4.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 2
        + "////" + "Cow5:" + (((cow5.MadfoeRozaneh * 2000)) * 365 * 2
        + "////" + "Cow6:" + ((cow6.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 2
        + "////" + "Cow7:" + ((cow7.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 2 
        + "////" + "Cow9:" + (((cow9.MadfoeRozaneh * 2000)) * 365 * 2
        + "////" + "Cow10:" + ((cow10.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 2 )));

    Console.WriteLine("takhmin sal sevom3 gave ha==>"
       + "Cow1:" + (((cow1.MadfoeRozaneh * 2000)) * 365 * 3)
       + "////" + "Cow2:" + ((cow2.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 * 3
       + "////" + "Cow3:" + ((cow3.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 * 3
       + "////" + "Cow4:" + ((cow4.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 3
       + "////" + "Cow6:" + ((cow6.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 3
       + "////" + "Cow9:" + (((cow9.MadfoeRozaneh * 2000)) * 365 * 3
       + "////" + "Cow10:" + ((cow10.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 3));

    Console.WriteLine("takhmin sal chaharom4 gave ha==>"
      + "Cow1:" + (((cow1.MadfoeRozaneh * 2000)) * 365 * 4)
      + "////" + "Cow2:" + ((cow2.MadfoeRozaneh * 2000) + (1 * 20000)) * 365 * 4
      + "////" + "Cow9:" + (((cow9.MadfoeRozaneh * 2000)) * 365 * 4
      + "////" + "Cow10:" + ((cow10.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 4));

    Console.WriteLine("takhmin sal pangoom5 gave ha==>"
     + "Cow1:" + (((cow1.MadfoeRozaneh * 2000)) * 365 * 5)
     + "////" + "Cow10:" + ((cow10.MadfoeRozaneh * 2000) + (2 * 20000)) * 365 * 5);

    Console.WriteLine("takhmin sal sheshom6 gave ha==>" + "======>>" + "payan zendegi hameh gave ha");
}

class Animal
{
    public string name { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public double maximumage { get; set; }
    public double age { get; set; }
    public double vazn { get; set; }
    public double VaznCharby { get; set; }
    public double MadfoeRozaneh { get; set; }
    public string ModelGhaza { get; set; }
    public double HajmGhaza { get; set; }
    public string Bimary { get; set; }
    public string ModelPoost { get; set; }
    public List<Product> products { get; set; }






}
class Product
{

    public string name { get; set; }
    public string Vahed { get; set; }
    public double gheymat { get; set; }
    public double MeghdarRoozaneh { get; set; }









}



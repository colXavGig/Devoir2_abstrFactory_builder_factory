
using Devoir2_abstrFactory_builder_factory.AbstractFactory;
using Devoir2_abstrFactory_builder_factory.Builder;
using Devoir2_abstrFactory_builder_factory.Data.Building;
using Devoir2_abstrFactory_builder_factory.FactoryMethod.v2.Basement;
using System.Diagnostics;
Main();
static void Main()
{
    Director director;
    IBuilding building;
    //----------- testing house builders -----------//
    HouseBuilder Housebuilder;

    //Quebecois house
    Housebuilder = new HouseBuilder(new QuebecoisFactory());
    director = new Director(Housebuilder);
    building = director.build();

    Debug.Assert("This house as: quebecois basement, quebecois structure, quebecois interior, quebecois roof" == building.Display());

    //Persian house
    Housebuilder = new HouseBuilder(new PersianFactory());
    director = new Director(Housebuilder);

    building = director.build();
    Debug.Assert("This house as: persian basement, persian structure, persian interior, persian roof" == building.Display());


    //modern house
    Housebuilder = new HouseBuilder(new ModernFactory());
    director = new Director(Housebuilder);

    building = director.build();
    Debug.Assert("This house as: modern basement, modern structure, modern interior, modern roof" == building.Display());



     
    //----------- testing duplex builders -----------//
    DuplexBuilder Duplexbuilder;

    //Quebecois house
    Duplexbuilder = new DuplexBuilder(new QuebecoisFactory());
    director = new Director(Duplexbuilder);

    building = director.build();
    Debug.Assert("This duplex as: quebecois basement, quebecois structure, quebecois interior, quebecois roof" == building.Display());

    //Persian house
    Duplexbuilder = new DuplexBuilder(new PersianFactory());
    director = new Director(Duplexbuilder);

    building = director.build();
    Debug.Assert("This duplex as: persian basement, persian structure, persian interior, persian roof" == building.Display());


    //modern house
    Duplexbuilder = new DuplexBuilder(new ModernFactory());
    director = new Director(Duplexbuilder);

    building = director.build();
    Debug.Assert("This duplex as: modern basement, modern structure, modern interior, modern roof" == building.Display());

    Console.WriteLine("all good");
}

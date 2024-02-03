using DesignPatterns.Behavioural;
using DesignPatterns.Creational;
using DesignPatterns.Structural;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Behavioural patterns
            #region Chain Of Responsibility
            var supportChain = new SupportChain();
            supportChain.ProcessRequest("Technical"); // Handled by TechnicalSupportHandler
            supportChain.ProcessRequest("Billing"); // Handled by BillingSupportHandler
            supportChain.ProcessRequest("Unknown"); // Handled by GeneralSupportHandler
            #endregion

            #region Command
            Television tv = new Television();
            ICommand turnOn = new TurnOnTVCommand(tv);
            ICommand turnOff = new TurnOffTVCommand(tv);

            Command_RemoteControl remote = new Command_RemoteControl();

            remote.Submit(turnOn);  // TV is turned on
            remote.Submit(turnOff); // TV is turned off
            #endregion

            #region Interpreter
            var interpreter = new ExpressionInterpreter();
            Console.WriteLine("Result by Interpreter: " + interpreter.Evaluate("5 + 10"));
            #endregion

            #region Iterator
            var bookCollection = new BookCollection();
            bookCollection.AddBook("The Great Gatsby");
            bookCollection.AddBook("1984");
            bookCollection.AddBook("To Kill a Mockingbird");

            var iterator = bookCollection.CreateIterator();

            for (string book = iterator.First(); !iterator.IsDone; book = iterator.Next())
            {
                Console.WriteLine(book);
            }
            #endregion

            #region Mediator
            ICommunicationMediator mediator = new CommunicationMediator();

            CommsUser user1 = new Pilot(mediator, "1");
            CommsUser user2 = new Pilot(mediator, "2");
            CommsUser user3 = new Pilot(mediator, "3");

            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user1.Send("Ramp, United 530, gate Echo 7, ready to push.");
            user2.Send("United 530, push tail east, contact ground 121.8 when ready to taxi");
            user1.Send("Minneapolis Ground, United 530 Information Foxtrot, gate E7. Ready to taxi.");
            user3.Send("United 530, taxi to runway 30L via Quebec, Delta, Hold short Bravo United 530.");
            #endregion

            #region Memento
            Editor editor = new Editor();
            EditorHistory history = new EditorHistory();

            editor.Content = "Text 1";
            history.SaveState(editor);

            editor.Content = "Text 2";
            history.SaveState(editor);

            editor.Content = "Text 3";

            // Restoring to State 2
            history.RestoreState(editor);
            Console.WriteLine(editor.Content); // State 2

            // Restoring to State 1
            history.RestoreState(editor);
            Console.WriteLine(editor.Content); // State 1
            #endregion

            #region Observer
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();

            weatherData.RegisterObserver(currentDisplay);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            #endregion

            #region State
            TrafficLight trafficLight = new TrafficLight(new GreenLightState());

            trafficLight.ReportState();
            trafficLight.ChangeState();

            trafficLight.ReportState();
            trafficLight.ChangeState();

            trafficLight.ReportState();
            trafficLight.ChangeState();
            #endregion

            #region Strategy
            var navigationSystem = new NavigationSystem();

            navigationSystem.SetRouteStrategy(new ShortestRouteStrategy());
            navigationSystem.Navigate("Home", "Office");

            navigationSystem.SetRouteStrategy(new FastestRouteStrategy());
            navigationSystem.Navigate("Home", "Supermarket");

            navigationSystem.SetRouteStrategy(new ScenicRouteStrategy());
            navigationSystem.Navigate("Home", "Park");
            #endregion

            #region Template Method
            DataProcessor xmlProcessor = new XmlDataProcessor();
            xmlProcessor.ProcessData();

            DataProcessor jsonProcessor = new JsonDataProcessor();
            jsonProcessor.ProcessData();
            #endregion

            #region Visitor
            IComputerPart computer = new Behavioural.Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
            #endregion
            #endregion

            #region Creational patterns
            #region Abstract
            IFurnitureFactory modernFactory = new ModernFurnitureFactory();
            IChair modernChair = modernFactory.CreateChair();
            ISofa modernSofa = modernFactory.CreateSofa();
            ITable modernTable = modernFactory.CreateTable();

            Console.WriteLine(modernChair.Style);
            Console.WriteLine(modernSofa.Style);
            Console.WriteLine(modernTable.Style);

            IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
            IChair victorianChair = victorianFactory.CreateChair();
            ISofa victorianSofa = victorianFactory.CreateSofa();
            ITable victorianTable = victorianFactory.CreateTable();

            Console.WriteLine(victorianChair.Style);
            Console.WriteLine(victorianSofa.Style);
            Console.WriteLine(victorianTable.Style);
            #endregion

            #region Builder
            var gamingComputerBuilder = new GamingComputerBuilder();
            var computerDirector = new ComputerDirector(gamingComputerBuilder);

            computerDirector.ConstructComputer();
            var gamingComputer = computerDirector.GetComputer();
            gamingComputer.DisplayConfiguration();

            var officeComputerBuilder = new OfficeComputerBuilder();
            computerDirector = new ComputerDirector(officeComputerBuilder);

            computerDirector.ConstructComputer();
            var officeComputer = computerDirector.GetComputer();
            officeComputer.DisplayConfiguration();
            #endregion

            #region Factory Method
            TransportCompany roadLogistics = new RoadLogistics();
            roadLogistics.PlanDelivery(); // Delivery by Truck

            TransportCompany seaLogistics = new SeaLogistics();
            seaLogistics.PlanDelivery(); // Delivery by Ship
            #endregion

            #region Prototype
            Prototype_Circle originalCircle = new Prototype_Circle(10);
            originalCircle.Display();

            Prototype_Circle clonedCircle = (Prototype_Circle)originalCircle.Clone();
            clonedCircle.Radius = 20;
            clonedCircle.Display();

            Prototype_Rectangle originalRectangle = new Prototype_Rectangle(5, 7);
            originalRectangle.Display();

            Prototype_Rectangle clonedRectangle = (Prototype_Rectangle)originalRectangle.Clone();
            clonedRectangle.Width = 10;
            clonedRectangle.Height = 14;
            clonedRectangle.Display();
            #endregion

            #region Singleton
            var government1 = Government.GetInstance("John Doe");
            government1.DisplayPresident();

            var government2 = Government.GetInstance("Jane Smith");
            government2.DisplayPresident(); // Still shows "John Doe", as it's a singleton
            #endregion
            #endregion

            #region Structural patterns
            #region Adapter
            IXmlData legacyData = new LegacyXmlData();
            IJsonData adaptedData = new XmlToJsonAdapter(legacyData);

            Console.WriteLine(adaptedData.GetJson()); // Converts and shows the data in JSON format
            #endregion
            #region Bridge
            IDevice tv1 = new TV();
            Bridge_RemoteControl remote1 = new BasicRemote(tv1);

            remote1.TurnOn();
            remote1.SetChannel(5);
            remote1.TurnOff();

            IDevice radio = new Bridge_Radio();
            remote1 = new BasicRemote(radio);

            remote1.TurnOn();
            remote1.SetChannel(3);
            remote1.TurnOff();
            #endregion
            #region Composite
            var circle = new Structural.Circle();
            var rectangle = new Structural.Rectangle();

            var group = new GraphicGroup();
            group.Add(circle);
            group.Add(rectangle);

            group.Draw();
            group.Move(1, 2);
            #endregion
            #region Decorator
            IMessage message = new TextMessage("Hello, World!");
            Console.WriteLine(message.Content);

            IMessage encryptedMessage = new EncryptedMessage(message);
            Console.WriteLine(encryptedMessage.Content);

            IMessage htmlMessage = new HTMLMessage(message);
            Console.WriteLine(htmlMessage.Content);
            #endregion
            #region Facade
            Amplifier amp = new Amplifier();
            DvdPlayer dvd = new DvdPlayer();
            Projector projector = new Projector();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, dvd, projector);
            homeTheater.WatchMovie("Inception");
            #endregion
            #region Flyweight
            CharacterFactory factory = new CharacterFactory();

            string document = "Hello, World!";
            int fontSize = 12; // All characters share the same font size for simplicity

            foreach (char c in document)
            {
                Character character = factory.GetCharacter(c, fontSize);
                character.Display();
            }
            #endregion
            #region Proxy
            IPrinter printer = new PrinterProxy();
            printer.PrintDocument("MyDocument.pdf");
            #endregion
            #endregion
        }
    }
}

var ceruleanApi = CeruleanAPI.GetAPI()
                             .UseSDL2Graphics()
                             .UseConsoleLogger()
                             .Initialize();

var window = ceruleanApi.CreateWindow("ExampleLayout");

ceruleanApi.WaitForAllWindowsClosed(true);

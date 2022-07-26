var ceruleanApi = CeruleanAPI.GetAPI()
                             .UseSDL2Graphics()
                             .UseConsoleLogger()
                             .Initialize();

var window = ceruleanApi.CreateWindow("MainLayout", "Calculator App");

ceruleanApi.WaitForAllWindowsClosed(true);

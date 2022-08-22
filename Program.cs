var callback = (CeruleanAPI ceruleanApi) => {
    _ = ceruleanApi.CreateWindow("MainLayout", "Calculator App");
};

var ceruleanApi = CeruleanAPI.GetAPI()
                             .UseSDL2Graphics()
                             .UseConsoleLogger()
                             .Initialize(callback, true, true);

ceruleanApi.WaitForAllWindowsClosed(true);

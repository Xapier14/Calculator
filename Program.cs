var callback = (CeruleanAPI ceruleanApi) => {
    _ = ceruleanApi.CreateWindow("MainLayout", "Calculator App");
};

var ceruleanApi = CeruleanAPI.GetAPI()
                             .UseSDL2Graphics()
                             .UseConsoleLogger()
                             .Initialize(callback);

ceruleanApi.WaitForAllWindowsClosed(true);

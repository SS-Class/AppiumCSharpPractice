namespace DemoAppium
{
    public static class WebUrl
    {
        public static string BaseUrl { get; set; } = "http://demo.automationtesting.in";
        public static string SignInPage { get; set; } = BaseUrl + "/SignIn.html";
        public static string RegisterPage { get; set; } = BaseUrl + "/Register.html";
    }
}
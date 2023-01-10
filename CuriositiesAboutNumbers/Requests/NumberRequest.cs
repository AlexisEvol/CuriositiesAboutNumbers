namespace CuriositiesAboutNumbers
{
    internal class NumberRequest
    {
        private HttpClient httpClient = new HttpClient();
        private HttpRequestMessage request = new HttpRequestMessage();
        private HttpResponseMessage response;
        public async Task<string> requestNumber(int numberWriten)
        {
            request.RequestUri = new Uri($"http://numbersapi.com/{numberWriten}/math");
            request.Method = HttpMethod.Get;

            response = httpClient.Send(request);

            httpClient.Dispose();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
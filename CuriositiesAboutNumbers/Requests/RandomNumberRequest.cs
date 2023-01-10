namespace CuriositiesAboutNumbers
{
    internal class RandomNumberRequest
    {
        private HttpClient httpClient = new HttpClient();
        private HttpRequestMessage request = new HttpRequestMessage();
        private HttpResponseMessage response;
        public async Task<string> requestRandomNumber()
        {
            request.RequestUri = new Uri($"http://numbersapi.com/random/math");
            request.Method = HttpMethod.Get;

            response = httpClient.Send(request);

            httpClient.Dispose();

            return await response.Content.ReadAsStringAsync();
        }
    }
}

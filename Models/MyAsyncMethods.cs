namespace LanguageFeatures.Model;

public class MyAsyncMethods {
    public static Task<long?> GetPageLength() {
        HttpClient client = new();
        var httpTask = client.GetAsync("https://novelbin.com/");
        return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) => {
            return antecedent.Result.Content.Headers.ContentLength;
        });
    }

    public static async Task<IEnumerable<long?>> GetPageLengths(List<string> output, params string[] urls) {
        List<long?> results = new();
        HttpClient client = new();
        foreach (string url in urls) {
            output.Add($"Started request for {url}");
            var httpMessage = await client.GetAsync($"https://{url}");
            results.Add(httpMessage.Content.Headers.ContentLength);
            output.Add($"Completed request for {url}");
        }

        return results;
    }

    public static async IAsyncEnumerable<long?> GetPageLengthsAsync(List<string> output, params string[] urls) {
        HttpClient client = new();
        foreach (string url in urls) {
            output.Add($"Started request for {url}");
            var httpMessage = await client.GetAsync($"https://{url}");
            output.Add($"Completed request for {url}");
            yield return httpMessage.Content.Headers.ContentLength;
        }
    }
}
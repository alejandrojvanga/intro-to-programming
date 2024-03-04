using Alba;

namespace TodosApi.ContractTests.StatusResource;
public class GettingTheStatus
{
    [Fact]
    public async Task ReturnsOk()
    {
        /* Example
        var host = await AlbaHost.For<Program>();

        var responce = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
        });
        */

        var host = await AlbaHost.For<Program>();

        var responce = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
        });

        /*  First Method
        // Given
        var client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:1337");

        // When
        var responce = await client.GetAsync("/status");

        // Then
        Assert.Equal(System.Net.HttpStatusCode.OK, responce.StatusCode);
        */

    }
}

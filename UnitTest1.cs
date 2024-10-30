using Microsoft.Playwright;

namespace Testes
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class TesteInicial : PageTest
    {
        [Test]
        public async Task TesteLogin()
        {
            await Page.GotoAsync("https://localhost:44317/login");


            await Page.FillAsync("#username", "oiorlando123");
            await Page.FillAsync("#senha", "123mudar");

            await Page.ClickAsync("#botao");

            await Task.Delay(3000);

            await Expect(Page.GetByText("Bem-vindo, orlando!")).ToBeVisibleAsync();

        }
    }
}

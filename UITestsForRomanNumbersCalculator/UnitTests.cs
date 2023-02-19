using Avalonia.Controls;
using Avalonia.VisualTree;
using ReactiveUI;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTestPlus
    {
        [Fact]
        public async void UnitTest1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "XV";

            await Task.Delay(100);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "+");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);

            await Task.Delay(100);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);

            //Assert.Equal(1, 1);
        }
    }
    public class UnitTestSub
    {
        [Fact]
        public async void UnitTest2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "V";

            await Task.Delay(100);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "-");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);

            await Task.Delay(100);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);

            //Assert.Equal(1, 1);
        }
    }
    public class UnitTestDub
    {
        [Fact]
        public async void UnitTest3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "II";

            await Task.Delay(1000);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            var buttonDub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "/");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonDub.Command.Execute(buttonDub.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);

            await Task.Delay(1000);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);

        }
    }
    public class UnitTestMul
    {
        [Fact]
        public async void UnitTest4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "L";

            await Task.Delay(100);
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "*");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");

            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);

            await Task.Delay(100);

            var result = (textBox.Text as string);

            Assert.True(result.Equals(answer), textBox.Text);

        }
    }
    public class UnitTestAdd
    {
        [Fact]
        public async void UnitTest4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "MDCLXVI";


            await Task.Delay(100);

            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "M");
            var buttonD = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "D");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "C");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "L");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "V");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");


            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonD.Command.Execute(buttonD.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonL.Command.Execute(buttonL.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);

            await Task.Delay(100);

            var result = (textBox.Text as string);

            buttonCE.Command.Execute(buttonCE.CommandParameter);

            Assert.True(result.Equals(answer), textBox.Text);

        }
    }
    public class UnitTestException
    {
        [Fact]
        public async void UnitTest5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var answer = "#ERROR";


            await Task.Delay(100);

            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "M");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "C");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "X");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "I");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "CE");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "+");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Content == "=");


            var textBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);


            await Task.Delay(100);

            var result = (textBox.Text as string);

            buttonCE.Command.Execute(buttonCE.CommandParameter);

            Assert.True(result.Equals(answer), textBox.Text);

        }
    }
}
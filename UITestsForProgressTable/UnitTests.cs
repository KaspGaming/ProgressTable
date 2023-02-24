using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace UITestsForProgressTable
{
    public class UnitTests
    {
        [Fact]
        public async void ColorTestsRedAndGreen()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var listBoxItems = mainWindow.GetVisualDescendants().OfType<ListBox>().First().GetVisualDescendants().OfType<ListBoxItem>();

            foreach (var listBoxItem in listBoxItems)
            {
                var visualProgrammBorder = listBoxItem.GetVisualDescendants().OfType<Border>().Where(x => x.Name.Equals("VisualProgrammBorder")).First();
                var textBlockVisualProgramm = listBoxItem.GetVisualDescendants().OfType <TextBlock>().Where(x => x.Name.Equals("VisualProgrammText")).First();
                var text = textBlockVisualProgramm.Text;
                Color c;
                if (text == "0") c = Colors.Red;
                if (text == "1") c = Colors.Yellow;
                else c = Colors.Green;
                var color = (visualProgrammBorder.Background as SolidColorBrush).Color;
                Assert.True(color.Equals(c), "Not true");
            }
        }
    }
}
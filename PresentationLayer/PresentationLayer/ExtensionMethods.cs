using System.Collections.Generic;
using System.Linq;
using MetroFramework.Controls;

namespace PresentationLayer
{
    public static class ExtensionMethods
    {
        public static void SelectItemByValue(this MetroComboBox comboBox, int valueToSelect)
        {
            var items = comboBox.Items.OfType<KeyValuePair<int, string>>().Select((item, index) => new { item, index });
            var itemToSelectIndex = items.Where(x => x.item.Key == valueToSelect).Select(x => x.index).First();
            comboBox.SelectedIndex = itemToSelectIndex;
        }
    }
}

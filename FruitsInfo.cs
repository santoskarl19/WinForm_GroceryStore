using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_GroceryStore
{
    internal class FruitsInfo
    {
        // objective:
        // Use StringBuilder and code to concatenate multiple strings.

        public string AppleInfo()
        {
            StringBuilder apple = new StringBuilder();

            apple.Append("Apple");
            apple.Append(" - ");
            apple.Append("$1.99");

            return apple.ToString();
        }

        public string BananaInfo()
        {
            StringBuilder banana = new StringBuilder();

            banana.Append("Banana");
            banana.Append(" - ");
            banana.Append("$2.49");

            return banana.ToString();
        }

        public string OrangeInfo()
        {
            StringBuilder orange = new StringBuilder();

            orange.Append("Orange");
            orange.Append(" - ");
            orange.Append("$0.99");

            return orange.ToString();
        }

        public string PeachInfo()
        {
            StringBuilder peach = new StringBuilder();

            peach.Append("Peach");
            peach.Append(" - ");
            peach.Append("$1.29");

            return peach.ToString();
        }

        public string WatermelonInfo()
        {
            StringBuilder watermelon = new StringBuilder();

            watermelon.Append("Watermelon");
            watermelon.Append(" - ");
            watermelon.Append("$3.99");

            return watermelon.ToString();
        }
    }
}

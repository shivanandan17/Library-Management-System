using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Model;

namespace LibraryManagementSystem.View {
    internal class OutputManager {
        public static void DisplayMenuTitles(List<MenuHandler> menuActions) {
            for (int i = 0; i < menuActions.Count; i++) {
                Console.WriteLine($"{i + 1}. {menuActions[i].Title}");
            }
        }
    }
}
